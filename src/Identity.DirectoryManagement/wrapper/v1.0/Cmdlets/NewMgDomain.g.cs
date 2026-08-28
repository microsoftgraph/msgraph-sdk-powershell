#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/domains")]
    [Cmdlet(VerbsCommon.New, "MgDomain", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Domain))]
    public class NewMgDomainCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AuthenticationType { get; set; }

        [Parameter(Mandatory = false)]
        public string? AvailabilityStatus { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAdminManaged { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInitial { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRoot { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsVerified { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manufacturer { get; set; }

        [Parameter(Mandatory = false)]
        public string? Model { get; set; }

        [Parameter(Mandatory = false)]
        public int? PasswordNotificationWindowInDays { get; set; }

        [Parameter(Mandatory = false)]
        public int? PasswordValidityPeriodInDays { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SupportedServices { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DomainState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Domain();

    if (this.IsParameterBound(nameof(AuthenticationType)))
        body.AuthenticationType = AuthenticationType;

    if (this.IsParameterBound(nameof(AvailabilityStatus)))
        body.AvailabilityStatus = AvailabilityStatus;

    if (this.IsParameterBound(nameof(IsAdminManaged)))
        body.IsAdminManaged = IsAdminManaged;

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(IsInitial)))
        body.IsInitial = IsInitial;

    if (this.IsParameterBound(nameof(IsRoot)))
        body.IsRoot = IsRoot;

    if (this.IsParameterBound(nameof(IsVerified)))
        body.IsVerified = IsVerified;

    if (this.IsParameterBound(nameof(Manufacturer)))
        body.Manufacturer = Manufacturer;

    if (this.IsParameterBound(nameof(Model)))
        body.Model = Model;

    if (this.IsParameterBound(nameof(PasswordNotificationWindowInDays)))
        body.PasswordNotificationWindowInDays = PasswordNotificationWindowInDays;

    if (this.IsParameterBound(nameof(PasswordValidityPeriodInDays)))
        body.PasswordValidityPeriodInDays = PasswordValidityPeriodInDays;

    if (this.IsParameterBound(nameof(SupportedServices)))
        body.SupportedServices = SupportedServices!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Domain? result;
            try
            {
                result = client.Domains.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
