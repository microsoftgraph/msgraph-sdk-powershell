// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using Microsoft.Graph.PowerShell.Authentication.Common;
    using Microsoft.Graph.PowerShell.Authentication.Extensions;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    /// <summary>
    /// Represents a Microsoft Graph settings structure with environments.
    /// </summary>
    [Serializable]
    internal class GraphSettings
    {
        public IDictionary<string, IGraphEnvironment> EnvironmentTable { get; set; } = new ConcurrentDictionary<string, IGraphEnvironment>(StringComparer.CurrentCultureIgnoreCase);

        [JsonIgnore]
        [XmlIgnore]
        public IEnumerable<IGraphEnvironment> Environments
        {
            get
            {
                return EnvironmentTable.Values.ToList();
            }
        }

        /// <summary>
        /// Creates a new instance of <see cref="GraphSettings"/>.
        /// </summary>
        public GraphSettings()
        {
            EnvironmentTable = new ConcurrentDictionary<string, IGraphEnvironment>(StringComparer.CurrentCultureIgnoreCase);

            foreach (var env in GraphEnvironment.BuiltInEnvironments)
            {
                EnvironmentTable[env.Key] = env.Value;
            }
        }

        /// <summary>
        /// Creates a new instance of <see cref="GraphSettings"/> using <see cref="IFileProvider"/>.
        /// </summary>
        /// <param name="fileProvider">The file provider that allows access to settings contents.</param>
        public GraphSettings(IFileProvider fileProvider)
        {
            Load(fileProvider);
        }

        /// <summary>
        /// Reads settings from disk using the specified <see cref="IFileProvider"/>.
        /// </summary>
        /// <param name="fileProvider">The file provider that allows access to settings contents.</param>
        private void Load(IFileProvider fileProvider)
        {
            using (fileProvider)
            {
                string contents = fileProvider.CreateReader().ReadToEnd();
                if (TryDeserializeObject<GraphSettings>(contents, out GraphSettings contextSettings, new GraphSettingsConverter()))
                {
                    Initialize(contextSettings);
                }
                else
                {
                    Initialize();
                }
            }
        }

        /// <summary>
        /// Initializes <see cref="GraphSettings"/> from an existing settings if any.
        /// </summary>
        /// <param name="settings">An optional <see cref="GraphSettings"/>.</param>
        private void Initialize(GraphSettings settings = null)
        {
            EnvironmentTable.Clear();
            // Add built-in environments.
            foreach (var env in GraphEnvironment.BuiltInEnvironments)
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

        /// <summary>
        /// Writes settings to the disk.
        /// </summary>
        public void Save()
        {
            Save(Constants.SettingFilePath);
        }

        /// <summary>
        /// Writes settings to the specified file path.
        /// </summary>
        /// <param name="path">A file path on disk to save settings to.</param>
        public void Save(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                using (var provider = ProtectedFileProvider.CreateFileProvider(path, FileProtection.ExclusiveWrite))
                {
                    Save(provider);
                }
            }
        }

        public void Save(IFileProvider provider)
        {
            // Remove built-in environments.
            foreach (string env in GraphEnvironment.BuiltInEnvironments.Keys)
            {
                EnvironmentTable.Remove(env);
            }

            try
            {
                string contents = ToString();
                string diskContents = string.Empty;
                diskContents = provider.CreateReader().ReadToEnd();

                if (diskContents != contents)
                {
                    var writer = provider.CreateWriter();
                    writer.Write(contents);
                    writer.Flush();

                    // When writing to a stream, ensure that the file is truncated
                    // so that previous data is overwritten
                    provider.Stream.SetLength(provider.Stream.Position);
                }
            }
            finally
            {
                // Add back built-in environments.
                foreach (GraphEnvironment env in GraphEnvironment.BuiltInEnvironments.Values)
                {
                    EnvironmentTable[env.Name] = env;
                }
            }
        }

        /// <summary>
        /// Safely deserializes JSON string to an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serialization">A string to deserialize.</param>
        /// <param name="result">An object with deserialized content.</param>
        /// <param name="converter">A <see cref="JsonConverter"/> to use to deserialize JSON content.</param>
        /// <returns>True is successful, otherwise false.</returns>
        internal bool TryDeserializeObject<T>(string serialization, out T result, JsonConverter converter = null)
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

        /// <summary>
        /// Gets a list of <see cref="IGraphEnvironment"/>.
        /// </summary>
        /// <param name="name">The name of the environment to remove.</param>
        /// <returns>A list of <see cref="IGraphEnvironment"/></returns>
        public List<IGraphEnvironment> ListEnvironments(string name)
        {
            var result = new List<IGraphEnvironment>();
            IGraphEnvironment environment;
            if (string.IsNullOrWhiteSpace(name))
            {
                result.AddRange(Environments);
            }
            else if (TryGetEnvironment(name, out environment))
            {
                result.Add(environment);
            }

            result.Sort((e1, e2) => {
                return e1.Type.CompareTo(e2.Type);
            });

            return result;
        }

        /// <summary>
        /// Removes a Microsoft Graph environment to the settings file.
        /// </summary>
        /// <param name="name">The name of the environment to remove.</param>
        /// <returns>The removed <see cref="IGraphEnvironment"/> object.</returns>
        public IGraphEnvironment RemoveEnvironment(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Environment name deeds to be specified.");
            }
            if (GraphEnvironment.BuiltInEnvironments.ContainsKey(name))
            {
                throw new ArgumentException(
                    ErrorConstants.Message.CannotModifyBuiltInEnvironment.FormatCurrentCulture("remove", name),
                    nameof(name));
            }

            IGraphEnvironment environment;
            if (TryRemoveEnvironment(name, out environment))
            {
                return environment;
            }
            else
            {
                throw new ArgumentException(string.Format("Environment {0} not found.", name), nameof(name));
            }
        }

        /// <summary>
        /// Sets a Microsoft Graph environment to the settings file.
        /// This saves the environment to disk.
        /// </summary>
        /// <param name="environment">An <see cref="IGraphEnvironment"/> object to set.</param>
        /// <param name="mergedEnvironment">An updated <see cref="IGraphEnvironment"/> object with merged changes.</param>
        /// <returns>True is successful, otherwise false.</returns>
        public bool TrySetEnvironment(IGraphEnvironment environment, out IGraphEnvironment mergedEnvironment)
        {
            bool result = false;
            mergedEnvironment = environment;
            if (environment != null && !GraphEnvironment.BuiltInEnvironments.ContainsKey(environment.Name))
            {
                if (EnvironmentTable.ContainsKey(environment.Name))
                {
                    mergedEnvironment = mergedEnvironment.Merge(EnvironmentTable[environment.Name]);
                }

                EnvironmentTable[environment.Name] = mergedEnvironment;

                // Persist changes to disk.
                Save();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Gets a Microsoft Graph environment to the settings file.
        /// </summary>
        /// <param name="name">The name of the environment to get.</param>
        /// <param name="environment">The retrieved <see cref="IGraphEnvironment"/> object.</param>
        /// <returns>True is successful, otherwise false.</returns>
        public bool TryGetEnvironment(string name, out IGraphEnvironment environment)
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

        /// <summary>
        /// Removes a Microsoft Graph environment to the settings file.
        /// </summary>
        /// <param name="name">The name of the environment to remove.</param>
        /// <param name="environment">The removed <see cref="IGraphEnvironment"/> object.</param>
        /// <returns>True is successful, otherwise false.</returns>
        public bool TryRemoveEnvironment(string name, out IGraphEnvironment environment)
        {
            bool result = false;
            if (TryGetEnvironment(name, out environment))
            {
                result = EnvironmentTable.Remove(name);
                // Persist changes to disk.
                Save();
            }

            return result;
        }

        /// <summary>
        /// Serializes <see cref="GraphEnvironment"/> to JSON.
        /// </summary>
        /// <returns>A JSON string.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new GraphSettingsConverter());
        }

    }
}
