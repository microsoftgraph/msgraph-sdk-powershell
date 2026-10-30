#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("PATCH", "/users/{user-id}/settings/regionalAndLanguageSettings")]
    [Cmdlet(VerbsData.Update, "MgUserSettingRegionalAndLanguageSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.RegionalAndLanguageSettings))]
    public class UpdateMgUserSettingRegionalAndLanguageSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.LocaleInfo[]? AuthoringLanguages { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.LocaleInfo? DefaultDisplayLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.LocaleInfo? DefaultRegionalFormat { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.LocaleInfo? DefaultSpeechInputLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.LocaleInfo? DefaultTranslationLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.RegionalFormatOverrides? RegionalFormatOverrides { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.TranslationPreferences? TranslationPreferences { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.RegionalAndLanguageSettings();


    if (this.IsParameterBound(nameof(AuthoringLanguages)))
        body.AuthoringLanguages = AuthoringLanguages!.ToList();

    if (this.IsParameterBound(nameof(DefaultDisplayLanguage)))
        body.DefaultDisplayLanguage = DefaultDisplayLanguage;

    if (this.IsParameterBound(nameof(DefaultRegionalFormat)))
        body.DefaultRegionalFormat = DefaultRegionalFormat;

    if (this.IsParameterBound(nameof(DefaultSpeechInputLanguage)))
        body.DefaultSpeechInputLanguage = DefaultSpeechInputLanguage;

    if (this.IsParameterBound(nameof(DefaultTranslationLanguage)))
        body.DefaultTranslationLanguage = DefaultTranslationLanguage;

    if (this.IsParameterBound(nameof(RegionalFormatOverrides)))
        body.RegionalFormatOverrides = RegionalFormatOverrides;

    if (this.IsParameterBound(nameof(TranslationPreferences)))
        body.TranslationPreferences = TranslationPreferences;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.RegionalAndLanguageSettings? result;
            try
            {
                result = client.Users[UserId].Settings.RegionalAndLanguageSettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Settings.RegionalAndLanguageSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
