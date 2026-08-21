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
    [GraphRoute("PATCH", "/education/reports/speakerAssignmentSubmissions/{speakerAssignmentSubmission-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationReportSpeakerAssignmentSubmission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.SpeakerAssignmentSubmission))]
    public class UpdateMgEducationReportSpeakerAssignmentSubmissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SpeakerAssignmentSubmissionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AssignmentId { get; set; }

        [Parameter(Mandatory = false)]
        public long? AverageWordsPerMinutePace { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClassId { get; set; }

        [Parameter(Mandatory = false)]
        public long? FillerWordsOccurrencesCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? IncorrectCameraDistanceOccurrencesCount { get; set; }

        [Parameter(Mandatory = false)]
        public double? LengthOfSubmissionInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public long? LostEyeContactOccurrencesCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? MonotoneOccurrencesCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? NonInclusiveLanguageOccurrencesCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? ObstructedViewOccurrencesCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? RepetitiveLanguageOccurrencesCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? StudentId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SubmissionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubmissionId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? TopFillerWords { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? TopMispronouncedWords { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? TopNonInclusiveWordsAndPhrases { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? TopRepetitiveWordsAndPhrases { get; set; }

        [Parameter(Mandatory = false)]
        public long? WordsSpokenCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SpeakerAssignmentSubmissionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.SpeakerAssignmentSubmission();

    if (this.IsParameterBound(nameof(AssignmentId)))
        body.AssignmentId = AssignmentId;

    if (this.IsParameterBound(nameof(AverageWordsPerMinutePace)))
        body.AverageWordsPerMinutePace = AverageWordsPerMinutePace;

    if (this.IsParameterBound(nameof(ClassId)))
        body.ClassId = ClassId;

    if (this.IsParameterBound(nameof(FillerWordsOccurrencesCount)))
        body.FillerWordsOccurrencesCount = FillerWordsOccurrencesCount;

    if (this.IsParameterBound(nameof(IncorrectCameraDistanceOccurrencesCount)))
        body.IncorrectCameraDistanceOccurrencesCount = IncorrectCameraDistanceOccurrencesCount;

    if (this.IsParameterBound(nameof(LengthOfSubmissionInSeconds)))
        body.LengthOfSubmissionInSeconds = LengthOfSubmissionInSeconds;

    if (this.IsParameterBound(nameof(LostEyeContactOccurrencesCount)))
        body.LostEyeContactOccurrencesCount = LostEyeContactOccurrencesCount;

    if (this.IsParameterBound(nameof(MonotoneOccurrencesCount)))
        body.MonotoneOccurrencesCount = MonotoneOccurrencesCount;

    if (this.IsParameterBound(nameof(NonInclusiveLanguageOccurrencesCount)))
        body.NonInclusiveLanguageOccurrencesCount = NonInclusiveLanguageOccurrencesCount;

    if (this.IsParameterBound(nameof(ObstructedViewOccurrencesCount)))
        body.ObstructedViewOccurrencesCount = ObstructedViewOccurrencesCount;

    if (this.IsParameterBound(nameof(RepetitiveLanguageOccurrencesCount)))
        body.RepetitiveLanguageOccurrencesCount = RepetitiveLanguageOccurrencesCount;

    if (this.IsParameterBound(nameof(StudentId)))
        body.StudentId = StudentId;

    if (this.IsParameterBound(nameof(SubmissionDateTime)))
        body.SubmissionDateTime = SubmissionDateTime;

    if (this.IsParameterBound(nameof(SubmissionId)))
        body.SubmissionId = SubmissionId;

    if (this.IsParameterBound(nameof(TopFillerWords)))
        body.TopFillerWords = TopFillerWords!.ToList();

    if (this.IsParameterBound(nameof(TopMispronouncedWords)))
        body.TopMispronouncedWords = TopMispronouncedWords!.ToList();

    if (this.IsParameterBound(nameof(TopNonInclusiveWordsAndPhrases)))
        body.TopNonInclusiveWordsAndPhrases = TopNonInclusiveWordsAndPhrases!.ToList();

    if (this.IsParameterBound(nameof(TopRepetitiveWordsAndPhrases)))
        body.TopRepetitiveWordsAndPhrases = TopRepetitiveWordsAndPhrases!.ToList();

    if (this.IsParameterBound(nameof(WordsSpokenCount)))
        body.WordsSpokenCount = WordsSpokenCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.SpeakerAssignmentSubmission? result;
            try
            {
                result = client.Education.Reports.SpeakerAssignmentSubmissions[SpeakerAssignmentSubmissionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SpeakerAssignmentSubmissionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Reports.SpeakerAssignmentSubmissions[SpeakerAssignmentSubmissionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, SpeakerAssignmentSubmissionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
