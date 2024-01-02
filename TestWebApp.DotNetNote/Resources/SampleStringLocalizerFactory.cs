using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Globalization;
using System;
using Microsoft.AspNetCore.Hosting;
using System.Resources;

namespace TestWebApp.DotNetNote.Resources
{
    public class SampleStringLocalizerFactory : IStringLocalizerFactory
    {
        private readonly IHostingEnvironment _environment;
        private readonly ResourceManager _resourceManager;


        public SampleStringLocalizerFactory(IHostingEnvironment environment, ResourceManager resourceManager)
        {
            _environment = environment;
            _resourceManager = resourceManager;
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
