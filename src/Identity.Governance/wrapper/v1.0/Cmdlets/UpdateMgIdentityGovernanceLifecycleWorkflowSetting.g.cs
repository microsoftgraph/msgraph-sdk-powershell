#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/identityGovernance/lifecycleWorkflows/settings")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceLifecycleWorkflowSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecycleManagementSettings))]
    public class UpdateMgIdentityGovernanceLifecycleWorkflowSettingCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? WorkflowScheduleIntervalInHours { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.EmailSettings? EmailSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.QuarantineConfiguration? QuarantineConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecycleManagementSettings();

    if (this.IsParameterBound(nameof(WorkflowScheduleIntervalInHours)))
        body.WorkflowScheduleIntervalInHours = WorkflowScheduleIntervalInHours;

    if (this.IsParameterBound(nameof(EmailSettings)))
        body.EmailSettings = EmailSettings;

    if (this.IsParameterBound(nameof(QuarantineConfiguration)))
        body.QuarantineConfiguration = QuarantineConfiguration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecycleManagementSettings? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Settings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.LifecycleWorkflows.Settings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
