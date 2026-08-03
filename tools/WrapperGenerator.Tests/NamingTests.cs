using System.Net.Http;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

// The expected values are the published Microsoft.Graph cmdlet names, taken from the
// MgCommandMetadata.json inventory that ships inside Microsoft.Graph.Authentication.
// Changing one of these is a deliberate break from SDK parity and belongs in the
// migration guide, not in a quiet test edit.
public sealed class SingularizerTests
{
    [Theory]
    // ies -> y
    [InlineData("Policies", "Policy")]
    [InlineData("Categories", "Category")]
    // uses -> us (Get-MgDeviceManagementDeviceConfigurationUserStatus)
    [InlineData("Statuses", "Status")]
    // sibilant es
    [InlineData("Businesses", "Business")]
    [InlineData("Mailboxes", "Mailbox")]
    [InlineData("Branches", "Branch")]
    // ss/us/is guard
    [InlineData("Access", "Access")]
    [InlineData("Status", "Status")]
    [InlineData("Analysis", "Analysis")]
    // plain s
    [InlineData("Messages", "Message")]
    [InlineData("Plans", "Plan")]
    [InlineData("Settings", "Setting")]
    [InlineData("Licenses", "License")]
    // irregulars (Get-MgDriveItemChild, Get-MgUserPerson,
    // Get-MgSecurityThreatIntelligenceHostCookie, Get-MgSubscribedSku)
    [InlineData("Children", "Child")]
    [InlineData("People", "Person")]
    [InlineData("Cookies", "Cookie")]
    [InlineData("Skus", "Sku")]
    // invariants (Get-MgUserSettingWindows, Get-MgDomainVerificationDnsRecord,
    // Get-MgDeviceAppManagementIosManagedAppProtection)
    [InlineData("Windows", "Windows")]
    [InlineData("Dns", "Dns")]
    [InlineData("Ios", "Ios")]
    // acronyms are never plural forms
    [InlineData("OS", "OS")]
    public void SingularizesWords(string word, string expected)
    {
        Assert.Equal(expected, Singularizer.SingularizeWord(word));
    }

    [Theory]
    [InlineData("Users", "User")]
    [InlineData("ManagedDevices", "ManagedDevice")]
    [InlineData("BookingBusinesses", "BookingBusiness")]
    [InlineData("ReportSettings", "ReportSetting")]
    [InlineData("ConditionalAccess", "ConditionalAccess")]
    // per-word inflection, matching the published SDK's inflector:
    // Update-MgDeviceManagementTermAndCondition
    [InlineData("TermsAndConditions", "TermAndCondition")]
    // Get-MgDirectoryOnPremiseSynchronization (interior word singularized)
    [InlineData("OnPremisesSynchronization", "OnPremiseSynchronization")]
    // version tag: Get-MgSecurityAlertV2
    [InlineData("Alerts_v2", "AlertV2")]
    public void SingularizesSegments(string segment, string expected)
    {
        Assert.Equal(expected, Singularizer.SingularizeSegment(segment));
    }
}

public sealed class NamingTests
{
    private static CmdletNaming Resolve(string method, string path) =>
        Naming.Resolve(new OperationInfo(new HttpMethod(method), path));

    [Theory]
    // pilot module goldens (Microsoft.Graph.* 2.37.0 names)
    [InlineData("GET", "/users", "Get", "MgUser")]
    [InlineData("GET", "/users/{user-id}", "Get", "MgUser")]
    [InlineData("POST", "/users", "New", "MgUser")]
    [InlineData("PATCH", "/users/{user-id}", "Update", "MgUser")]
    [InlineData("DELETE", "/users/{user-id}", "Remove", "MgUser")]
    [InlineData("GET", "/users/{user-id}/messages", "Get", "MgUserMessage")]
    [InlineData("GET", "/users/{user-id}/messages/{message-id}", "Get", "MgUserMessage")]
    [InlineData("GET", "/users/{user-id}/contacts", "Get", "MgUserContact")]
    [InlineData("GET", "/applications/{application-id}", "Get", "MgApplication")]
    [InlineData("GET", "/deviceManagement/managedDevices", "Get", "MgDeviceManagementManagedDevice")]
    [InlineData("GET", "/identity/conditionalAccess/policies/{conditionalAccessPolicy-id}", "Get", "MgIdentityConditionalAccessPolicy")]
    [InlineData("GET", "/planner/plans", "Get", "MgPlannerPlan")]
    [InlineData("GET", "/security/alerts_v2", "Get", "MgSecurityAlertV2")]
    [InlineData("PATCH", "/admin/reportSettings", "Update", "MgAdminReportSetting")]
    [InlineData("GET", "/schemaExtensions", "Get", "MgSchemaExtension")]
    [InlineData("GET", "/domains/{domain-id}", "Get", "MgDomain")]
    [InlineData("GET", "/groups/{group-id}", "Get", "MgGroup")]
    [InlineData("GET", "/teams/{team-id}", "Get", "MgTeam")]
    // overrides mirroring the SDK's own AutoRest directives (see NamingOverrides)
    [InlineData("GET", "/solutions/bookingBusinesses/{bookingBusiness-id}", "Get", "MgBookingBusiness")]
    [InlineData("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}", "Update", "MgBookingBusiness")]
    [InlineData("GET", "/users/{user-id}/calendar", "Get", "MgUserDefaultCalendar")]
    // boundary word-overlap collapse (Get-MgDomainNameReference)
    [InlineData("GET", "/domains/{domain-id}/domainNameReferences", "Get", "MgDomainNameReference")]
    // adjacent-duplicate collapse (Get-MgUserOnenoteSectionGroup... family)
    [InlineData("GET", "/users/{user-id}/onenote/sectionGroups/{sectionGroup-id}/sectionGroups", "Get", "MgUserOnenoteSectionGroup")]
    // OData cast segments (Get-MgGroupOwnerAsUser)
    [InlineData("GET", "/groups/{group-id}/owners/{directoryObject-id}/graph.user", "Get", "MgGroupOwnerAsUser")]
    public void ResolvesPublishedSdkNames(string method, string path, string expectedVerb, string expectedNoun)
    {
        var naming = Resolve(method, path);
        Assert.Equal(expectedVerb, naming.VerbName);
        Assert.Equal(expectedNoun, naming.Noun);
        Assert.Equal($"{expectedVerb}{expectedNoun}Command", naming.ClassName);
    }

    [Theory]
    // The builder expression is the Kiota request-builder chain the emitted cmdlet calls
    // (client.<expr>.GetAsync()). A property per fixed segment, an indexer per path parameter.
    [InlineData("/users", "Users")]
    [InlineData("/users/{user-id}", "Users[UserId]")]
    [InlineData("/users/{user-id}/messages", "Users[UserId].Messages")]
    [InlineData("/users/{user-id}/messages/{message-id}", "Users[UserId].Messages[MessageId]")]
    [InlineData("/deviceManagement/managedDevices", "DeviceManagement.ManagedDevices")]
    [InlineData("/identity/conditionalAccess/policies/{conditionalAccessPolicy-id}", "Identity.ConditionalAccess.Policies[ConditionalAccessPolicyId]")]
    // OData cast segments: a dotted segment is one Kiota builder member, not a member access.
    // Verified against a real Kiota C# client: microsoft.graph.user -> the MicrosoftGraphUser
    // request-builder property; graph.user (KiotaCompat form) -> GraphUser by the same rule.
    [InlineData("/groups/{group-id}/owners/{directoryObject-id}/graph.user", "Groups[GroupId].Owners[DirectoryObjectId].GraphUser")]
    [InlineData("/groups/{group-id}/owners/{directoryObject-id}/microsoft.graph.user", "Groups[GroupId].Owners[DirectoryObjectId].MicrosoftGraphUser")]
    public void BuildsKiotaBuilderExpression(string path, string expectedExpression)
    {
        Assert.Equal(expectedExpression, Resolve("GET", path).BuilderExpression);
    }

    [Fact]
    public void SuppressesOperationsThePublishedSdkOmits()
    {
        // Calendar.md remove-path-by-operation user_UpdateCalendar: no Update cmdlet ships for
        // the default-calendar singleton.
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Patch, "/users/{user-id}/calendar"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/users/{user-id}/calendar"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Patch, "/users/{user-id}/messages/{message-id}"));

        // Bookings.md remove-path-by-operation ^solution\.solutionsRoot.*$: the /solutions root
        // singleton ships no cmdlets, but its children are untouched.
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/solutions"));
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Patch, "/solutions"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/solutions/bookingBusinesses/{bookingBusiness-id}"));
    }

    [Theory]
    // Both cast prefixes the specs use resolve to the same noun part.
    [InlineData("graph.user", "AsUser")]
    [InlineData("microsoft.graph.user", "AsUser")]
    // A plural cast type is singularized rather than assumed singular (review hardening).
    [InlineData("microsoft.graph.users", "AsUser")]
    // Non-cast segments are not cast nouns.
    [InlineData("messages", null)]
    [InlineData("users", null)]
    public void BuildsCastSegmentNouns(string segment, string? expected)
    {
        Assert.Equal(expected, Naming.TryBuildCastSegmentNoun(segment));
    }

    [Fact]
    public void ListAndItemGetsShareTheNounSoDispatcherPairingSurvives()
    {
        var list = Resolve("GET", "/users/{user-id}/messages");
        var item = Resolve("GET", "/users/{user-id}/messages/{message-id}");
        Assert.Equal(list.Noun, item.Noun);

        var internalList = Naming.WithSuffix(list, "_List");
        Assert.Equal("MgUserMessage_List", internalList.Noun);
        Assert.Equal("GetMgUserMessage_ListCommand", internalList.ClassName);
    }

    [Fact]
    public void CleanListItemPairMerges()
    {
        // A list GET and its item GET one id deeper share a noun and fit structurally, so they
        // merge into the single public Get-MgUserMessage dispatcher.
        var list = Resolve("GET", "/users/{user-id}/messages");
        var item = Resolve("GET", "/users/{user-id}/messages/{message-id}");
        Assert.Equal(list.Noun, item.Noun);
        Assert.True(Naming.IsListItemPair(list, item));
    }

    [Fact]
    public void GetWithNoStructuralPartnerStaysStandalone()
    {
        // A list under one resource and an item under a different resource neither share a noun
        // nor fit structurally, so nothing merges — the list is emitted as a standalone cmdlet.
        var contactsList = Resolve("GET", "/users/{user-id}/contacts");
        var messageItem = Resolve("GET", "/users/{user-id}/messages/{message-id}");
        Assert.NotEqual(contactsList.Noun, messageItem.Noun);
        Assert.False(Naming.IsListItemPair(contactsList, messageItem));
    }

    [Fact]
    public void AmbiguousSameNounDoesNotMerge()
    {
        // Self-referential /sites: the collection /sites/{id}/sites and the single /sites/{id}
        // both resolve to MgSite, but the "item" is the parent, not a child one id deeper, so
        // the structural check rejects the merge and both stay standalone.
        var list = Resolve("GET", "/sites/{site-id}/sites");
        var item = Resolve("GET", "/sites/{site-id}");
        Assert.Equal(list.Noun, item.Noun);
        Assert.False(Naming.IsListItemPair(list, item));
    }
}
