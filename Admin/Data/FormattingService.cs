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

    }
}
