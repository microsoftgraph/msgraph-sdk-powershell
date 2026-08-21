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
    [GraphRoute("POST", "/education/reports/readingAssignmentSubmissions")]
    [Cmdlet(VerbsCommon.New, "MgEducationReportReadingAssignmentSubmission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.ReadingAssignmentSubmission))]
    public class NewMgEducationReportReadingAssignmentSubmissionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public double? AccuracyScore { get; set; }

        [Parameter(Mandatory = false)]
        public string? Action { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssignmentId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClassId { get; set; }

        [Parameter(Mandatory = false)]
        public long? Insertions { get; set; }

        [Parameter(Mandatory = false)]
        public long? Mispronunciations { get; set; }

        [Parameter(Mandatory = false)]
        public long? MissedExclamationMarks { get; set; }

        [Parameter(Mandatory = false)]
        public long? MissedPeriods { get; set; }

        [Parameter(Mandatory = false)]
        public long? MissedQuestionMarks { get; set; }

        [Parameter(Mandatory = false)]
        public long? MissedShorts { get; set; }

        [Parameter(Mandatory = false)]
        public double? MonotoneScore { get; set; }

        [Parameter(Mandatory = false)]
        public long? Omissions { get; set; }

        [Parameter(Mandatory = false)]
        public long? Repetitions { get; set; }

        [Parameter(Mandatory = false)]
        public long? SelfCorrections { get; set; }

        [Parameter(Mandatory = false)]
        public string? StudentId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SubmissionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubmissionId { get; set; }

        [Parameter(Mandatory = false)]
        public long? UnexpectedPauses { get; set; }

        [Parameter(Mandatory = false)]
        public long? WordCount { get; set; }

        [Parameter(Mandatory = false)]
        public double? WordsPerMinute { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.ChallengingWord[]? ChallengingWords { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.ReadingAssignmentSubmission();

    if (this.IsParameterBound(nameof(AccuracyScore)))
        body.AccuracyScore = AccuracyScore;

    if (this.IsParameterBound(nameof(Action)))
        body.Action = Action;

    if (this.IsParameterBound(nameof(AssignmentId)))
        body.AssignmentId = AssignmentId;

    if (this.IsParameterBound(nameof(ClassId)))
        body.ClassId = ClassId;

    if (this.IsParameterBound(nameof(Insertions)))
        body.Insertions = Insertions;

    if (this.IsParameterBound(nameof(Mispronunciations)))
        body.Mispronunciations = Mispronunciations;

    if (this.IsParameterBound(nameof(MissedExclamationMarks)))
        body.MissedExclamationMarks = MissedExclamationMarks;

    if (this.IsParameterBound(nameof(MissedPeriods)))
        body.MissedPeriods = MissedPeriods;

    if (this.IsParameterBound(nameof(MissedQuestionMarks)))
        body.MissedQuestionMarks = MissedQuestionMarks;

    if (this.IsParameterBound(nameof(MissedShorts)))
        body.MissedShorts = MissedShorts;

    if (this.IsParameterBound(nameof(MonotoneScore)))
        body.MonotoneScore = MonotoneScore;

    if (this.IsParameterBound(nameof(Omissions)))
        body.Omissions = Omissions;

    if (this.IsParameterBound(nameof(Repetitions)))
        body.Repetitions = Repetitions;

    if (this.IsParameterBound(nameof(SelfCorrections)))
        body.SelfCorrections = SelfCorrections;

    if (this.IsParameterBound(nameof(StudentId)))
        body.StudentId = StudentId;

    if (this.IsParameterBound(nameof(SubmissionDateTime)))
        body.SubmissionDateTime = SubmissionDateTime;

    if (this.IsParameterBound(nameof(SubmissionId)))
        body.SubmissionId = SubmissionId;

    if (this.IsParameterBound(nameof(UnexpectedPauses)))
        body.UnexpectedPauses = UnexpectedPauses;

    if (this.IsParameterBound(nameof(WordCount)))
        body.WordCount = WordCount;

    if (this.IsParameterBound(nameof(WordsPerMinute)))
        body.WordsPerMinute = WordsPerMinute;

    if (this.IsParameterBound(nameof(ChallengingWords)))
        body.ChallengingWords = ChallengingWords!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.ReadingAssignmentSubmission? result;
            try
            {
                result = client.Education.Reports.ReadingAssignmentSubmissions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
