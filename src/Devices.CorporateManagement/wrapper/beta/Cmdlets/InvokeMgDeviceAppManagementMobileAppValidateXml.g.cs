#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/mobileApps/validateXml")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementMobileAppValidateXml", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.MobileApps.ValidateXml.ValidateXmlPostResponse))]
    public class InvokeMgDeviceAppManagementMobileAppValidateXmlCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public byte[]? OfficeConfigurationXml { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.MobileApps.ValidateXml.ValidateXmlPostRequestBody();

    if (this.IsParameterBound(nameof(OfficeConfigurationXml)))
        body.OfficeConfigurationXml = OfficeConfigurationXml;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.MobileApps.ValidateXml.ValidateXmlPostResponse? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps.ValidateXml.PostAsValidateXmlPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
