using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Services
{
    public static class AzureAccessTokenService
    {
        public static void AddAccessToken(SqlConnection conn)
        {
            if (conn == null) return;
            if (conn.ConnectionString.Contains(".database.windows.net") && !conn.ConnectionString.Contains("User ID",StringComparison.InvariantCultureIgnoreCase))
            {
                conn.AccessToken = new Microsoft.Azure.Services.AppAuthentication.AzureServiceTokenProvider().GetAccessTokenAsync("https://database.windows.net/").Result;
            }

        }
    }
}
