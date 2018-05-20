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
        public string ErrorMessage { get; private set; } = "";
        public string Context { get; private set; } = "";
        public string FullName { get; private set; } = "";
        public string FirstName { get; private set; } = "";
        public string EmployeeId { get; private set; } = "";
        public DateTime PasswordLastChangedDate { get; private set; }
        public DateTime PasswordExpirationDate { get; private set; }
        public bool PasswordRequired { get; private set; } = false;
        public bool PasswordNeverExpires { get; private set; } = false;
        public bool AllowedToChangePassword { get; private set; } = false;
        public bool UpdateSuccessful { get; private set; } = false;

        public void Update()
        {
            UpdateSuccessful = false;

            if (Domain != "" && UserName != "")
            {

                try
                {
                    PrincipalContext currentContext;

                    if (this.Domain != Environment.MachineName)
                    {
                        currentContext = new PrincipalContext(ContextType.Domain);
                        this.Context = "Domain/Active Directory";
                    }
                    else
                    {
                        currentContext = new PrincipalContext(ContextType.Machine);
                        this.Context = "Machine";
                    }

                    UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(currentContext, UserName);
                    FullName = userPrincipal.DisplayName;
                    FirstName = userPrincipal.GivenName;
                    PasswordNeverExpires = userPrincipal.PasswordNeverExpires;
                    AllowedToChangePassword = !userPrincipal.UserCannotChangePassword;
                    EmployeeId = userPrincipal.EmployeeId;
                    PasswordLastChangedDate = (DateTime) userPrincipal.LastPasswordSet;
                    PasswordRequired = !userPrincipal.PasswordNotRequired;

                    DirectoryEntry directoryEntry = (DirectoryEntry) userPrincipal.GetUnderlyingObject();
                    IADsUser nativeUser = (IADsUser) directoryEntry.NativeObject;

                    PasswordExpirationDate = nativeUser.PasswordExpirationDate;

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

        public override string ToString()
        {
            StringBuilder returnStringBuilder = new StringBuilder();

            returnStringBuilder.AppendFormat("AllowedToChangePassword: {0}", AllowedToChangePassword);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("Context: {0}", Context);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("EmployeeId: {0}", EmployeeId);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("FirstName: {0}", FirstName);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("FullName: {0}", FullName);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("PasswordExpirationDate: {0}", PasswordExpirationDate);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("PasswordLastChangedDate: {0}", PasswordLastChangedDate);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("PasswordNeverExpires: {0}", PasswordNeverExpires);
            returnStringBuilder.AppendLine();
            returnStringBuilder.AppendFormat("PasswordRequired: {0}", PasswordRequired);
            returnStringBuilder.AppendLine();

            return returnStringBuilder.ToString();
        }
    }
}
