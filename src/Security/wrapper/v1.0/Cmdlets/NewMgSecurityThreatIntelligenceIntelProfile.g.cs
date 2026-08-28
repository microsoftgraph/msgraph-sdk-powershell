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
    [GraphRoute("POST", "/security/threatIntelligence/intelProfiles")]
    [Cmdlet(VerbsCommon.New, "MgSecurityThreatIntelligenceIntelProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfile))]
    public class NewMgSecurityThreatIntelligenceIntelProfileCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? Aliases { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstActiveDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Targets { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin[]? CountriesOrRegionsOfOrigin { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.FormattedContent? Description { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfileKind? Kind { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.FormattedContent? Summary { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.FormattedContent? Tradecraft { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfile();

    if (this.IsParameterBound(nameof(Aliases)))
        body.Aliases = Aliases!.ToList();

    if (this.IsParameterBound(nameof(FirstActiveDateTime)))
        body.FirstActiveDateTime = FirstActiveDateTime;

    if (this.IsParameterBound(nameof(Targets)))
        body.Targets = Targets!.ToList();

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(CountriesOrRegionsOfOrigin)))
        body.CountriesOrRegionsOfOrigin = CountriesOrRegionsOfOrigin!.ToList();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(Kind)))
        body.Kind = Kind;

    if (this.IsParameterBound(nameof(Summary)))
        body.Summary = Summary;

    if (this.IsParameterBound(nameof(Tradecraft)))
        body.Tradecraft = Tradecraft;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfile? result;
            try
            {
                result = client.Security.ThreatIntelligence.IntelProfiles.PostAsync(body, requestConfiguration =>
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
