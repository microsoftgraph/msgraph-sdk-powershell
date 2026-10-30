#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/directory/administrativeUnits/{administrativeUnit-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryAdministrativeUnit", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AdministrativeUnit))]
    public class UpdateMgDirectoryAdministrativeUnitCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AdministrativeUnitId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMemberManagementRestricted { get; set; }

        [Parameter(Mandatory = false)]
        public string? MembershipRule { get; set; }

        [Parameter(Mandatory = false)]
        public string? MembershipRuleProcessingState { get; set; }

        [Parameter(Mandatory = false)]
        public string? MembershipType { get; set; }

        [Parameter(Mandatory = false)]
        public string? Visibility { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AdministrativeUnitId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AdministrativeUnit();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsMemberManagementRestricted)))
        body.IsMemberManagementRestricted = IsMemberManagementRestricted;

    if (this.IsParameterBound(nameof(MembershipRule)))
        body.MembershipRule = MembershipRule;

    if (this.IsParameterBound(nameof(MembershipRuleProcessingState)))
        body.MembershipRuleProcessingState = MembershipRuleProcessingState;

    if (this.IsParameterBound(nameof(MembershipType)))
        body.MembershipType = MembershipType;

    if (this.IsParameterBound(nameof(Visibility)))
        body.Visibility = Visibility;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AdministrativeUnit? result;
            try
            {
                result = client.Directory.AdministrativeUnits[AdministrativeUnitId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AdministrativeUnitId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.AdministrativeUnits[AdministrativeUnitId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AdministrativeUnitId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
