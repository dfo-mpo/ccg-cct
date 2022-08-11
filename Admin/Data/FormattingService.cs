using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace Admin.Data
{
    public class FormattingService
    {

        /*
         * Note, the code related to the filters is pretty much identical to the one found in the site.js file in the All Position Details section,
         * and it features a good explanation of what the filters do and how they work
         */

        public string Filters { get; set; }

        private List<string[]> _filtersArray;

        private const string AND_SEPARATOR = "&";
        private const string OR_SEPARATOR = "|";
        private const string NOT_SYMBOL = "!";

        public void PrepareFiltersArray()
        {
            Filters = RemoveMultipleWhiteSpace(Filters).ToLowerInvariant();
            string[] splitANDFilter = Filters.Split(AND_SEPARATOR);
            _filtersArray = new List<string[]>();

            for (int i = 0; i < splitANDFilter.Length; i++)
            {
                string currentFilter = splitANDFilter[i];
                string[] splitORFilter = currentFilter.Split(OR_SEPARATOR);
                for (int j = 0; j < splitORFilter.Length; j++)
                {
                    splitORFilter[j] = splitORFilter[j].Trim();
                }
                splitORFilter = splitORFilter.Where(x => x != NOT_SYMBOL && x != "").ToArray();
                _filtersArray.Add(splitORFilter);
            }
            _filtersArray = _filtersArray.Where(x => x.Length > 0).ToList();
            if (!_filtersArray.Any())
            {
                _filtersArray = null;
            }
        }

        public string RemoveMultipleWhiteSpace(string str)
        {
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            return str.Trim();
        }

        public string[] FormatCertificateDescriptionLink(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                string[] res = { "", "" };
                return res;
            }
            try
            {
                var trimmedLink = link.Trim();
                bool correctMarkdown = false;
                string pattern = "---\\S.+\\S---$";

                if (Regex.Match(trimmedLink, pattern).Success)
                {
                    correctMarkdown = true;
                }

                string href = "", displayStr = "";

                if (correctMarkdown)
                {
                    href = trimmedLink.Substring(trimmedLink.IndexOf("http"), (trimmedLink.IndexOf("---") - trimmedLink.IndexOf("http")));
                    displayStr = trimmedLink.Substring(trimmedLink.IndexOf("---") + 3, (trimmedLink.LastIndexOf("---") - trimmedLink.IndexOf("---") - 3));
                }
                else
                {
                    href = trimmedLink;
                    displayStr = trimmedLink;
                }

                string[] results = { href.Trim(), displayStr.Trim() };
                return results;
            }
            catch 
            {
                string[] res = { link.Trim(), link.Trim() };
                return res;
            }
        }

        public bool RowContentsMatchFilters(string[] rowContents)
        {
            if (_filtersArray == null)
            {
                return true;
            }

            for (int i = 0; i < rowContents.Length; i++)
            {
                rowContents[i] = rowContents[i].ToLowerInvariant();
            }

            for (int j = 0; j < _filtersArray.Count(); j++)
            {
                bool currentFilterArrayMatches = false;

                for (int i = 0; i < _filtersArray.ElementAt(j).Length; i++)
                {
                    string subFilter = _filtersArray.ElementAt(j)[i];
                    bool foundThisSubFilter = false;
                    bool filterIsANot = false;

                    if (subFilter[0].ToString() == NOT_SYMBOL)
                    {
                        filterIsANot = true;
                        subFilter = subFilter[1..];
                    }

                    for (int k = 0; k < rowContents.Length && !foundThisSubFilter; k++)
                    {
                        string text = rowContents[k];
                        if (text.Contains(subFilter))
                        {
                            foundThisSubFilter = true;
                        }
                    }
                    if ((foundThisSubFilter && !filterIsANot) || (!foundThisSubFilter && filterIsANot))
                    {
                        currentFilterArrayMatches = true;
                    }
                }

                if (!currentFilterArrayMatches)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
