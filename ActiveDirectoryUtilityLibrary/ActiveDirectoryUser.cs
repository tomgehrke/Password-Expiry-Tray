using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveDs;

namespace ActiveDirectoryUtilityLibrary
{
    public class ActiveDirectoryUser
    {
        public string UserName { get; set; } = "";
        public string Domain { get; set; } = "";
        public string ErrorMessage { get; private set; }
        public string Context { get; private set; }
        public DateTime PasswordLastChangedDate { get; private set; }
        public DateTime PasswordExpirationDate { get; private set; }
        public bool NonExpiringPassword { get; private set; }
        public bool UpdateSuccessful { get; private set; }

        public void Update()
        {
            UpdateSuccessful = false;

            if (Domain != "" && UserName != "")
            {

                try
                {
                    PrincipalContext domain;

                    if (this.Domain != Environment.MachineName)
                    {
                        domain = new PrincipalContext(ContextType.Domain);
                        this.Context = "Domain";
                    }
                    else
                    {
                        domain = new PrincipalContext(ContextType.Machine);
                        this.Context = "Machine";
                    }

                    UserPrincipal user = UserPrincipal.FindByIdentity(domain, UserName);
                    DirectoryEntry entry = (DirectoryEntry)user.GetUnderlyingObject();
                    IADsUser native = (IADsUser)entry.NativeObject;

                    PasswordLastChangedDate = native.PasswordLastChanged;
                    PasswordExpirationDate = native.PasswordExpirationDate;
                    NonExpiringPassword = native.PasswordRequired;
                }
                catch (Exception ex)
                {
                    this.ErrorMessage = ex.Message;
                }

                //DirectoryEntry LdapEntry = new DirectoryEntry($"LDAP://{Domain}");
                //    DirectorySearcher LdapSearcher = new DirectorySearcher();
                //    SearchResult searchResult;

                //    LdapSearcher.SearchRoot = LdapEntry;
                //    LdapSearcher.Filter = $"(&(sAMAccountName={UserName}))";
                //    LdapSearcher.SearchScope = SearchScope.Subtree;
                //    LdapSearcher.PropertiesToLoad.Add("pwdLastSet");
                //    LdapSearcher.PropertiesToLoad.Add("userAccountControl");

                //    try
                //    {
                //        searchResult = LdapSearcher.FindOne();

                //        if (searchResult != null && ErrorMessage == "")
                //        {

                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        ErrorMessage = $"ADUser: {ex.Message}";
                //    }

                //}
            }
        }
    }
}
