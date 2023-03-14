﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core.Models;
using Microsoft.Graph.PowerShell.Authentication.Models;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Text;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
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
            var jwtPayload = DecodeToObject<JwtPayload>(jwToken);
            if (authContext.AuthType == AuthenticationType.UserProvidedAccessToken)
            {
                if (jwtPayload == null)
                {
                    throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.InvalidUserProvidedToken,
                            "AccessToken"));
                }

                if (jwtPayload.Exp <= ConvertToUnixTimestamp(DateTime.UtcNow + TimeSpan.FromMinutes(Constants.TokenExpirationBufferInMinutes)))
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
        /// Decodes a JWT token by extracting claims from the payload to an object of type T.
        /// </summary>
        /// <typeparam name="T">An object with properties of the JWT payload.</typeparam>
        /// <param name="jwToken">A JWT string.</param>
        internal static T DecodeToObject<T>(string jwtString)
        {
            try
            {
                var decodedJWT = DecodeJWT(jwtString);
                if (string.IsNullOrWhiteSpace(decodedJWT?.Payload))
                    return default;
                return JsonConvert.DeserializeObject<T>(decodedJWT.Payload);
            }
            catch (Exception ex)
            {
                throw new AuthenticationException(ErrorConstants.Message.InvalidJWT, ex);
            }
        }

        internal static JwtContent DecodeJWT(string jwtString)
        {
            // See https://tools.ietf.org/html/rfc7519
            if (string.IsNullOrWhiteSpace(jwtString) || !jwtString.Contains(".") || !jwtString.StartsWith("eyJ"))
                throw new ArgumentException("Invalid JSON Web Token (JWT).");

            var jwtSegments = jwtString.Split('.');

            if (jwtSegments.Length <= 1)
                throw new ArgumentException("Invalid JWT. JWT does not have a payload.");

            // Header
            var jwtHeader = DecodeJwtSegment(jwtSegments[0]);

            // Payload
            var jwtPayload = DecodeJwtSegment(jwtSegments[1]);

            return new JwtContent { Header = jwtHeader, Payload = jwtPayload };
        }

        private static string DecodeJwtSegment(string jwtSegment)
        {
            jwtSegment = jwtSegment.Replace('-', '+').Replace('_', '/');
            // Fixes padding by adding '=' until header length modulus 4 equals 0.
            while ((jwtSegment.Length % 4) != 0)
                jwtSegment += "=";

            var jwtTokenBytes = Convert.FromBase64String(jwtSegment);
            var jwtSegmentInJson = Encoding.UTF8.GetString(jwtTokenBytes);
            return jwtSegmentInJson;
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