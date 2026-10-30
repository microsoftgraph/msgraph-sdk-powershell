#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/auditLog/queries")]
    [Cmdlet(VerbsCommon.New, "MgSecurityAuditLogQuery", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQuery))]
    public class NewMgSecurityAuditLogQueryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? AdministrativeUnitIdFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FilterEndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FilterStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? IpAddressFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string? KeywordFilter { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ObjectIdFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? OperationFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ServiceFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? UserPrincipalNameFilters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogRecordType?[]? RecordTypeFilters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQueryStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQuery();

    if (this.IsParameterBound(nameof(AdministrativeUnitIdFilters)))
        body.AdministrativeUnitIdFilters = AdministrativeUnitIdFilters!.ToList();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FilterEndDateTime)))
        body.FilterEndDateTime = FilterEndDateTime;

    if (this.IsParameterBound(nameof(FilterStartDateTime)))
        body.FilterStartDateTime = FilterStartDateTime;

    if (this.IsParameterBound(nameof(IpAddressFilters)))
        body.IpAddressFilters = IpAddressFilters!.ToList();

    if (this.IsParameterBound(nameof(KeywordFilter)))
        body.KeywordFilter = KeywordFilter;

    if (this.IsParameterBound(nameof(ObjectIdFilters)))
        body.ObjectIdFilters = ObjectIdFilters!.ToList();

    if (this.IsParameterBound(nameof(OperationFilters)))
        body.OperationFilters = OperationFilters!.ToList();

    if (this.IsParameterBound(nameof(ServiceFilters)))
        body.ServiceFilters = ServiceFilters!.ToList();

    if (this.IsParameterBound(nameof(UserPrincipalNameFilters)))
        body.UserPrincipalNameFilters = UserPrincipalNameFilters!.ToList();

    if (this.IsParameterBound(nameof(RecordTypeFilters)))
        body.RecordTypeFilters = RecordTypeFilters!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQuery? result;
            try
            {
                result = client.Security.AuditLog.Queries.PostAsync(body, requestConfiguration =>
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
