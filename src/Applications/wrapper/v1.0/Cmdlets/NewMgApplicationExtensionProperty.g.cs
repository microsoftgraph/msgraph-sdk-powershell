#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/applications/{application-id}/extensionProperties")]
    [Cmdlet(VerbsCommon.New, "MgApplicationExtensionProperty", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.ExtensionProperty))]
    public class NewMgApplicationExtensionPropertyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DataType { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMultiValued { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSyncedFromOnPremises { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? TargetObjects { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.ExtensionProperty();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AppDisplayName)))
        body.AppDisplayName = AppDisplayName;

    if (this.IsParameterBound(nameof(DataType)))
        body.DataType = DataType;

    if (this.IsParameterBound(nameof(IsMultiValued)))
        body.IsMultiValued = IsMultiValued;

    if (this.IsParameterBound(nameof(IsSyncedFromOnPremises)))
        body.IsSyncedFromOnPremises = IsSyncedFromOnPremises;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(TargetObjects)))
        body.TargetObjects = TargetObjects!.ToList();



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.ExtensionProperty? result;
            try
            {
                result = client.Applications[ApplicationId].ExtensionProperties.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
