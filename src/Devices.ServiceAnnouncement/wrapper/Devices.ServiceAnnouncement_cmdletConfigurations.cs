using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private const string ServiceAnnouncementSuppression =
        "Devices.ServiceAnnouncement.md directive 1: complete legacy/current selector equality reviewed by method and normalized path; see Devices.ServiceAnnouncement_directiveMigrationMap.json";

    private static readonly List<Entry> DevicesServiceAnnouncementCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, null, "/admin/serviceannouncement", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/admin/serviceannouncement/healthoverviews", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/admin/serviceannouncement/healthoverviews/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/admin/serviceannouncement/healthoverviews/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/admin/serviceannouncement/healthoverviews/{}/issues", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/admin/serviceannouncement/healthoverviews/{}/issues/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/admin/serviceannouncement/healthoverviews/{}/issues/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/admin/serviceannouncement/issues", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/admin/serviceannouncement/issues/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/admin/serviceannouncement/issues/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/admin/serviceannouncement/messages", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/admin/serviceannouncement/messages/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/admin/serviceannouncement/messages/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/admin/serviceannouncement/messages/{}/attachments", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/admin/serviceannouncement/messages/{}/attachments/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/admin/serviceannouncement/messages/{}/attachments/{}", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Put, "/admin/serviceannouncement/messages/{}/attachments/{}/content", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/admin/serviceannouncement/messages/{}/attachments/{}/content", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Put, "/admin/serviceannouncement/messages/{}/attachmentsarchive", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/admin/serviceannouncement/messages/{}/attachmentsarchive", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/{}/checkmembergroups", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/{}/checkmemberobjects", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/{}/getmembergroups", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/{}/getmemberobjects", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/{}/restore", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/administrativeunits/delta", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/getbyids", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/getuserownedobjects", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/administrativeunits/validateproperties", PathMatch.Exact, null, ServiceAnnouncementSuppression),
        // Derived v1.0 names remain authoritative; this also covers beta and structural naming.
        new(OverrideKind.StripNounPrefix, null, "/admin/serviceannouncement/", PathMatch.Prefix, "Admin",
            "Devices.ServiceAnnouncement.md directive 2: replace AdminServiceAnnouncement with ServiceAnnouncement"),
    ];
}
