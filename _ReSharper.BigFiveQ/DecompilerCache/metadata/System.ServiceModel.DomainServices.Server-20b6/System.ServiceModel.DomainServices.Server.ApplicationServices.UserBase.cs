// Type: System.ServiceModel.DomainServices.Server.ApplicationServices.UserBase
// Assembly: System.ServiceModel.DomainServices.Server, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Microsoft SDKs\RIA Services\v1.0\Libraries\Server\System.ServiceModel.DomainServices.Server.dll

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.ServiceModel.DomainServices.Server;

namespace System.ServiceModel.DomainServices.Server.ApplicationServices
{
    public abstract class UserBase : IUser, IPrincipal, IIdentity
    {
        #region IIdentity Members

        [ProfileUsage(IsExcluded = true)]
        [Exclude]
        public bool IsAuthenticated { get; }

        string IIdentity.AuthenticationType { get; }

        #endregion

        #region IPrincipal Members

        public bool IsInRole(string role);
        IIdentity IPrincipal.Identity { get; }

        #endregion

        #region IUser Members

        [ProfileUsage(IsExcluded = true)]
        [Key]
        public string Name { get; set; }

        [Editable(false)]
        [ProfileUsage(IsExcluded = true)]
        public IEnumerable<string> Roles { get; set; }

        #endregion
    }
}
