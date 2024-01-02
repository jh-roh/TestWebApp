using Humanizer.Localisation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace TestWebApp.DotNetNote.Resources
{
    public class SampleHtmlLocalizer : IHtmlLocalizer
    {
        private readonly IHostingEnvironment _environment;
        private readonly ResourceManager _resourceManager;
        public SampleHtmlLocalizer(IHostingEnvironment environment, ResourceManager resourceManager)
        {
            _environment = environment;
            _resourceManager = resourceManager;
        }

        public LocalizedHtmlString this[string name]
        {
            get
            {
                var localizedString = GetString(name);
                return new LocalizedHtmlString(localizedString.Name, localizedString.Value, localizedString.ResourceNotFound);
            }
        }

        public LocalizedHtmlString this[string name, params object[] arguments]
        {
            get
            {
                var localizedString = GetString(name);
                return new LocalizedHtmlString(localizedString.Name, localizedString.Value, localizedString.ResourceNotFound, arguments);
            }
        }

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            throw new NotImplementedException();
        }

        public LocalizedString GetString(string name)
        {
            var exsits = IsFoundResource(name, out string value);
            return new LocalizedString(name, value, exsits);
        }

        public LocalizedString GetString(string name, params object[] arguments)
        {
            var exsits = IsFoundResource(name, out string value);
            return new LocalizedString(name, string.Format(value, arguments), exsits);
        }

        public IHtmlLocalizer WithCulture(CultureInfo culture)
        {
            CultureInfo.DefaultThreadCurrentCulture = culture;
            return new SampleHtmlLocalizer(_environment, _resourceManager);
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
