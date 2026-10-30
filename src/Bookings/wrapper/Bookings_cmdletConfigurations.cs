using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> BookingsCmdletConfigurations =
    [
        // Retired 2024-04-30: https://devblogs.microsoft.com/microsoft365dev/breaking-changes-in-microsoft-bookings-graph-apis-beta/
        // Suppress cmdlets only; keep the source/client routes and supported /solutions successors.
        new(OverrideKind.SuppressOperation, Method: null, "/bookingbusinesses", Match: PathMatch.Exact, Value: null,
            Reason: "Retired root-level Bookings API; use /solutions/bookingBusinesses"),
        new(OverrideKind.SuppressOperation, Method: null, "/bookingbusinesses/", Match: PathMatch.Prefix, Value: null,
            Reason: "Retired root-level Bookings API descendants; use /solutions/bookingBusinesses"),
        new(OverrideKind.SuppressOperation, Method: null, "/bookingcurrencies", Match: PathMatch.Exact, Value: null,
            Reason: "Retired root-level Bookings API; use /solutions/bookingCurrencies"),
        new(OverrideKind.SuppressOperation, Method: null, "/bookingcurrencies/", Match: PathMatch.Prefix, Value: null,
            Reason: "Retired root-level Bookings API descendants; use /solutions/bookingCurrencies"),

        // Bookings.md's original selector matches GET/PATCH /solutions in both legacy specs.
        // The current compatible refresh preserves those original IDs. The adjacent ledger
        // pins both source identities. Suppress only the exact root.
        new(OverrideKind.SuppressOperation, Method: null, "/solutions", Match: PathMatch.Exact, Value: null,
            Reason: "Bookings.md ^solution\\.solutionsRoot.*$; reviewed GET/PATCH /solutions in both historical and compatible specs"),

        // Most nouns under /solutions/ drop the "Solution" prefix (for example
        // Get-MgBookingBusiness, Get-MgVirtualEventWebinar). BackupRestore is a known
        // exception where published cmdlets keep the Solution prefix.
        // Bookings_directiveMigrationMap.json reviews the shared SubjectRename coverage;
        // BookingsDirectiveMigrationTests pins both profiles and the BackupRestore exception.
        new(OverrideKind.StripNounPrefix, Method: null, "/solutions/", Match: PathMatch.Prefix, Value: "Solution",
            Reason: "Bookings/VirtualEvents naming pattern under /solutions/*; BackupRestore is explicitly excluded in ApplyNounOverrides"),

        new(OverrideKind.SuppressOperation, Method: null, "/solutions/virtualevents", Match: PathMatch.Exact, Value: null,
            Reason: "Bookings.md shared VirtualEvent Get/Delete/Update variants; exact root only, children remain active"),
    ];
}
