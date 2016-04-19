using Sitecore.Security.Authentication;
using Sitecore.Diagnostics;
using Sitecore.Configuration;

namespace Sitecore.Support.Security.Authentication
{
  class FormsAuthenticationHelper : Sitecore.Security.Authentication.FormsAuthenticationHelper
  {
    public FormsAuthenticationHelper(AuthenticationProvider provider) : base(provider)
    {
    }

    public override string GetAuthenticationData(string key)
    {
      Assert.ArgumentNotNull(key, "key");
      return (ClientContext.GetValue(key) as string);
    }

    public override void SetAuthenticationData(string key, string authenticationData)
    {
      Assert.ArgumentNotNull(key, "key");
      Assert.ArgumentNotNull(authenticationData, "authenticationData");
      ClientContext.SetValue(key, authenticationData);
    }
  }
}