// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Utilities.Runtime.Cmdlets
{
    using Microsoft.Graph.PowerShell.Authentication.Utilities.Runtime;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;

    [Cmdlet(VerbsCommon.Get, "ScriptCmdlet")]
    [OutputType(typeof(string[]))]
    [DoNotExport]
    public class GetScriptCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ScriptFolder { get; set; }

        [Parameter]
        public SwitchParameter IncludeDoNotExport { get; set; }

        [Parameter]
        public SwitchParameter AsAlias { get; set; }

        [Parameter]
        public SwitchParameter AsFunctionInfo { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var functionInfos = GetScriptCmdlets(ScriptFolder)
                    .Where(fi => IncludeDoNotExport || !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
                    .ToArray();
                if (AsFunctionInfo)
                {
                    WriteObject(functionInfos, true);
                    return;
                }

                string[] output = null;
                if (AsAlias)
                {
                    var aliases = functionInfos.SelectMany(i => i.ScriptBlock.Attributes)
                        .OfType<AliasAttribute>()
                        .SelectMany(a => a.AliasNames)
                        .Distinct();

                    output = aliases.DefaultIfEmpty("''").ToArray();
                }
                else
                {
                    var names = functionInfos.Select(fi => fi.Name).Distinct();
                    output = names.DefaultIfEmpty("''").ToArray();
                }

                WriteObject(output, true);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine($"${ex.GetType().Name}/{ex.StackTrace}");
                throw ex;
            }
        }

        private IEnumerable<FunctionInfo> GetScriptCmdlets(string scriptFolder)
        {
            // https://stackoverflow.com/a/40969712/294804
            var getCmdletsCommand = $@"
                $currentFunctions = Get-ChildItem function:
                Get-ChildItem -Path '{scriptFolder}' -Recurse -Include '*.ps1' -File | ForEach-Object {{ . $_.FullName }}
                Get-ChildItem function: | Where-Object {{ ($currentFunctions -notcontains $_) -and $_.CmdletBinding }}
                ";
            return this.RunScript<FunctionInfo>(getCmdletsCommand);
        }
    }
}
