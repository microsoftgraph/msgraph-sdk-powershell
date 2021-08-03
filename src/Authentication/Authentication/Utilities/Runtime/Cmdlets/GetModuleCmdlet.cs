// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Utilities.Runtime.Cmdlets
{
    using Microsoft.Graph.PowerShell.Authentication.Utilities.Runtime;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;

    [Cmdlet(VerbsCommon.Get, "ModuleCmdlet")]
    [OutputType(typeof(string[]))]
    [DoNotExport]

    public class GetModuleCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ModulePath { get; set; }

        [Parameter]
        public SwitchParameter IncludeDoNotExport { get; set; }

        [Parameter]
        public SwitchParameter AsAlias { get; set; }

        [Parameter]
        public SwitchParameter AsCommandInfo { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var commandInfos = GetModuleCmdlets(ModulePath)
                    .Where(ci => IncludeDoNotExport || !new CommandMetadata(ci).CommandType.GetCustomAttributes(false).OfType<DoNotExportAttribute>().Any())
                    .ToArray();

                if (AsCommandInfo)
                {
                    WriteObject(commandInfos, true);
                    return;
                }

                string[] output = null;
                if (AsAlias)
                {
                    var aliases = commandInfos.Where(ci => ci.CommandType == CommandTypes.Alias)
                        .Select(ci => ci.Name)
                        .Distinct();

                    output = aliases.DefaultIfEmpty("''").ToArray();
                }
                else
                {
                    var names = commandInfos.Where(ci => ci.CommandType == CommandTypes.Cmdlet)
                        .Select(ci => ci.Name).Distinct();

                    output = names.DefaultIfEmpty("''").ToArray();
                }

                WriteObject(output, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"${ex.GetType().Name}/{ex.StackTrace}");
                throw ex;
            }
        }

        private IEnumerable<CommandInfo> GetModuleCmdlets(string modulePath)
        {
            var getCmdletsCommand = $"(Get-Command -Module (Import-Module '{modulePath}' -PassThru))";
            return PSCmdletExtensions.RunScript<CommandInfo>(getCmdletsCommand);
        }
    }
}
