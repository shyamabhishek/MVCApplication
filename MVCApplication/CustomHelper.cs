using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication
{
    public static class CustomHelper
    {
        //static method
        public static IHtmlString Image(string src, string alt, string width, string height)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}' width='{2}' height='{3}'></img>", src, alt, width, height));
        }
        public static IHtmlString Img(this HtmlHelper helper, string src, string alt, string width, string height)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}' width='{2}' height='{3}'></img>", src, alt, width, height));
        }
        //extention method
        public static IHtmlString ImageTag(this HtmlHelper helper, string src, string alt, string width, string height)
        {
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", src);
            tag.Attributes.Add("alt", alt);
            tag.Attributes.Add("width", width);
            tag.Attributes.Add("height", height);
            return new MvcHtmlString(tag.ToString());
        }

    }
}