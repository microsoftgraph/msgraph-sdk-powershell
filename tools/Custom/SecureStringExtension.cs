using System;
using System.Security;
namespace NamespacePrefixPlaceholder.PowerShell.Models
{
    public class SecureStringExtension
    {
        public static string ConvertToSecureStringToPlainText(SecureString secureString)
        {
            IntPtr unmanagedString = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(secureString);
            try
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}