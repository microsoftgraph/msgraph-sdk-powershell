// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    using System.Management.Automation;

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
        /// <summary>
        /// Initializes <see cref="GraphSession"/>. with Output via Cmdlet methods
        /// </summary>
        /// <param name="cmdLet"></param>
        public static void InitializeSession(PSCmdlet cmdLet)
        {
            GraphSession.Initialize(() =>
            {
                var instance = CreateInstance();
                instance.Output = new Output
                {
                    WriteDebug = cmdLet.WriteDebug,
                    WriteInformation = cmdLet.WriteInformation,
                    WriteObject = cmdLet.WriteObject,
                    WriteVerbose = cmdLet.WriteVerbose,
                    WriteError = (exception, errorId, errorCategory, targetObject) =>
                    {
                        var parseResult = Enum.TryParse(errorCategory.ToString(), out ErrorCategory result);
                        if (!parseResult)
                        {
                            result = ErrorCategory.NotSpecified;
                        }
                        var errorRecord = new ErrorRecord(exception, errorId, result, targetObject);
                        cmdLet.WriteError(errorRecord);
                    }
                };
                return instance;
            });
        }
    }
}
