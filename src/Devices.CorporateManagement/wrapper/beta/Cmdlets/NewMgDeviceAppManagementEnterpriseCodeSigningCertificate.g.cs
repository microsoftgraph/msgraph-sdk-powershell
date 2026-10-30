#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/enterpriseCodeSigningCertificates")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementEnterpriseCodeSigningCertificate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.EnterpriseCodeSigningCertificate))]
    public class NewMgDeviceAppManagementEnterpriseCodeSigningCertificateCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Issuer { get; set; }

        [Parameter(Mandatory = false)]
        public string? IssuerName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubjectName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? UploadDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.CertificateStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.EnterpriseCodeSigningCertificate();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(Issuer)))
        body.Issuer = Issuer;

    if (this.IsParameterBound(nameof(IssuerName)))
        body.IssuerName = IssuerName;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(SubjectName)))
        body.SubjectName = SubjectName;

    if (this.IsParameterBound(nameof(UploadDateTime)))
        body.UploadDateTime = UploadDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.EnterpriseCodeSigningCertificate? result;
            try
            {
                result = client.DeviceAppManagement.EnterpriseCodeSigningCertificates.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
