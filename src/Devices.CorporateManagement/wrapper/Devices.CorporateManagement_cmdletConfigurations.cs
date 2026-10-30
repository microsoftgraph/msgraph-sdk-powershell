using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> DevicesCorporateManagementCmdletConfigurations =
        CreateDevicesCorporateManagementCmdletConfigurations();

    private static List<Entry> CreateDevicesCorporateManagementCmdletConfigurations()
    {
        List<Entry> entries =
        [
            new(OverrideKind.SuppressOperation, Method: null, "/deviceappmanagement/mobileapps/{}/categories", Match: PathMatch.Prefix, Value: null,
                Reason: "oracle: nested app categories ship nothing; the set ships top-level (mobileAppCategories)"),

            new(OverrideKind.SuppressOperation, HttpMethod.Get, "/deviceappmanagement/wdacsupplementalpolicies/{}/devicestatuses/{}/policy",
                PathMatch.Exact, Value: null,
                "Devices.CorporateManagement.md legacy wdacSupplementalPolicy.deviceStatus_GetPolicy selector"),
            new(OverrideKind.SuppressOperation, HttpMethod.Get, "/deviceappmanagement/wdacsupplementalpolicies/{}/devicestatuses/$count",
                PathMatch.Exact, Value: null,
                "Devices.CorporateManagement.md legacy wdacSupplementalPolicy.deviceStatus_GetCount selector"),

            new(OverrideKind.ReplaceNoun, Method: null, "/deviceappmanagement/deviceappmanagementtasks",
                PathMatch.Exact, "DeviceAppManagementTask",
                "Devices.CorporateManagement.md collapses repeated DeviceAppManagement prefixes"),
            new(OverrideKind.ReplaceNoun, Method: null, "/deviceappmanagement/deviceappmanagementtasks/{}",
                PathMatch.Exact, "DeviceAppManagementTask",
                "Devices.CorporateManagement.md collapses repeated DeviceAppManagement prefixes"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/deviceappmanagement/deviceappmanagementtasks/$count",
                PathMatch.Exact, "DeviceAppManagementTaskCount",
                "Devices.CorporateManagement.md collapses repeated DeviceAppManagement prefixes"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/deviceappmanagement/deviceappmanagementtasks/{}/updatestatus",
                PathMatch.Exact, "DeviceAppManagementTaskUpdateStatus",
                "Devices.CorporateManagement.md collapses repeated DeviceAppManagement prefixes"),

            // Shared directives 3 and 4 are already covered by v1.0 parity data, but beta
            // has no derived table. Exact curated fallbacks also work with collision data off.
            new(OverrideKind.ReplaceNoun, HttpMethod.Patch, "/deviceappmanagement/mobileapprelationships/{}",
                PathMatch.Exact, "DeviceAppManagementMultipleMobileAppRelationship",
                "Devices.CorporateManagement.md renames the relationship Update variants"),
            new(OverrideKind.ReplaceNoun, Method: null, "/users/{}/manageddevices/{}/logcollectionrequests",
                PathMatch.Exact, "UserManagedDeviceLogCollectionResponse",
                "Devices.CorporateManagement.md renames UserManagedDeviceLogCollectionRequest"),
            new(OverrideKind.ReplaceNoun, Method: null, "/users/{}/manageddevices/{}/logcollectionrequests/{}",
                PathMatch.Exact, "UserManagedDeviceLogCollectionResponse",
                "Devices.CorporateManagement.md renames UserManagedDeviceLogCollectionRequest"),

            // Update1 is the beta action, not the neighboring policySet PATCH.
            new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/deviceappmanagement/policysets/{}/update",
                PathMatch.Exact, "DeviceAppManagementMultiplePolicySet",
                "Devices.CorporateManagement.md renames policySet Update1 action variants"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/deviceappmanagement/policysets/{}/update",
                PathMatch.Exact, "Update",
                "Preserve the shared policySet Update1 action's published verb"),

            GroupVariants(new OperationVariantGroup(
            [
                new("GET", "/deviceAppManagement/managedEBookCategories", "Root"),
                new("GET", "/deviceAppManagement/managedEBookCategories/{managedEBookCategory-id}", "Root"),
                new("GET", "/deviceAppManagement/managedEBooks/{managedEBook-id}/categories", "EBook"),
                new("GET", "/deviceAppManagement/managedEBooks/{managedEBook-id}/categories/{managedEBookCategory-id}", "EBook"),
            ], DefaultFamily: "Root"),
                "The published managed eBook category GET exposes root and eBook-scoped variants distinguished by ManagedEBookId"),
            GroupVariants(new OperationVariantGroup(
            [
                new("GET", "/deviceAppManagement/managedEBookCategories/$count", "Root"),
                new("GET", "/deviceAppManagement/managedEBooks/{managedEBook-id}/categories/$count", "EBook"),
            ], DefaultFamily: "Root"),
                "Count the mobile eBook categories or the categories for one eBook using the existing ManagedEBookId"),

            // These nested routes exist only in beta, while the root routes also exist in
            // v1.0. A shared cross-path group would be incomplete in v1.0. The source calls
            // them "direct relationships for this app"; preserve both endpoints explicitly.
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/deviceappmanagement/mobileapps/{}/relationships",
                PathMatch.Exact, "DeviceAppManagementMobileAppDirectRelationship",
                "The source describes the nested navigation as the set of direct relationships for this app"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/deviceappmanagement/mobileapps/{}/relationships/{}",
                PathMatch.Exact, "DeviceAppManagementMobileAppDirectRelationship",
                "The source describes the nested navigation as the set of direct relationships for this app"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/deviceappmanagement/mobileapps/{}/relationships/$count",
                PathMatch.Exact, "DeviceAppManagementMobileAppDirectRelationshipCount",
                "Count direct relationships for the app without colliding with the root mobileAppRelationships count"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/deviceappmanagement/mobileapps/{}/relationships",
                PathMatch.Exact, "DeviceAppManagementMobileAppDirectRelationship",
                "Create a member of the source's direct relationships for this app navigation"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/deviceappmanagement/mobileapps/{}/relationships/{}",
                PathMatch.Exact, "DeviceAppManagementMobileAppDirectRelationship",
                "Remove a member of the source's direct relationships for this app navigation"),
        ];

        // The shared iOS spelling rule needs exact route fallbacks for beta and for
        // graph-qualified casts not keyed by the older v1.0 parity table.
        AddIosRoutes("/deviceappmanagement/iosmanagedappprotections", "DeviceAppManagementiOSManagedAppProtection",
        [
            ("", ""), ("/{}", ""), ("/$count", "Count"),
            ("/{}/apps", "App"), ("/{}/apps/{}", "App"), ("/{}/apps/$count", "AppCount"),
            ("/{}/assignments", "Assignment"), ("/{}/assignments/{}", "Assignment"),
            ("/{}/assignments/$count", "AssignmentCount"), ("/{}/deploymentsummary", "DeploymentSummary"),
            ("/haspayloadlinks", "HasPayloadLink"),
        ]);
        AddIosRoutes("/deviceappmanagement/ioslobappprovisioningconfigurations", "DeviceAppManagementiOSLobAppProvisioningConfiguration",
        [
            ("", ""), ("/{}", ""), ("/$count", "Count"), ("/{}/assign", "Assign"),
            ("/{}/assignments", "Assignment"), ("/{}/assignments/{}", "Assignment"),
            ("/{}/assignments/$count", "AssignmentCount"),
            ("/{}/devicestatuses", "DeviceStatus"), ("/{}/devicestatuses/{}", "DeviceStatus"),
            ("/{}/devicestatuses/$count", "DeviceStatusCount"),
            ("/{}/groupassignments", "GroupAssignment"), ("/{}/groupassignments/{}", "GroupAssignment"),
            ("/{}/groupassignments/$count", "GroupAssignmentCount"),
            ("/{}/userstatuses", "UserStatus"), ("/{}/userstatuses/{}", "UserStatus"),
            ("/{}/userstatuses/$count", "UserStatusCount"), ("/haspayloadlinks", "HasPayloadLink"),
        ]);
        foreach (var (cast, noun) in new[]
        {
            ("ioslobapp", "iOSLobApp"),
            ("managedioslobapp", "ManagediOSLobApp"),
        })
        {
            AddIosRoutes($"/deviceappmanagement/mobileapps/graph.{cast}", "DeviceAppManagementMobileApp",
            [
                ("", $"As{noun}"), ("/$count", $"CountAs{noun}"),
            ]);
            AddIosRoutes($"/deviceappmanagement/mobileapps/{{}}/graph.{cast}", $"DeviceAppManagementMobileAppAs{noun}",
            [
                ("", ""),
                ("/assignments", "Assignment"), ("/assignments/{}", "Assignment"),
                ("/assignments/$count", "AssignmentCount"),
                ("/categories", "Category"), ("/categories/{}", "Category"), ("/categories/$count", "CategoryCount"),
                ("/contentversions", "ContentVersion"), ("/contentversions/{}", "ContentVersion"),
                ("/contentversions/$count", "ContentVersionCount"),
                ("/contentversions/{}/containedapps", "ContentVersionContainedApp"),
                ("/contentversions/{}/containedapps/{}", "ContentVersionContainedApp"),
                ("/contentversions/{}/containedapps/$count", "ContentVersionContainedAppCount"),
                ("/contentversions/{}/files", "ContentVersionFile"),
                ("/contentversions/{}/files/{}", "ContentVersionFile"),
                ("/contentversions/{}/files/$count", "ContentVersionFileCount"),
                ("/contentversions/{}/files/{}/commit", "ContentVersionFileCommit"),
                ("/contentversions/{}/files/{}/renewupload", "ContentVersionFileRenewUpload"),
                ("/contentversions/{}/scripts", "ContentVersionScript"),
                ("/contentversions/{}/scripts/{}", "ContentVersionScript"),
                ("/contentversions/{}/scripts/$count", "ContentVersionScriptCount"),
                ("/relationships", "Relationship"), ("/relationships/{}", "Relationship"),
                ("/relationships/$count", "RelationshipCount"),
            ]);
        }
        return entries;

        void AddIosRoutes(string root, string noun, (string Path, string Noun)[] routes)
        {
            foreach (var route in routes)
                entries.Add(new(OverrideKind.ReplaceNoun, Method: null, root + route.Path,
                    PathMatch.Exact, noun + route.Noun,
                    "Devices.CorporateManagement.md preserves iOS spelling in Io(Lob|Managed) subjects"));
        }
    }
}
