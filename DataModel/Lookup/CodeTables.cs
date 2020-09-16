using System;
using DataModel.CodeTables;

namespace DataModel.Lookup
{
    public class CodeTables
    {

        public static readonly Status[] Statuses =
        {
            new Status()
            {
                Id = Guid.Parse("fd988731-d699-40d1-a860-5619f331727e"), ParentStatusId = null, Code = "A",
                SortOrder = 0, IsActive = true, DescEng = "Active", DescFre = "Actifs"
            },
            new Status()
            {
                Id = Guid.Parse("904d49f7-227e-4650-aba0-47b25d54c41b"),
                ParentStatusId = Guid.Parse("fd988731-d699-40d1-a860-5619f331727e"), Code = "O", SortOrder = 0,
                IsActive = true, DescEng = "Ongoing monitoring/assessment required to determine way forward",
                DescFre = "Un suivi et une évaluation continus sont nécessaires pour déterminer la voie à suivre."
            },
            new Status()
            {
                Id = Guid.Parse("f75ef970-7785-446f-a125-b52c0f71ef85"),
                ParentStatusId = Guid.Parse("fd988731-d699-40d1-a860-5619f331727e"), Code = "TA", SortOrder = 0,
                IsActive = true, DescEng = "Technical assessment/remediation in progress",
                DescFre = "Évaluation technique/assainissement en cours"
            },
            new Status()
            {
                Id = Guid.Parse("b91082f4-21d0-4640-82e4-143ab566ec3f"), ParentStatusId = null, Code = "OTH",
                SortOrder = 0, IsActive = true, DescEng = "Other", DescFre = "Autre"
            }
        };

    }
}