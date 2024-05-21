// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Management.Automation;
using RequestContext = Microsoft.Graph.PowerShell.Authentication.Models.RequestContext;

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
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
            IGraphOption graphOptions = null;
            // Try to create directory if it doesn't exist.
            try 
            {
                Directory.CreateDirectory(Core.Constants.GraphDirectoryPath);
            }
            catch (Exception)
            {
            }
            if (File.Exists(Constants.GraphOptionsFilePath))
            {
                // Deserialize the JSON into the GraphOption instance
                graphOptions = JsonConvert.DeserializeObject<GraphOption>(File.ReadAllText(Constants.GraphOptionsFilePath));
            }

            return new GraphSession
            {
                DataStore = dataStore ?? new DiskDataStore(),
                RequestContext = new RequestContext(),
                GraphOption = graphOptions ?? new GraphOption(),
                GraphRequestProofofPossession = new GraphRequestProofofPossession()
            };
        }
        /// <summary>
        /// Initializes <see cref="GraphSession"/>. with Output via Cmdlet methods
        /// </summary>
        /// <param name="cmdLet"></param>
        internal static void InitializeOutput(CustomAsyncCommandRuntime cmdLet)
        {
            var outputWriter = new PsGraphOutputWriter
            {
                WriteDebug = cmdLet.WriteDebug,
                WriteInformation = (o, strings) =>
                {
                    cmdLet.WriteInformation(new InformationRecord(o, strings));
                },
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
            InitializeOutput(outputWriter);
        }
        /// <summary>
        /// Initializes <see cref="GraphSession"/>. with Output via Cmdlet methods
        /// </summary>
        /// <param name="outputWriter"></param>
        internal static void InitializeOutput(IPSGraphOutputWriter outputWriter)
        {
            GraphSession.Modify(session =>
            {
                session.OutputWriter = outputWriter;
            });
        }
    }
}
