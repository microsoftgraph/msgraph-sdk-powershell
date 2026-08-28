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
    [GraphRoute("POST", "/education/classes")]
    [Cmdlet(VerbsCommon.New, "MgEducationClass", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationClass))]
    public class NewMgEducationClassCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ClassCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalSourceDetail { get; set; }

        [Parameter(Mandatory = false)]
        public string? Grade { get; set; }

        [Parameter(Mandatory = false)]
        public string? MailNickname { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationCourse? Course { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationExternalSource? ExternalSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationTerm? Term { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationClass();

    if (this.IsParameterBound(nameof(ClassCode)))
        body.ClassCode = ClassCode;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExternalId)))
        body.ExternalId = ExternalId;

    if (this.IsParameterBound(nameof(ExternalName)))
        body.ExternalName = ExternalName;

    if (this.IsParameterBound(nameof(ExternalSourceDetail)))
        body.ExternalSourceDetail = ExternalSourceDetail;

    if (this.IsParameterBound(nameof(Grade)))
        body.Grade = Grade;

    if (this.IsParameterBound(nameof(MailNickname)))
        body.MailNickname = MailNickname;

    if (this.IsParameterBound(nameof(Course)))
        body.Course = Course;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(ExternalSource)))
        body.ExternalSource = ExternalSource;

    if (this.IsParameterBound(nameof(Term)))
        body.Term = Term;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationClass? result;
            try
            {
                result = client.Education.Classes.PostAsync(body, requestConfiguration =>
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
