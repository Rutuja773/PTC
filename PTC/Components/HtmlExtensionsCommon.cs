using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTC
{
    public static class HtmlExtensionsCommon
    {
        public static void AddName (TagBuilder tb, string name, string id)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                name = TagBuilder.CreateSanitizedId(name);

                if (string.IsNullOrWhiteSpace(id))
                {
                    tb.GenerateId(name);
                }
                else
                {
                    tb.MergeAttribute("id", TagBuilder.CreateSanitizedId(id));
                }
                tb.GenerateId(name);
                
            }
            tb.MergeAttribute("name", name);
        }
    }
}