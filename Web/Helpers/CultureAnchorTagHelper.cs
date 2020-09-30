using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Helpers
{
    [HtmlTargetElement("a", Attributes = ActionAttributeName)]
    [HtmlTargetElement("a", Attributes = ControllerAttributeName)]
    [HtmlTargetElement("a", Attributes = AreaAttributeName)]
    [HtmlTargetElement("a", Attributes = PageAttributeName)]
    [HtmlTargetElement("a", Attributes = PageHandlerAttributeName)]
    [HtmlTargetElement("a", Attributes = FragmentAttributeName)]
    [HtmlTargetElement("a", Attributes = HostAttributeName)]
    [HtmlTargetElement("a", Attributes = ProtocolAttributeName)]
    [HtmlTargetElement("a", Attributes = RouteAttributeName)]
    [HtmlTargetElement("a", Attributes = RouteValuesDictionaryName)]
    [HtmlTargetElement("a", Attributes = RouteValuesPrefix + "*")]
    public class CultureAnchorTagHelper : AnchorTagHelper
    {
        public CultureAnchorTagHelper(IHttpContextAccessor contextAccessor, IHtmlGenerator generator) :
            base(generator)
        {
            this.contextAccessor = contextAccessor;
        }

        private const string ActionAttributeName = "asp-action";
        private const string ControllerAttributeName = "asp-controller";
        private const string AreaAttributeName = "asp-area";
        private const string PageAttributeName = "asp-page";
        private const string PageHandlerAttributeName = "asp-page-handler";
        private const string FragmentAttributeName = "asp-fragment";
        private const string HostAttributeName = "asp-host";
        private const string ProtocolAttributeName = "asp-protocol";
        private const string RouteAttributeName = "asp-route";
        private const string RouteValuesDictionaryName = "asp-all-route-data";
        private const string RouteValuesPrefix = "asp-route-";
        private const string Href = "href";

        private readonly IHttpContextAccessor contextAccessor;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //RouteValues["culture"] = (string)context.AllAttributes.Where(e => e.Name == nameof(RouteCultureAttributeName)).FirstOrDefault()?.Value;
            if ( !RouteValues.ContainsKey("culture"))
            {
                RouteValues["culture"] = (string)contextAccessor.HttpContext.Request.RouteValues["culture"] ?? Startup.DefaultRequestCulture.Culture.TwoLetterISOLanguageName;
            }

            base.Process(context, output);
        }
    }
}
