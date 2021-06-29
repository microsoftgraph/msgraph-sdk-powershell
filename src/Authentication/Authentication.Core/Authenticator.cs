// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.Authentication.Core
{
    using Microsoft.Graph.Auth;
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Core;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Microsoft.Identity.Client;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Authenticator class for handling sign-ins and sign-outs.
    /// </summary>
    public static class Authenticator
    {
        /// <summary>
        /// Authenticates the client using the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to authenticate.</param>
        /// <param name="forceRefresh">Whether or not to force refresh a token if one exists.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <param name="fallBackWarning">Callback to report FallBack to DeviceCode Authentication</param>
        /// <returns></returns>
        public static async Task<IAuthContext> AuthenticateAsync(IAuthContext authContext, bool forceRefresh, CancellationToken cancellationToken, Action fallBackWarning = null)
        {
            // Gets a static instance of IAuthenticationProvider when the client app hasn't changed.
            var authProvider = AuthenticationHelpers.GetAuthProvider(authContext);
            IClientApplicationBase clientApplication = null;
            switch (authContext.AuthProviderType)
            {
                case AuthProviderType.DeviceCodeProvider:
                case AuthProviderType.DeviceCodeProviderFallBack:
                    clientApplication = (authProvider as DeviceCodeProvider).ClientApplication;
                    break;
                case AuthProviderType.InteractiveAuthenticationProvider:
                    {
                        var interactiveProvider = (authProvider as InteractiveAuthenticationProvider).ClientApplication;
                        //When User is not Interactive, Pre-Emptively Fallback and warn, to DeviceCode
                        if (!interactiveProvider.IsUserInteractive())
                        {
                            authContext.AuthProviderType = AuthProviderType.DeviceCodeProviderFallBack;
                            fallBackWarning?.Invoke();
                            var fallBackAuthContext = await AuthenticateAsync(authContext, forceRefresh, cancellationToken, fallBackWarning);
                            return fallBackAuthContext;
                        }
                        break;
                    }
                case AuthProviderType.ClientCredentialProvider:
                    {
                        clientApplication = (authProvider as ClientCredentialProvider).ClientApplication;
                        break;
                    }
            }
            try
            {
                // Incremental scope consent without re-instantiating the auth provider. We will use provided instance.
                GraphRequestContext graphRequestContext = new GraphRequestContext();
                graphRequestContext.CancellationToken = cancellationToken;
                graphRequestContext.MiddlewareOptions = new Dictionary<string, IMiddlewareOption>
                {
                    {
                        typeof(AuthenticationHandlerOption).ToString(),
                        new AuthenticationHandlerOption
                        {
                            AuthenticationProviderOption = new AuthenticationProviderOption
                            {
                                Scopes = authContext.Scopes,
                                ForceRefresh = forceRefresh
                            }
                        }
                    }
                };

                // Trigger consent.
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/me");
                httpRequestMessage.Properties.Add(typeof(GraphRequestContext).ToString(), graphRequestContext);
                await authProvider.AuthenticateRequestAsync(httpRequestMessage);

                IAccount account = null;
                if (clientApplication != null)
                {
                    // Only get accounts when we are using MSAL to get an access token.
                    IEnumerable<IAccount> accounts = clientApplication.GetAccountsAsync().GetAwaiter().GetResult();
                    account = accounts.FirstOrDefault();
                }

                JwtHelpers.DecodeJWT(httpRequestMessage.Headers.Authorization?.Parameter, account, ref authContext);
                return authContext;
            }
            catch (AuthenticationException authEx)
            {
                //Interactive Authentication Failure: Could Not Open Browser, fallback to DeviceAuth
                if (IsUnableToOpenWebPageError(authEx))
                {
                    authContext.AuthProviderType = AuthProviderType.DeviceCodeProviderFallBack;
                    //ReAuthenticate using DeviceCode as fallback.
                    var fallBackAuthContext = await AuthenticateAsync(authContext, forceRefresh, cancellationToken);
                    //Indicate that this was a Fallback
                    if (fallBackWarning != null && fallBackAuthContext.AuthProviderType == AuthProviderType.DeviceCodeProviderFallBack)
                    {
                        fallBackWarning();
                    }
                    return fallBackAuthContext;
                }

                if (authEx.InnerException is TaskCanceledException && cancellationToken.IsCancellationRequested)
                {
                    // Authentication requets timeout.
                    throw new Exception(string.Format(CultureInfo.CurrentCulture, ErrorConstants.Message.DeviceCodeTimeout, Constants.MaxDeviceCodeTimeOut));
                }
                else if (authEx.InnerException is MsalServiceException msalServiceEx
                      && msalServiceEx.StatusCode == 400
                      && msalServiceEx.ErrorCode == "invalid_scope"
                      && string.IsNullOrWhiteSpace(authContext.TenantId)
                      && (authContext.AuthProviderType == AuthProviderType.DeviceCodeProvider
                      || authContext.AuthProviderType == AuthProviderType.DeviceCodeProviderFallBack))
                {
                    // MSAL scope validation error. Ask customer to specify sign-in audience or tenant Id.
                    throw new MsalClientException(msalServiceEx.ErrorCode, $"{msalServiceEx.Message}.\r\n{ErrorConstants.Message.InvalidScope}", msalServiceEx);
                }

                //Something Unknown Went Wrong
                throw authEx.InnerException ?? authEx;
            }
            catch (Exception ex)
            {
                throw ex.InnerException ?? ex;
            }
        }

        /// <summary>
        /// Signs out of the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to sign-out from.</param>
        public static void LogOut(IAuthContext authContext)
        {
            AuthenticationHelpers.Logout(authContext);
        }

        private static bool IsUnableToOpenWebPageError(Exception exception)
        {
            return exception.InnerException is MsalClientException clientException &&
                   clientException?.ErrorCode == MsalError.LinuxXdgOpen ||
                   (exception.Message?.ToLower()?.Contains("unable to open a web page") ?? false);
        }
    }
}
