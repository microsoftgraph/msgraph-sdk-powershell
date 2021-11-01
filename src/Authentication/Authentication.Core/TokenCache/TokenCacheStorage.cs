// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.PowerShell.Authentication.Core;
using System;
using System.Globalization;
using System.Security;

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    /// <summary>
    /// Helper class to handle token encryption and decryption.
    /// </summary>
    internal static class TokenCacheStorage
    {
        /// <summary>
        /// Gets a decrypted access token from the host platform OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <returns></returns>
        public static byte[] GetToken(IAuthContext authContext)
        {
            if (string.IsNullOrEmpty(authContext.ClientId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(authContext.ClientId)));
            }

            if (authContext.ContextScope == ContextScope.Process)
            {
                return GraphSession.Instance.MSALToken;
            }
            else
            {
                if (Helpers.OperatingSystem.IsWindows())
                {
                    return WindowsTokenCache.GetToken(authContext.ClientId);
                }
                else if (Helpers.OperatingSystem.IsMacOS())
                {
                    return MacTokenCache.GetToken(authContext.ClientId);
                }
                else
                {
                    return LinuxTokenCache.GetToken(authContext.ClientId);
                }
            }
        }

        /// <summary>
        /// Encrypts and saves an access token buffer to the host platform OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <param name="accessToken">An access token.</param>
        public static void SetToken(IAuthContext authContext, byte[] accessToken)
        {
            if (string.IsNullOrEmpty(authContext.ClientId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(authContext.ClientId)));
            }
            if (accessToken == null || accessToken.Length == 0)
            {
                return ;
            }

            if (authContext.ContextScope == ContextScope.Process)
            {
                GraphSession.Instance.MSALToken = accessToken;
            }
            else if (authContext.ContextScope == ContextScope.CurrentUser)
            {
                if (Helpers.OperatingSystem.IsWindows())
                {
                    WindowsTokenCache.SetToken(authContext.ClientId, accessToken);
                }
                else if (Helpers.OperatingSystem.IsMacOS())
                {
                    MacTokenCache.SetToken(authContext.ClientId, accessToken);
                }
                else
                {
                    LinuxTokenCache.SetToken(authContext.ClientId, accessToken);
                }
            }
        }

        /// <summary>
        /// Deletes an access token from the host OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        public static void DeleteToken(IAuthContext authContext)
        {
            if (string.IsNullOrEmpty(authContext.ClientId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(authContext.ClientId)));
            }

            if (authContext.ContextScope == ContextScope.Process)
            {
                GraphSession.Instance.MSALToken = null;
            }
            else
            {
                if (Helpers.OperatingSystem.IsWindows())
                {
                    WindowsTokenCache.DeleteToken(authContext.ClientId);
                }
                else if (Helpers.OperatingSystem.IsMacOS())
                {
                    MacTokenCache.DeleteToken(authContext.ClientId);
                }
                else
                {
                    LinuxTokenCache.DeleteToken(authContext.ClientId);
                }
            }
        }
    }
}
