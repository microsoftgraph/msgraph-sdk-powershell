#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groups/{group-id}/settings")]
    [Cmdlet(VerbsCommon.New, "MgGroupSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.GroupSetting))]
    public class NewMgGroupSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.SettingValue[]? Values { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.GroupSetting();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(TemplateId)))
        body.TemplateId = TemplateId;

    if (this.IsParameterBound(nameof(Values)))
        body.Values = Values!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.GroupSetting? result;
            try
            {
                result = client.Groups[GroupId].Settings.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
