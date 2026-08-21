#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("PATCH", "/users/{user-id}/licenseDetails/{licenseDetails-id}")]
    [Cmdlet(VerbsData.Update, "MgUserLicenseDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.LicenseDetails))]
    public class UpdateMgUserLicenseDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string LicenseDetailsId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? SkuId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuPartNumber { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.ServicePlanInfo[]? ServicePlans { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(LicenseDetailsId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.LicenseDetails();

    if (this.IsParameterBound(nameof(SkuId)))
        body.SkuId = SkuId;

    if (this.IsParameterBound(nameof(SkuPartNumber)))
        body.SkuPartNumber = SkuPartNumber;

    if (this.IsParameterBound(nameof(ServicePlans)))
        body.ServicePlans = ServicePlans!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.LicenseDetails? result;
            try
            {
                result = client.Users[UserId].LicenseDetails[LicenseDetailsId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, LicenseDetailsId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].LicenseDetails[LicenseDetailsId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, LicenseDetailsId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
