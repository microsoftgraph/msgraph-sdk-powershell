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
    [GraphRoute("PATCH", "/education/classes/{educationClass-id}/modules/{educationModule-id}/resources/{educationModuleResource-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationClassModuleResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationModuleResource))]
    public class UpdateMgEducationClassModuleResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationModuleId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EducationModuleResourceId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationResource? Resource { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationModuleResourceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationModuleResource();


    if (this.IsParameterBound(nameof(Resource)))
        body.Resource = Resource;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationModuleResource? result;
            try
            {
                result = client.Education.Classes[EducationClassId].Modules[EducationModuleId].Resources[EducationModuleResourceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EducationModuleResourceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Classes[EducationClassId].Modules[EducationModuleId].Resources[EducationModuleResourceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, EducationModuleResourceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
