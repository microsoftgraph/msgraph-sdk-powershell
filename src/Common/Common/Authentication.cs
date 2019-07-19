using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;

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
            if (appId is null)
            {
                Console.WriteLine("Enter App ID:");
                appId = Console.ReadLine();
            }

            string scopes = null;
            if (scopes is null)
            {
                Console.WriteLine("Enter Scopes:");
                scopes = Console.ReadLine();
            }

            IPublicClientApplication clientApp = PublicClientApplicationBuilder
                .Create(appId)
                .Build();

            return new DeviceCodeProvider(clientApp, scopes.Split(new char[] { ',', ' ' }));
        }
    }
}
