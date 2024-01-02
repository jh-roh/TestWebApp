using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace TestWebApp.DotNetNote.Resources
{
    public class SampleStringLocalizer : IStringLocalizer
    {

        private readonly IHostingEnvironment _environment;
        private readonly ResourceManager _resourceManager;


        public SampleStringLocalizer(IHostingEnvironment environment, ResourceManager resourceManager)
        {
            _environment = environment;
            _resourceManager = resourceManager;
        }

        public LocalizedString this[string name]
        {
            get
            {
                var exists = IsFoundResource(name, out string value);
                return new LocalizedString(name, value, exists);
            }
        }

        public LocalizedString this[string name, params object[] arguments]
        {
            get
            {
                var exists = IsFoundResource(name, out string value);
                return new LocalizedString(name, string.Format(value, arguments), exists);
            }
        }

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            throw new NotImplementedException();
        }

        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            CultureInfo.DefaultThreadCurrentCulture = culture;
            return new SampleStringLocalizer(_environment, _resourceManager);
        }

        private bool IsFoundResource(string name, out string value)
        {
            bool isReady = true;
            value = Resource.ResourceManager.GetString(name);

            if (string.IsNullOrEmpty(value))
            {
                value = name;
                isReady = false;
            }

            return isReady;
        }
    }
}
