using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Collections.Generic;
using System.Resources;

namespace Web.Helpers
{
    public class CultureTemplatePageRouteModelConvention : IPageRouteModelConvention
    {

        private readonly ResourceManager _pageTranslations = Web.Resources.PageNames.ResourceManager;

        public void Apply(PageRouteModel model)
        {
            var selectorCount = model.Selectors.Count;

            for (var i = 0; i < selectorCount; i++)
            {
                var selector = model.Selectors[i];

                model.Selectors.Add(new SelectorModel
                {
                    AttributeRouteModel = new AttributeRouteModel
                    {
                        Order = -1,
                        Template = AttributeRouteModel.CombineTemplates("{culture?}", GetTranslation(selector.AttributeRouteModel.Template)),
                    }
                });
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