using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Globalization;
using System;
using Microsoft.AspNetCore.Hosting;


namespace TestWebApp.DotNetNote.Resources
{
    public class SampleStringLocalizerFactory : IStringLocalizerFactory
    {
        private readonly IHostingEnvironment _environment;

        public SampleStringLocalizerFactory(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public IStringLocalizer Create(Type resourceSource)
        {
            return new SampleStringLocalizer(_environment, _resourceManager);
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            return new SampleStringLocalizer(_environment, _resourceManager);
        }
    }
}
