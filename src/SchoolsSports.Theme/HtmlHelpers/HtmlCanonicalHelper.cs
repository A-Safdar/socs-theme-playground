using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Primitives;

namespace SchoolsSports.Theme.HtmlHelpers;

public static class HtmlCanonicalHelper
{
    public static IHtmlContent CanonicalUrl(this IHtmlHelper html)
    {
        var rawUrl = html.ViewContext.HttpContext.Request;
        var currentPage = rawUrl.Query.ContainsKey("currentPage") ? rawUrl.Query["currentPage"][0].To<int>() : (int?)null;

        if (currentPage is not null && currentPage != 0)
        {
            return null;
        }

        var canonicalTag = new TagBuilder("link");
        canonicalTag.Attributes.Add("rel", "canonical");

        var canonicalUrl = $"https://{rawUrl.Host}{rawUrl.Path}";
        canonicalTag.Attributes.Add("href", canonicalUrl);

        return canonicalTag;
    }
}