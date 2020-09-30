using System;
using DataModel.CodeTables;

namespace DataModel.Lookup
{
    public class CodeTables
    {

        public static readonly StatusCode[] Statuses =
        {
            new StatusCode()
            {
                Id = Guid.Parse("fd988731-d699-40d1-a860-5619f331727e"), Code = "A",
                SortOrder = 0, IsActive = true, DescEng = "Active", DescFre = "Actifs"
            },
            new StatusCode()
            {
                Id = Guid.Parse("904d49f7-227e-4650-aba0-47b25d54c41b"),
                Code = "O", SortOrder = 0,
                IsActive = true, DescEng = "Ongoing monitoring/assessment required to determine way forward",
                DescFre = "Un suivi et une évaluation continus sont nécessaires pour déterminer la voie à suivre."
            },
            new StatusCode()
            {
                Id = Guid.Parse("f75ef970-7785-446f-a125-b52c0f71ef85"),
                Code = "TA", SortOrder = 0,
                IsActive = true, DescEng = "Technical assessment/remediation in progress",
                DescFre = "Évaluation technique/assainissement en cours"
            },
            new StatusCode()
            {
                Id = Guid.Parse("b91082f4-21d0-4640-82e4-143ab566ec3f"), Code = "OTH",
                SortOrder = 0, IsActive = true, DescEng = "Other", DescFre = "Autre"
            }
        };

    }
}