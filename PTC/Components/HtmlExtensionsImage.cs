using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;

namespace PTC
{
    public static class HtmlExtensionsImage
    {
        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
            string src,
            string altText,
            object htmlAttributes = null)
        {
            return HtmlExtensionsImage.Image(htmlHelper, src, altText,
                string.Empty, string.Empty, htmlAttributes);
        }

        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
           string src,
           string altText,
           string cssClass,
           object htmlAttributes = null)
        {
            return HtmlExtensionsImage.Image(htmlHelper, src, altText,
                cssClass, string.Empty, htmlAttributes);
        }

        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
            string src,
            string altText,
            string cssClass,
            string name,
            object htmlAttributes = null)
        {
           

            TagBuilder tb = new TagBuilder("img");

            HtmlExtensionsCommon.AddName(tb, name, cssClass);

            if (!string.IsNullOrWhiteSpace(name))
            {
                name = TagBuilder.CreateSanitizedId(name);
                tb.GenerateId(name);
                tb.MergeAttribute("name", name);
            }

            tb.MergeAttribute("src", src);
            tb.MergeAttribute("alt", altText);

            if(!string.IsNullOrWhiteSpace(cssClass)){
                tb.AddCssClass(cssClass);
            }

            tb.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));


            ////HTML Encode the string
            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));

            
            
            //StringBuilder Class

            //public static MvcHtmlString Image(this HtmlHelper htmlHelper,
            //string src,
            //string altText,)
            //{
            //    StringBuilder sb = new StringBuilder(512);

            //    sb.AppendFormat("<img src = '{0}' alt='{1}' />",
            //        src, altText);

            //    //HTML Encode the string
            //    return MvcHtmlString.Create(sb.ToString());
            //}
        }
    }
}