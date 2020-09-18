// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Graph.PowerShell.Authentication.Cmdlets;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    ///     Defines generic utilities and helper methods for PowerShell.
    /// </summary>
    internal static class PathUtils
    {
        public static string ResolveFilePath(string filePath, InvokeMgGraphRequest command, bool isLiteralPath)
        {
            string path = null;
            try
            {
                var filePaths = new List<string>();
                if (isLiteralPath)
                {
                    filePaths.Add(
                        command.SessionState.Path.GetUnresolvedProviderPathFromPSPath(filePath, out _, out _));
                }
                else
                {
                    filePaths.AddRange(command.SessionState.Path.GetResolvedProviderPathFromPSPath(filePath, out _));
                }

                path = filePaths[0];
            }
            catch (ItemNotFoundException)
            {
                path = null;
            }

            return path;
        }
    }
}