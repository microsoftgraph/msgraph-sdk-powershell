// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.Auth;
    using Microsoft.Graph.PowerShell.Authentication.Core;
    using Microsoft.Identity.Client;
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IdentityModel.Tokens.Jwt;

    /// <summary>
    /// A JwtHelpers class.
    /// </summary>
    internal static class JwtHelpers
    {
        /// <summary>
        /// Decodes a JWT token and store claims in the provided <see cref="IAuthContext"/> by ref.
        /// </summary>
        /// <param name="jwToken">A JWT string.</param>
        /// <param name="account">MSAL's <see cref="IAccount"/>.</param>
        /// <param name="authContext">An <see cref="IAuthContext"/> to store JWT claims in.</param>
        internal static void DecodeJWT(string jwToken, IAccount account, ref IAuthContext authContext)
        {
            var jwtPayload = JwtHelpers.DecodeToObject<Models.JwtPayload>(jwToken);
            if (authContext.AuthType == AuthenticationType.UserProvidedAccessToken)
            {
                if (jwtPayload == null)
                {
                    throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.InvalidUserProvidedToken,
                            "AccessToken"));
                }

                if (jwtPayload.Exp <= JwtHelpers.ConvertToUnixTimestamp(DateTime.UtcNow + TimeSpan.FromMinutes(Constants.TokenExpirationBufferInMinutes)))
                {
                    throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.ExpiredUserProvidedToken,
                            "AccessToken"));
                }
            }

            authContext.ClientId = jwtPayload?.Appid ?? authContext.ClientId;
            authContext.Scopes = jwtPayload?.Scp?.Split(' ') ?? jwtPayload?.Roles;
            authContext.TenantId = jwtPayload?.Tid ?? account?.HomeAccountId?.TenantId;
            authContext.AppName = jwtPayload?.AppDisplayname;
            authContext.Account = jwtPayload?.Upn ?? account?.Username;
        }

        /// <summary>
        /// Decodes a JWT token by extracting claims from the payload.
        /// </summary>
        /// <param name="jwToken">A JWT string.</param>
        internal static string Decode(string jwToken)
        {
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();
            if (jwtHandler.CanReadToken(jwToken))
            {
                JwtSecurityToken token = jwtHandler.ReadJwtToken(jwToken);
                return token.Payload.SerializeToJson();
            } else {
                return null;
            }
        }

        /// <summary>
        /// Decodes a JWT token by extracting claims from the payload to an object of type T.
        /// </summary>
        /// <typeparam name="T">An object with properties of the JWT payload.</typeparam>
        /// <param name="jwToken">A JWT string.</param>
        internal static T DecodeToObject<T>(string jwtString)
        {
            try
            {
                string decodedJWT = Decode(jwtString);
                if (decodedJWT == null)
                    return default(T);
                return JsonConvert.DeserializeObject<T>(decodedJWT);
            }
            catch (Exception ex)
            {
                throw new AuthenticationException(
                        new Error
                        {
                            Code = ErrorConstants.Codes.InvalidJWT,
                            Message = ErrorConstants.Message.InvalidJWT
                        }, ex);
            }
        }

        /// <summary>
        /// Converts a DateTime to Unix timestamp in seconds past epoch.
        /// </summary>
        /// <param name="time">A <see cref="DateTime"/> to convert.</param>
        /// <returns>Unix timestamp.</returns>
        internal static long ConvertToUnixTimestamp(DateTime time)
        {
            DateTime epochTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan timeDiff = time - epochTime;
            return (long)timeDiff.TotalSeconds;
        }
    }
}