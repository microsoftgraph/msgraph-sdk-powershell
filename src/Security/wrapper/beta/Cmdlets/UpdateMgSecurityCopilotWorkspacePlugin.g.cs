#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/securityCopilot/workspaces/{workspace-id}/plugins/{plugin-name}")]
    [Cmdlet(VerbsData.Update, "MgSecurityCopilotWorkspacePlugin", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Plugin))]
    public class UpdateMgSecurityCopilotWorkspacePluginCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkspaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PluginName { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.PluginAuth? Authorization { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.PluginCatalogScope? CatalogScope { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.PluginCategory? Category { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.PluginPreviewStates? PreviewState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.PluginSetting[]? Settings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.PluginAuthTypes? SupportedAuthTypes { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PluginName, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Plugin();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Authorization)))
        body.Authorization = Authorization;

    if (this.IsParameterBound(nameof(CatalogScope)))
        body.CatalogScope = CatalogScope;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(PreviewState)))
        body.PreviewState = PreviewState;

    if (this.IsParameterBound(nameof(Settings)))
        body.Settings = Settings!.ToList();

    if (this.IsParameterBound(nameof(SupportedAuthTypes)))
        body.SupportedAuthTypes = SupportedAuthTypes;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Plugin? result;
            try
            {
                result = client.Security.SecurityCopilot.Workspaces[WorkspaceId].Plugins[PluginName].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PluginName);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.SecurityCopilot.Workspaces[WorkspaceId].Plugins[PluginName].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PluginName);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
