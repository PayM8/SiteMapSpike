using MvcSiteMapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteMapSpike.Extensions
{
    public class NodeVisibilityProvider : SiteMapNodeVisibilityProviderBase
    {
        public override bool IsVisible(ISiteMapNode node, IDictionary<string, object> sourceMetadata)
        {
            if (!node.Attributes.ContainsKey("visibility"))
            {
                return true;
            }

            if (!sourceMetadata.ContainsKey("HtmlHelper"))
            {
                return true;
            }

            var source = sourceMetadata["HtmlHelper"].ToString();
            string visibility = node.Attributes["visibility"].ToString();
            visibility = visibility.Trim();

            switch (source)
            {
                case "MvcSiteMapProvider.Web.Html.MenuHelper":
                    return visibility.Contains("SiteMapHelper");
                case "MvcSiteMapProvider.Web.Html.SiteMapPathHelper":
                    return visibility.Contains("SiteMapPathHelper");
                default:
                    return true;
            }


        }
    }
}