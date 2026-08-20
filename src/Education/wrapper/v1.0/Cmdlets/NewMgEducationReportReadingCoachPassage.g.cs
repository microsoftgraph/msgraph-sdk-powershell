#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("POST", "/education/reports/readingCoachPassages")]
    [Cmdlet(VerbsCommon.New, "MgEducationReportReadingCoachPassage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.ReadingCoachPassage))]
    public class NewMgEducationReportReadingCoachPassageCommand : PSCmdlet
    {


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




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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


        // ── Choose HttpClient + auth provider ─────────────────────────────
        HttpClient httpClient;
        IAuthenticationProvider authProvider;

        if (this.IsParameterBound(nameof(AccessToken)))
        {
            httpClient = new HttpClient();
            authProvider = new StaticBearerTokenAuthenticationProvider(AccessToken!);
        }
        else
        {
            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            try
            {
                httpClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession",
                    ErrorCategory.AuthenticationError,
                    null));
                return;
            }
            authProvider = new AnonymousAuthenticationProvider();
        }

        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.ReadingCoachPassage? result;
            try
            {
                result = client.Education.Reports.ReadingCoachPassages.PostAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, body));
                return;
            }

            WriteObject(result);
        }
    }
}
