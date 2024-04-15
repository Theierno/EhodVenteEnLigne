using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EhodVenteEnLigne.Resources.Models
{
    [CompilerGenerated()]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    public class LoginError
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager temp = new ResourceManager("EhodVenteEnLigne.Resources.Models.LoginError", typeof(LoginError).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture
        {
            get { return resourceCulture; }
            set { resourceCulture = value; }
        }

        public static string ErrorMissingName
        {
            get { return ResourceManager.GetString("ErrorMissingName", resourceCulture); }
        }

        public static string ErrorMissingPassword
        {
            get { return ResourceManager.GetString("ErrorMissingPassword", resourceCulture); }
        }

    }

}