#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groupSettingTemplates/getByIds")]
    [Cmdlet(VerbsCommon.Get, "MgGroupSettingTemplateById", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Groups.Client.GroupSettingTemplates.GetByIds.GetByIdsPostResponse))]
    public class GetMgGroupSettingTemplateByIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? Ids { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Types { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.GroupSettingTemplates.GetByIds.GetByIdsPostRequestBody();

    if (this.IsParameterBound(nameof(Ids)))
        body.Ids = Ids!.ToList();

    if (this.IsParameterBound(nameof(Types)))
        body.Types = Types!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Groups.Client.GroupSettingTemplates.GetByIds.GetByIdsPostResponse? result;
            try
            {
                result = client.GroupSettingTemplates.GetByIds.PostAsGetByIdsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
