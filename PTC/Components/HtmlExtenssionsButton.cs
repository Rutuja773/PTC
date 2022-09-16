using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PTC
{
    public static class HtmlExtenssionsButton
    {
        public static MvcHtmlString BootstrapButton(
            this HtmlHelper htmlHelper,
            string innerHtml,
            string cssClass,
            string name)
        {
            TagBuilder tb = new TagBuilder("button");

            if (!string.IsNullOrWhiteSpace(cssClass))
            {
                if (!cssClass.Contains("btn-"))
                {
                    cssClass = "btn-primary " + cssClass;
                }
            }
            else
            {
                cssClass = "btn-primary";
            }
            tb.AddCssClass(cssClass);
            tb.AddCssClass("btn");

            HtmlExtensionsCommon.AddName(tb, name, "");

            tb.InnerHtml = innerHtml;

            tb.MergeAttribute("type", "submit");

            return MvcHtmlString.Create(tb.ToString());
        }
    }
}