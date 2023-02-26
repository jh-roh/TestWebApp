using Microsoft.AspNetCore.Mvc;
using System;

namespace TestWebApp.DotNetNote.ViewComponents
{
    /// <summary>
    /// Copyright 뷰 컴포넌트
    /// </summary>
    public class CopyrightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string viewName = "Default";

            if(DateTime.Now.Second % 2 == 0 )
            {
                viewName = "Details";
            }

            return View(viewName);
        }

    }
}
