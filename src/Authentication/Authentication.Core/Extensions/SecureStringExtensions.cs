// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Extensions
{
    public static class SecureStringExtensions
    {
        public static string ConvertToString(this SecureString secureString)
        {
            if (secureString == null)
                throw new ArgumentNullException(nameof(secureString));

            IntPtr intPtr = IntPtr.Zero;
            try
            {
                intPtr = Marshal.SecureStringToBSTR(secureString);
                return Marshal.PtrToStringBSTR(intPtr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(intPtr);
            }
        }
    }
}
