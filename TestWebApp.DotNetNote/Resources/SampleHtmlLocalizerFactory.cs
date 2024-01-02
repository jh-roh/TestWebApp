using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Resources;

namespace TestWebApp.DotNetNote.Resources
{

    /// <summary>
    /// IHtmlLocalizerFactory는 View에서 지역화(HTML을 포함하는 리소스)를 할 때 필요하다.
    /// Microsoft.AspNetCore.Mvc.Localization를 참조하고 있다
    /// </summary>
    public class SampleHtmlLocalizerFactory : IHtmlLocalizerFactory
    {
        private readonly IHostingEnvironment _environment;
        private readonly ResourceManager _resourceManager;


        public SampleHtmlLocalizerFactory(IHostingEnvironment environment, ResourceManager resourceManager)
        {
            _environment = environment;
            _resourceManager = resourceManager;
        }

        public IHtmlLocalizer Create(Type resourceSource)
        {
            return new SampleHtmlLocalizer(_environment, _resourceManager);
        }

        public IHtmlLocalizer Create(string baseName, string location)
        {
            return new SampleHtmlLocalizer(_environment, _resourceManager);
        }
    }
}
