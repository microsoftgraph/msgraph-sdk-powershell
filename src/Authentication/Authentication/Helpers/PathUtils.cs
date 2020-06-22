using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Text;
using Microsoft.Graph.PowerShell.Authentication.Cmdlets;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    /// Defines generic utilities and helper methods for PowerShell.
    /// </summary>
    internal static class PathUtils
    {
        public static string ResolveFilePath(string filePath, InvokeGraphRequest command, bool isLiteralPath)
        {
            string path = null;
            try
            {
                var filePaths = new List<string>();
                if (isLiteralPath)
                {
                    filePaths.Add(command.SessionState.Path.GetUnresolvedProviderPathFromPSPath(filePath, out _, out _));
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