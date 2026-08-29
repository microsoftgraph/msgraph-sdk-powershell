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
    [GraphRoute("PATCH", "/education/reports/readingCoachPassages/{readingCoachPassage-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationReportReadingCoachPassage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.ReadingCoachPassage))]
    public class UpdateMgEducationReportReadingCoachPassageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ReadingCoachPassageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsReadingCompleted { get; set; }

        [Parameter(Mandatory = false)]
        public string? LanguageTag { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? PracticedAtDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? PracticeWords { get; set; }

        [Parameter(Mandatory = false)]
        public string? StudentId { get; set; }

        [Parameter(Mandatory = false)]
        public double? TimeSpentReadingInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public double? WordsAccuracyPercentage { get; set; }

        [Parameter(Mandatory = false)]
        public double? WordsPerMinute { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.ReadingCoachStoryType? StoryType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ReadingCoachPassageId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.ReadingCoachPassage();

    if (this.IsParameterBound(nameof(IsReadingCompleted)))
        body.IsReadingCompleted = IsReadingCompleted;

    if (this.IsParameterBound(nameof(LanguageTag)))
        body.LanguageTag = LanguageTag;

    if (this.IsParameterBound(nameof(PracticedAtDateTime)))
        body.PracticedAtDateTime = PracticedAtDateTime;

    if (this.IsParameterBound(nameof(PracticeWords)))
        body.PracticeWords = PracticeWords!.ToList();

    if (this.IsParameterBound(nameof(StudentId)))
        body.StudentId = StudentId;

    if (this.IsParameterBound(nameof(TimeSpentReadingInSeconds)))
        body.TimeSpentReadingInSeconds = TimeSpentReadingInSeconds;

    if (this.IsParameterBound(nameof(WordsAccuracyPercentage)))
        body.WordsAccuracyPercentage = WordsAccuracyPercentage;

    if (this.IsParameterBound(nameof(WordsPerMinute)))
        body.WordsPerMinute = WordsPerMinute;

    if (this.IsParameterBound(nameof(StoryType)))
        body.StoryType = StoryType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.ReadingCoachPassage? result;
            try
            {
                result = client.Education.Reports.ReadingCoachPassages[ReadingCoachPassageId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ReadingCoachPassageId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Reports.ReadingCoachPassages[ReadingCoachPassageId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ReadingCoachPassageId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
