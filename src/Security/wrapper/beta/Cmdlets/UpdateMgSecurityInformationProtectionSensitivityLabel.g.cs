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
    [GraphRoute("PATCH", "/security/informationProtection/sensitivityLabels/{sensitivityLabel-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityInformationProtectionSensitivityLabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensitivityLabel))]
    public class UpdateMgSecurityInformationProtectionSensitivityLabelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SensitivityLabelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Color { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ContentFormats { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasProtection { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsActive { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAppliable { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public int? Sensitivity { get; set; }

        [Parameter(Mandatory = false)]
        public string? Tooltip { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SensitivityLabelId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensitivityLabel();

    if (this.IsParameterBound(nameof(Color)))
        body.Color = Color;

    if (this.IsParameterBound(nameof(ContentFormats)))
        body.ContentFormats = ContentFormats!.ToList();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(HasProtection)))
        body.HasProtection = HasProtection;

    if (this.IsParameterBound(nameof(IsActive)))
        body.IsActive = IsActive;

    if (this.IsParameterBound(nameof(IsAppliable)))
        body.IsAppliable = IsAppliable;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Sensitivity)))
        body.Sensitivity = Sensitivity;

    if (this.IsParameterBound(nameof(Tooltip)))
        body.Tooltip = Tooltip;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensitivityLabel? result;
            try
            {
                result = client.Security.InformationProtection.SensitivityLabels[SensitivityLabelId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SensitivityLabelId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.InformationProtection.SensitivityLabels[SensitivityLabelId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SensitivityLabelId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
