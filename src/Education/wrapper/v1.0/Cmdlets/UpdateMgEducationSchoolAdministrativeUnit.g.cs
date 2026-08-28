#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("PATCH", "/education/schools/{educationSchool-id}/administrativeUnit")]
    [Cmdlet(VerbsData.Update, "MgEducationSchoolAdministrativeUnit", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.AdministrativeUnit))]
    public class UpdateMgEducationSchoolAdministrativeUnitCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationSchoolId { get; set; } = string.Empty;

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
            if (!ShouldProcess(EducationSchoolId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.AdministrativeUnit();

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

            Microsoft.Graph.PowerShell.Education.Client.Models.AdministrativeUnit? result;
            try
            {
                result = client.Education.Schools[EducationSchoolId].AdministrativeUnit.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EducationSchoolId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Schools[EducationSchoolId].AdministrativeUnit.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, EducationSchoolId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
