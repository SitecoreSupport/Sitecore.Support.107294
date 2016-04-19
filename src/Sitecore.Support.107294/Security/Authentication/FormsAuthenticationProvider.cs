using Sitecore.Diagnostics;
using System.Collections.Specialized;

namespace Sitecore.Support.Security.Authentication
{
  class FormsAuthenticationProvider : Sitecore.Security.Authentication.FormsAuthenticationProvider
  {
    private FormsAuthenticationHelper helper;

    public override void Initialize(string name, NameValueCollection config)
    {
      base.Initialize(name, config);
      this.helper = new FormsAuthenticationHelper(this);
    }

    public override string GetAuthenticationData(string key)
    {
      Assert.ArgumentNotNull(key, "key");
      return this.helper.GetAuthenticationData(key);
    }

    public override void SetAuthenticationData(string key, string authenticationData)
    {
      Assert.ArgumentNotNull(key, "key");
      Assert.ArgumentNotNull(authenticationData, "authenticationData");
      this.helper.SetAuthenticationData(key, authenticationData);
    }
  }
}