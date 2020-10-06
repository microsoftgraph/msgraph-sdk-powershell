// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    public class GraphContextSettings
    {
        public IDictionary<string, IGraphEnvironment> EnvironmentTable { get; set; } = new ConcurrentDictionary<string, IGraphEnvironment>(StringComparer.CurrentCultureIgnoreCase);

        public GraphContextSettings()
        {
            EnvironmentTable = new ConcurrentDictionary<string, IGraphEnvironment>(StringComparer.CurrentCultureIgnoreCase);
            Load(Constants.ContextSettingFilePath);
        }

        private void Load(string path)
        {
            // Creates directory if it doesn't exists.
            Directory.CreateDirectory(path);

            if (File.Exists(path))
            {
                string contents = File.ReadAllText(path);
                if (SafeDeserializeObject(contents, out GraphContextSettings contextSettings))
                {
                    Initialize(contextSettings);
                }
            }
            else
            {
                Initialize();
            }
        }

        private void Initialize(GraphContextSettings settings = null)
        {
            EnvironmentTable.Clear();
            // Add predefined environments.
            foreach (var env in GraphEnvironment.GraphEnvironments)
            {
                EnvironmentTable[env.Key] = env.Value;
            }

            if (settings != null)
            {
                foreach (var environment in settings.EnvironmentTable)
                {
                    EnvironmentTable[environment.Key] = environment.Value;
                }
            }
        }

        private bool SafeDeserializeObject<T>(string serialization, out T result, JsonConverter converter = null)
        {
            result = default(T);
            bool success = false;
            try
            {
                result = converter == null ? JsonConvert.DeserializeObject<T>(serialization) : JsonConvert.DeserializeObject<T>(serialization, converter);
                success = true;
            }
            catch (JsonException)
            {

            }

            return success;
        }

        internal bool TryGetEnvironment(string name, out IGraphEnvironment environment)
        {
            bool result = false;
            environment = null;
            if (EnvironmentTable.ContainsKey(name))
            {
                environment = EnvironmentTable[name];
                result = true;
            }

            return result;
        }
    }
}
