﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TestWebApp.DotNetNote.Models
{
    /// <summary>
    /// 공통 상수 저장소
    /// </summary>
    public partial class Constants
    {
        public const string DotNetNoteSiteUrl = "http://www.dotnetnote.com";
    }


    public partial class Constants
    {
        public static List<SelectListItem> YesOrNo = new List<SelectListItem>
        {

            new SelectListItem() {Value = "Yes", Text = "--Select--"},
            new SelectListItem() {Value = "Yes", Text = "Yes"},
            new SelectListItem() {Value = "No", Text = "No"},
        };
    }
}
