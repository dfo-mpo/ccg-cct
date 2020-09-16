using System;
using System.Linq;
using CCG.AspNetCore.Data.Auth.Model;

namespace DataModel.Lookup
{
    public static class Auth
    {

        public static readonly SystemRole[] SystemRoles = {
            new SystemRole() { Id = Guid.Parse("3bdce629-ffa6-4973-9be1-e7c3ba6d7cf4"), Code = "User", DescEng = "User", DescFre = "Utilisateur", IsActive = true},
            new SystemRole() { Id = Guid.Parse("4717fc67-e3cb-4d1c-b3d1-72ec3b5ad655"), Code = "Admin", DescEng = "Administrator", DescFre = "Administrateur", IsActive = true}
        };

        public static readonly Privilege[] Privileges = {
            new Privilege() { Id = Guid.Parse("AFE32F00-B6A6-4CAA-B452-30E1240E34C0"), Code = "Auth_User_View", DescEng = "View users", DescFre = "Afficher les utilisateurs", IsActive = true},
            new Privilege() { Id = Guid.Parse("3A76DDE2-B837-450C-A6B3-EDA358720BBD"), Code = "Auth_User_Manage", DescEng = "Manage users", DescFre = "Gérer les utilisateurs", IsActive = true},
            new Privilege() { Id = Guid.Parse("C3E4261F-66D9-4A22-B589-3CDD5C17C12D"), Code = "Auth_Assign_View", DescEng = "View role privileges", DescFre = "Afficher les privilèges de rôle", IsActive = true },
            new Privilege() { Id = Guid.Parse("B78ECF44-75B6-4058-B9FE-C4AE4A5B1BAA"), Code = "Auth_Assign_Manage", DescEng = "Manage role privileges", DescFre = "Gérer les privilèges de rôles", IsActive = true },
            new Privilege() { Id = Guid.Parse("664FEB76-8BCF-445A-A70D-8A31EA9C9954"), Code = "Auth_Role_View", DescEng = "View roles", DescFre = "Afficher les rôles", IsActive = true },
            new Privilege() { Id = Guid.Parse("CFEA2A8F-40FD-4B8E-B7C2-062CF42745C6"), Code = "Auth_Role_Manage", DescEng = "Manage roles", DescFre = "Gérer les rôles", IsActive = true },
            new Privilege() { Id = Guid.Parse("3BF1919A-C5D5-46AA-BA99-70DD1F73D8D4"), Code = "Auth_Privilege_View", DescEng = "View Privileges", DescFre = "Afficher les privilèges", IsActive = true },
            new Privilege() { Id = Guid.Parse("6D823333-1C28-4BA5-8544-E0004D1BD272"), Code = "Code_View", DescEng = "View Code Tables", DescFre = "Afficher les tableaux de codes", IsActive = true },
            new Privilege() { Id = Guid.Parse("6FCC0103-8DC0-49FD-B22B-62DE9CAC461D"), Code = "Voc_Intake", DescEng = "Create a file", DescFre = "Créer un dossier", IsActive = true },
            new Privilege() { Id = Guid.Parse("FF51E03A-1ACF-4600-8C0A-65F73CAED103"), Code = "Voc_View", DescEng = "View files", DescFre = "Afficher les dossier", IsActive = true },
            new Privilege() { Id = Guid.Parse("2E3F1ADB-78BA-4E13-84DB-C703F71D09DB"), Code = "Voc_Edit", DescEng = "Edit file", DescFre = "Modifier le dossier", IsActive = true },
            new Privilege() { Id = Guid.Parse("05CABE94-D27E-44FF-A2DF-3A085F73100B"), Code = "Voc_Delete", DescEng = "Delete files", DescFre = "Supprimer les dossiers", IsActive = true },
            new Privilege() { Id = Guid.Parse("6a16b3db-52ed-4882-ad14-298a2c98dc94"), Code = "Report_View", DescEng = "View reports", DescFre = "Afficher les rapports", IsActive = true }
        };

        private static Guid GuestSystemRoleId =>
            CCG.AspNetCore.Data.Auth.Lookup.SystemRoles.Single(e => e.Code == "Guest").Id;

        public static readonly SystemRolePrivilege[] SystemRolePrivileges = {            
            new SystemRolePrivilege { Id = Guid.Parse("3EBF58B3-578E-4FC6-98EC-B5E7FF907D33"), SystemRoleId = GuestSystemRoleId, PrivilegeId = Privileges.Single(e => e.Code == "Auth_User_View").Id},
            new SystemRolePrivilege { Id = Guid.Parse("2BE4F8E5-1845-4B9A-BE05-F67A40300A3F"), SystemRoleId = GuestSystemRoleId, PrivilegeId = Privileges.Single(e => e.Code == "Auth_User_Manage").Id},
            new SystemRolePrivilege { Id = Guid.Parse("36F15AB8-12D3-4728-946F-E06BD70EA635"), SystemRoleId = GuestSystemRoleId, PrivilegeId = Privileges.Single(e => e.Code == "Auth_Assign_View").Id},
            new SystemRolePrivilege { Id = Guid.Parse("17DDAA13-4C28-422A-B32C-2B599641A876"), SystemRoleId = GuestSystemRoleId, PrivilegeId = Privileges.Single(e => e.Code == "Auth_Assign_Manage").Id},
            new SystemRolePrivilege { Id = Guid.Parse("6875DB1C-D2C7-4D69-AD99-B21C6A996EE0"), SystemRoleId = GuestSystemRoleId, PrivilegeId = Privileges.Single(e => e.Code == "Auth_Role_View").Id},
            new SystemRolePrivilege { Id = Guid.Parse("6CD0AE01-5E08-456E-98D7-FA694752AB7A"), SystemRoleId = GuestSystemRoleId, PrivilegeId = Privileges.Single(e => e.Code == "Auth_Role_Manage").Id},
            new SystemRolePrivilege { Id = Guid.Parse("DAEE098C-58E8-4473-B363-6E547319D40F"), SystemRoleId = GuestSystemRoleId, PrivilegeId = Privileges.Single(e => e.Code == "Auth_Privilege_View").Id}
        };
    }
}