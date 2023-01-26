// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Cmdlets.Custom
{
    using Microsoft.Graph.PowerShell.Authentication.Common;
    using System.IO;
    using System.Management.Automation;

    public partial class FileUploadCmdlet : PSCmdlet
    {
        /// <summary>Backing field for <see cref="InFile" /> property.</summary>
        private string _inFile;

        /// <summary>The path to the file to upload. This SHOULD include the file name and extension.</summary>
        [Parameter(Mandatory = true, HelpMessage = "The path to the file to upload. This should include a path and file name. If you omit the path, the current location will be used.")]
        [Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The path to the file to upload. This should include a path and file name. If you omit the path, the current location will be used.",
        PossibleTypes = new[] { typeof(string) })]
        [ValidateNotNullOrEmpty()]
        [Category(ParameterCategory.Runtime)]
        public string InFile { get => this._inFile; set => this._inFile = value; }

        /// <summary>
        /// Creates a file stream from the provided input file.
        /// </summary>
        /// <returns>A file stream.</returns>
        internal Stream GetFileAsStream()
        {
            if (MyInvocation.BoundParameters.ContainsKey(nameof(InFile)))
            {
                string resolvedFilePath = this.GetProviderPath(InFile, true);
                var fileProvider = ProtectedFileProvider.CreateFileProvider(resolvedFilePath, FileProtection.SharedRead, new DiskDataStore());
                return fileProvider.Stream;
            }
            else
            {
                return null;
            }
        }
    }
}
