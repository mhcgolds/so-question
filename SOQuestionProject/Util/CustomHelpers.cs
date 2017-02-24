using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    public static class CustomHelpers
    {
        public static MvcHtmlString CustomCheckBoxFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return new MvcHtmlString(String.Format("{0}{1}",
                                     html.CheckBoxFor(expression),
                                     html.DisplayNameFor(expression)));
        }

        public static MvcHtmlString CustomCheckBoxFor2<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, bool>> expression)
        {
            return new MvcHtmlString(String.Format("{0}{1}",
                                     html.CheckBoxFor(expression),
                                     html.DisplayNameFor(expression)));
        }
    }
}