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
    [GraphRoute("POST", "/users/{user-id}/managedDevices/downloadPowerliftAppDiagnostic")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserManagedDeviceDownloadPowerliftAppDiagnostic", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(byte[]))]
    public class InvokeMgUserManagedDeviceDownloadPowerliftAppDiagnosticCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.PowerliftAppDiagnosticDownloadRequest? Request { get; set; }





        [Parameter(Mandatory = false,
            HelpMessage = "Writes the response content to this path instead of returning it as bytes.")]
        public string? OutFile { get; set; }


        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.ManagedDevices.DownloadPowerliftAppDiagnostic.DownloadPowerliftAppDiagnosticPostRequestBody();

    if (this.IsParameterBound(nameof(Request)))
        body.Request = Request;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            System.IO.Stream? result;
            try
            {
                result = client.Users[UserId].ManagedDevices.DownloadPowerliftAppDiagnostic.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        if (result is not null)
        {
            using (result)
            {
                if (this.IsParameterBound(nameof(OutFile)))
                {
                    using var file = System.IO.File.Create(OutFile!);
                    result.CopyTo(file);
                }
                else
                {
                    using var buffer = new System.IO.MemoryStream();
                    result.CopyTo(buffer);
                    WriteObject(buffer.ToArray());
                }
            }
        }
        }
    }
}
