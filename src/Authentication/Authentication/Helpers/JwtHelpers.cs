// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.Auth;
    using Microsoft.IdentityModel.Tokens;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    /// <summary>
    /// A JwtHelpers class.
    /// </summary>
    internal static class JwtHelpers
    {
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
                JwtPayload jwtPayload = new JwtPayload(token.Claims);
                return jwtPayload.SerializeToJson();
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
    }
}