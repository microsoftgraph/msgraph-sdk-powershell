// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    using System;
    using System.Management.Automation;
    using System.Linq;
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.IO;

    /// <summary>
    /// Methods for working with Microsoft Graph profiles.
    /// </summary>
    internal static class GraphProfile
    {
        public static string[] GetProfiles(CommandInvocationIntrinsics invokeCommand, bool listAvailable = false, params string[] moduleNames)
        {
            return GetModules(invokeCommand, listAvailable, moduleNames).SelectMany(GetProfiles).Distinct().ToArray();
        }

        public static PSModuleInfo[] GetModules(CommandInvocationIntrinsics invokeCommand, bool listAvailable = false, params string[] moduleNames)
        {
            string nameParameter = $" -Name { (moduleNames != null && moduleNames.Any() ? GetCommaSeparatedQuotedList(moduleNames) : "Microsoft.Graph*" )}";
            string listAvailableParameter = listAvailable ? " -ListAvailable" : String.Empty;
            string command = $"Get-Module{nameParameter}{listAvailableParameter}";
            Collection<PSObject> modules = listAvailable ? PowerShell.Create().AddScript(command).Invoke<PSObject>() : invokeCommand.NewScriptBlock(command).Invoke();
            return modules != null ? modules.Select(m => m?.BaseObject as PSModuleInfo).Where(m => m != null).ToArray() : new PSModuleInfo[] { };
        }

        public static string[] GetProfiles(PSModuleInfo moduleInfo)
        {
            var moduleProfileInfo = (moduleInfo?.PrivateData as Hashtable)?["Profiles"];
            var moduleProfiles = moduleProfileInfo as object[] ?? (moduleProfileInfo != null ? new[] { moduleProfileInfo } : null);
            return moduleProfiles != null && moduleProfiles.Any() ? moduleProfiles.Cast<string>().ToArray() : new string[] { };
        }

        public static void ReloadModules(CommandInvocationIntrinsics invokeCommand, params PSModuleInfo[] moduleInfos)
        {
            var modulePaths = GetCommaSeparatedQuotedList(moduleInfos.Select(GetModulePath).ToArray());
            if (!String.IsNullOrEmpty(modulePaths))
            {
                var command = $"Import-Module -Name {modulePaths} -Force";
                invokeCommand.NewScriptBlock(command).Invoke();
            }
        }

        private static string GetCommaSeparatedQuotedList(params string[] items)
        {
            return string.Join(", ", items.Where(i => !string.IsNullOrEmpty(i)).Select(i => $"'{i}'"));
        }

        private static string GetModulePath(PSModuleInfo moduleInfo)
        {
            var scriptPsd1 = Path.Combine(moduleInfo.ModuleBase, $"{moduleInfo.Name}.psd1");
            return moduleInfo.ModuleType == ModuleType.Script && File.Exists(scriptPsd1) ? scriptPsd1 : moduleInfo.Path;
        }
    }
}
