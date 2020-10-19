// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    using Microsoft.Graph.PowerShell.Authentication.Interfaces;

    public static class GraphSessionInitializer
    {
        /// <summary>
        /// Initializes <see cref="GraphSession"/>.
        /// </summary>
        public static void InitializeSession()
        {
            GraphSession.Initialize(() => CreateInstance());
        }

        /// <summary>
        /// Creates a new instance of a <see cref="GraphSession"/>.
        /// </summary>
        /// <returns><see cref="GraphSession"/></returns>
        internal static GraphSession CreateInstance(IDataStore dataStore = null)
        {
            return new GraphSession
            {
                DataStore = dataStore ?? new DiskDataStore()
            };
        }
    }
}
