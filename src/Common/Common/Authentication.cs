using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Graph.Common
{
    public static class Authentication
    {
        public static HttpClient GetGraphHttpClient()
        {
            return GraphClientFactory.Create(GetAuthProvider());
        }

        private static IAuthenticationProvider GetAuthProvider()
        {
            string appId = null;
            string scopes = null;

            if (string.IsNullOrEmpty(appId))
            {
                Console.WriteLine("Enter App ID:");
                appId = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(scopes))
            {
                Console.WriteLine("Enter Scopes:");
                scopes = Console.ReadLine();
            }

            IPublicClientApplication clientApp = PublicClientApplicationBuilder
                .Create(appId)
                .Build();

            ConfigureTokenCache(clientApp.UserTokenCache);

            return new DeviceCodeProvider(clientApp, scopes.Split(new char[] { ',', ' ' }));
        }

        private static void ConfigureTokenCache(ITokenCache tokenCache)
        {
            tokenCache.SetBeforeAccess((TokenCacheNotificationArgs args) => {
                args.TokenCache.DeserializeMsalV3(GetTokenCache());
            });

            tokenCache.SetAfterAccess((TokenCacheNotificationArgs args) => {
                SetTokenCache(args.TokenCache.SerializeMsalV3());
            });
        }

        public static byte[] GetTokenCache()
        {
            if (System.IO.File.Exists($"./tokencache.bin"))
            {
                return System.IO.File.ReadAllBytes($"./tokencache.bin");
            }
            else
            {
                return new byte[0];
            }
        }

        public static void SetTokenCache(byte[] tokenCache)
        {
            System.IO.File.WriteAllBytes($"./tokencache.bin", tokenCache);
        }
    }
}
