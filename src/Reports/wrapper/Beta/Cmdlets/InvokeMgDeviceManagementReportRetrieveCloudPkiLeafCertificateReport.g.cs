#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("POST", "/deviceManagement/reports/retrieveCloudPkiLeafCertificateReport")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementReportRetrieveCloudPkiLeafCertificateReport", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(byte[]))]
    public class InvokeMgDeviceManagementReportRetrieveCloudPkiLeafCertificateReportCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? CertificationAuthorityId { get; set; }

        [Parameter(Mandatory = false)]
        public int? Top { get; set; }

        [Parameter(Mandatory = false)]
        public int? Skip { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Select { get; set; }

        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? OrderBy { get; set; }






        [Parameter(Mandatory = false,
            HelpMessage = "Writes the response content to this path instead of returning it as bytes.")]
        public string? OutFile { get; set; }


        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Reports.Client.DeviceManagement.Reports.RetrieveCloudPkiLeafCertificateReport.RetrieveCloudPkiLeafCertificateReportPostRequestBody();

    if (this.IsParameterBound(nameof(CertificationAuthorityId)))
        body.CertificationAuthorityId = CertificationAuthorityId;

    if (this.IsParameterBound(nameof(Top)))
        body.Top = Top;

    if (this.IsParameterBound(nameof(Skip)))
        body.Skip = Skip;

    if (this.IsParameterBound(nameof(Select)))
        body.Select = Select!.ToList();

    if (this.IsParameterBound(nameof(Filter)))
        body.Filter = Filter;

    if (this.IsParameterBound(nameof(Search)))
        body.Search = Search;

    if (this.IsParameterBound(nameof(OrderBy)))
        body.OrderBy = OrderBy!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            System.IO.Stream? result;
            try
            {
                result = client.DeviceManagement.Reports.RetrieveCloudPkiLeafCertificateReport.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
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
