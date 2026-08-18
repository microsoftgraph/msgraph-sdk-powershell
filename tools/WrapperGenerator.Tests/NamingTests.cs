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
    // "Whois" also hits the is-guard — a deliberate correction, not a parity pin: the SDK
    // ships Get-MgSecurityThreatIntelligenceHostWhoi (AutoRest inflected the trailing
    // "whois" segment) while its 28 whoisRecords/whoisHistoryRecords siblings keep "Whois".
    // See docs/edge-cases/naming-edge-cases.md.
    [InlineData("Whois", "Whois")]
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
    // Get-MgDeviceAppManagementIosManagedAppProtection,
    // Get-MgSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation)
    [InlineData("Windows", "Windows")]
    [InlineData("Dns", "Dns")]
    [InlineData("Ios", "Ios")]
    [InlineData("Statistics", "Statistics")]
    [InlineData("Rights", "Rights")]
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
    // interior "Whois" survives per-word inflection (Get-MgSecurityThreatIntelligenceWhoisHistoryRecord)
    [InlineData("WhoisHistoryRecords", "WhoisHistoryRecord")]
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
    [InlineData("GET", "/security/threatIntelligence/whoisRecords/{whoisRecord-id}", "Get", "MgSecurityThreatIntelligenceWhoisRecord")]
    // interior "Statistics" survives per-word inflection (invariant found via the DEVX API's Humanizer exception list)
    [InlineData("GET", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/searches/{ediscoverySearch-id}/lastEstimateStatisticsOperation", "Get", "MgSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation")]
    // interior "Rights" survives per-word inflection (Get-MgPrivacySubjectRightsRequest, found by the full-module parity sweep)
    [InlineData("GET", "/privacy/subjectRightsRequests/{subjectRightsRequest-id}", "Get", "MgPrivacySubjectRightsRequest")]
    [InlineData("PATCH", "/admin/reportSettings", "Update", "MgAdminReportSetting")]
    [InlineData("GET", "/schemaExtensions", "Get", "MgSchemaExtension")]
    [InlineData("GET", "/domains/{domain-id}", "Get", "MgDomain")]
    [InlineData("GET", "/groups/{group-id}", "Get", "MgGroup")]
    [InlineData("GET", "/teams/{team-id}", "Get", "MgTeam")]
    // overrides mirroring the SDK's own AutoRest directives (see NamingOverrides)
    [InlineData("GET", "/solutions/bookingBusinesses/{bookingBusiness-id}", "Get", "MgBookingBusiness")]
    [InlineData("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}", "Update", "MgBookingBusiness")]
    [InlineData("GET", "/users/{user-id}/calendar", "Get", "MgUserDefaultCalendar")]
    // self-referential sites rename to SubSite instead of colliding with the parent noun
    [InlineData("GET", "/sites/{site-id}/sites", "Get", "MgSubSite")]
    [InlineData("GET", "/sites/{site-id}/sites/{site-id1}", "Get", "MgSubSite")]
    [InlineData("GET", "/groups/{group-id}/sites/{site-id}/sites", "Get", "MgGroupSubSite")]
    [InlineData("GET", "/groups/{group-id}/sites/{site-id}/sites/{site-id1}", "Get", "MgGroupSubSite")]
    // default-singleton renames (issue #3704 oracle sweep)
    [InlineData("GET", "/users/{user-id}/drive", "Get", "MgUserDefaultDrive")]
    [InlineData("GET", "/groups/{group-id}/drive", "Get", "MgGroupDefaultDrive")]
    [InlineData("GET", "/sites/{site-id}/drive", "Get", "MgSiteDefaultDrive")]
    [InlineData("GET", "/groups/{group-id}/sites/{site-id}/drive", "Get", "MgGroupSiteDefaultDrive")]
    [InlineData("GET", "/users/{user-id}/calendar/events", "Get", "MgUserDefaultCalendarEvent")]
    // nested-collection GET renamed by the Groups.md directive (subject $1ByGroup)
    [InlineData("GET", "/groups/{group-id}/groupLifecyclePolicies", "Get", "MgGroupLifecyclePolicyByGroup")]
    // boundary word-overlap collapse (Get-MgDomainNameReference)
    [InlineData("GET", "/domains/{domain-id}/domainNameReferences", "Get", "MgDomainNameReference")]
    // adjacent-duplicate collapse (Get-MgUserOnenoteSectionGroup... family)
    [InlineData("GET", "/users/{user-id}/onenote/sectionGroups/{sectionGroup-id}/sectionGroups", "Get", "MgUserOnenoteSectionGroup")]
    // OData cast segments (Get-MgGroupOwnerAsUser)
    [InlineData("GET", "/groups/{group-id}/owners/{directoryObject-id}/graph.user", "Get", "MgGroupOwnerAsUser")]
    // A /$count directly after a cast counts the cast-filtered collection, and the published name
    // puts Count before the cast suffix: 131 v1.0 routes have this shape and all ship this way
    // (Get-MgUserMemberOfCountAsGroup, Get-MgDeviceRegisteredUserCountAsEndpoint).
    [InlineData("GET", "/users/{user-id}/memberOf/graph.group/$count", "Get", "MgUserMemberOfCountAsGroup")]
    [InlineData("GET", "/deviceAppManagement/mobileApps/graph.win32LobApp/$count", "Get", "MgDeviceAppManagementMobileAppCountAsWin32LobApp")]
    // ...but only a DIRECTLY adjacent cast moves. With a segment in between, the cast keeps its
    // position and Count stays last (Get-MgDeviceAppManagementMobileAppAsAndroidLobAppCategoryCount).
    // This pair is the boundary: reordering unconditionally would break this name.
    [InlineData("GET", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.androidLobApp/categories/$count", "Get", "MgDeviceAppManagementMobileAppAsAndroidLobAppCategoryCount")]
    public void ResolvesPublishedSdkNames(string method, string path, string expectedVerb, string expectedNoun)
    {
        var naming = Resolve(method, path);
        Assert.Equal(expectedVerb, naming.VerbName);
        Assert.Equal(expectedNoun, naming.Noun);
        Assert.Equal($"{expectedVerb}{expectedNoun}Command", naming.ClassName);
    }

    [Theory]
    // Deliberate corrections: the published name is wrong (an AutoRest naming defect) and the
    // generator emits the corrected name instead of reproducing it. Every entry here must have
    // an docs/edge-cases/naming-edge-cases.md entry and a matching row in
    // Compare-WrapperCmdletNames.ps1's $deliberateCorrections table, so the parity gate
    // reports it as [CORRECTED], not a failure.
    // Shipped: Get-MgSecurityThreatIntelligenceHostWhoi — the only whois-family cmdlet (of 30)
    // where "Whois" was inflected to "Whoi".
    [InlineData("GET", "/security/threatIntelligence/hosts/{host-id}/whois", "Get", "MgSecurityThreatIntelligenceHostWhois")]
    // Shipped: New-MgPlaceCheck — AutoRest truncated "CheckIns" at the preposition (#912
    // class) while Get-MgPlaceCheckInCount keeps "In" intact.
    [InlineData("GET", "/places/{place-id}/checkIns", "Get", "MgPlaceCheckIn")]
    [InlineData("POST", "/places/{place-id}/checkIns", "New", "MgPlaceCheckIn")]
    public void AppliesDeliberateNameCorrections(string method, string path, string expectedVerb, string expectedNoun)
    {
        var naming = Resolve(method, path);
        Assert.Equal(expectedVerb, naming.VerbName);
        Assert.Equal(expectedNoun, naming.Noun);
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

        // The /photos collection ships no distinct cmdlet; only the /photo singleton does.
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/users/{user-id}/photos"));
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/users/{user-id}/photos/{userProfilePhoto-id}"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/users/{user-id}/photo"));

        // Suffix-matched suppressions apply under any root; siblings stay generated
        // (issue #3704: Info-wrapper navs ship nothing, their siblings ship).
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/chats/{chat-id}/pinnedMessages/{pinnedChatMessageInfo-id}/message"));
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/teams/{team-id}/channels/{channel-id}/sharedWithTeams/{id}/team"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/teams/{team-id}/channels/{channel-id}/sharedWithTeams/{id}/allowedMembers"));

        // Exact-matched suppressions cover only the named node; descendants with no entry of
        // their own stay generated (Security nested navs, issue #3704).
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/security/threatIntelligence/hosts/{host-id}/components"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/security/threatIntelligence/hosts/{host-id}/components/$count"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/security/threatIntelligence/hosts/{host-id}/passiveDns"));

        // termStore trees are stitched: /termStores/{id} descendants ship nothing (the 402
        // descendant command rows come from the /termStore singleton trees), and the singleton
        // root GET ships no distinct cmdlet (Get-MgSiteTermStore serves both /termStore and
        // /termStores; GET generates from the collection side only).
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/sites/{site-id}/termStores/{store-id}"));
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/sites/{site-id}/termStores/{store-id}/sets/{set-id}"));
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/sites/{site-id}/termStore"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Patch, "/sites/{site-id}/termStore"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/sites/{site-id}/termStores"));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/sites/{site-id}/termStore/sets/{set-id}"));
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
    public void CastListItemPairMergesLikeAPlainPair()
    {
        // The published SDK ships one Get-MgGroupOwnerAsUser covering both the cast on the
        // collection and the cast on the item; without pairing, both emit the same file.
        var list = Resolve("GET", "/groups/{group-id}/owners/graph.user");
        var item = Resolve("GET", "/groups/{group-id}/owners/{directoryObject-id}/graph.user");
        Assert.Equal(list.Noun, item.Noun);
        Assert.True(Naming.IsListItemPair(list, item));

        // Different cast types never pair.
        var otherCast = Resolve("GET", "/groups/{group-id}/owners/{directoryObject-id}/graph.servicePrincipal");
        Assert.False(Naming.IsListItemPair(list, otherCast));
    }

    [Fact]
    public void SelfReferentialSitesRenameInsteadOfCollidingWithParent()
    {
        // Without the SubSite rename, /sites/{id}/sites singularizes to the parent's own noun
        // and its cmdlet file would collide with Get-MgSite's. The renamed nouns are pinned in
        // ResolvesPublishedSdkNames; this pins that the pair no longer merges or collides.
        var list = Resolve("GET", "/sites/{site-id}/sites");
        var item = Resolve("GET", "/sites/{site-id}");
        Assert.NotEqual(list.Noun, item.Noun);
        Assert.False(Naming.IsListItemPair(list, item));
    }
}
