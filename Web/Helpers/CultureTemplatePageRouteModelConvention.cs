using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Resources;

namespace Web.Helpers
{
    public class FrenchRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return values.ContainsKey("culture") && values["culture"].ToString() == "fr";
        }
    }

    public class CultureTemplatePageRouteModelConvention : IPageRouteModelConvention
    {

        private readonly ResourceManager _pageTranslations = Web.Resources.PageNames.ResourceManager;

        public void Apply(PageRouteModel model)
        {
            var selectorCount = model.Selectors.Count;

            for (var i = 0; i < selectorCount; i++)
            {
                var selector = model.Selectors[i];

                var frenchModel = new SelectorModel
                {
                    AttributeRouteModel = new AttributeRouteModel
                    {
                        Order = -1,
                        //culture:french will validate the culture against the FrenchRouteConstraint
                        Template = AttributeRouteModel.CombineTemplates("{culture:french}", GetTranslation(selector.AttributeRouteModel.Template)),
                    }
                };
                var englishModel = new SelectorModel
                {
                    AttributeRouteModel = new AttributeRouteModel
                    {
                        Order = -1,
                        Template = AttributeRouteModel.CombineTemplates("{culture}", selector.AttributeRouteModel.Template),
                    }
                };
                model.Selectors.Add(frenchModel);
                model.Selectors.Add(englishModel);
            }
        }

        private string GetTranslation(string template)
        {
            var templateSections = template.Split('/');
            var translatedSections = new List<string>();
            foreach (var section in templateSections)
            {
                translatedSections.Add(GetResource(section));
            }
            return string.Join("/", translatedSections);
        }

        private string GetResource(string section)
 {
            return _pageTranslations.GetString(section) ?? section;
        }

    }
}