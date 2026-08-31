#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("POST", "/education/classes/{educationClass-id}/modules/{educationModule-id}/publish")]
    [Cmdlet(VerbsData.Publish, "MgEducationClassModule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationModule))]
    public class PublishMgEducationClassModuleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationModuleId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationModuleId, "Publish"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationModule? result;
            try
            {
                result = client.Education.Classes[EducationClassId].Modules[EducationModuleId].Publish.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EducationModuleId);
                return;
            }

            WriteObject(result);
        }
    }
}
