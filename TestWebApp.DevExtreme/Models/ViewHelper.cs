using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace TestWebApp.DevExtreme.Models
{
    public partial class ViewHelper : IViewContextAware
    {
        public ViewHelper(IHtmlHelper htmlHelper)
        {
            this.Html = htmlHelper;
        }
        public IHtmlHelper Html
        {
            get;
            private set;
        }

        void IViewContextAware.Contextualize(ViewContext viewContext)
        {
            if (Html is IViewContextAware)
            {
                ((IViewContextAware)Html).Contextualize(viewContext);
            }
        }
    }
}
