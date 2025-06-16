using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Threading.Tasks;
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Concurrent;
using System.Linq;
using System.Xml.Linq;

namespace TestWebApp.WebApi.Services
{
    public class ScriptService
    {
        private readonly string _scriptRootPath;
        private readonly IMemoryCache _memoryCache;

        private readonly ConcurrentDictionary<string, Tuple<string, Script<object>>> _scriptCache = new();


        public ScriptService(IWebHostEnvironment env, IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _scriptRootPath = Path.Combine(env.WebRootPath, "scripts");
        }

        public class ScriptGlobals
        {
            public string name;
        }

        private class CachedScript
        {
            public DateTime LastModified { get; set; }

            public Script<object> CompledScript { get; set; }
        }

        public async Task<object> RunScriptAsync(string fileName, string name)
        {
            ScriptState<object> result = null;
            string scriptPath = Path.Combine(_scriptRootPath, $"{fileName}.csx");
            if (!File.Exists(scriptPath))
                throw new FileNotFoundException(scriptPath);

            string cacheKey = $"script_{scriptPath}";

            var lastModified = File.GetLastWriteTimeUtc(scriptPath);

            var globals = new ScriptGlobals
            {
                name = name,
            };

            // 캐시된 정보 가져오기
            if (_memoryCache.TryGetValue(cacheKey, out CachedScript cachedScript))
            {
                // 파일이 변경되지 않았다면 캐시 사용
                if (cachedScript.LastModified == lastModified)
                {
                    result = await cachedScript.CompledScript.RunAsync(globals);
                    return result.ReturnValue;
                }
            }

            // 변경됨 → 다시 컴파일
            string code = await File.ReadAllTextAsync(scriptPath);

            var compiledScript = CompileScript(code);

            // 새 캐시 저장
            var newCacheItem = new CachedScript
            {
                LastModified = lastModified,
                CompledScript = compiledScript
            };

            _memoryCache.Set(cacheKey, newCacheItem); // 제한시간 없어도 OK
            result = await newCacheItem.CompledScript.RunAsync(globals);
            return result.ReturnValue;
        }

        private Script<object> CompileScript(string code)
        {
            //Roslyn C# scripting 사용
            var options = ScriptOptions.Default
                        .AddReferences(typeof(object).Assembly /*, typeof(TestDBContext).Assembly*/)
                        .AddReferences(typeof(Enumerable).Assembly)
                        .AddImports("System", "System.Linq");

            //var script = CSharpScript.Create(code, ScriptOptions.Default.WithReferences(AppDomain.CurrentDomain.GetAssemblies()));
            var script = CSharpScript.Create(code, options, typeof(ScriptGlobals));
            script.Compile();
            return script;
        }
    }
}
