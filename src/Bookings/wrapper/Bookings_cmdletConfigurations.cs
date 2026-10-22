using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> BookingsCmdletConfigurations =
    [
        // Retain the existing /solutions compatibility suppression. Bookings.md's literal
        // ^solution\.solutionsRoot.*$ matches neither compatible spec: both use plural
        // solutions.solutionsRoot IDs. The adjacent migration ledger records that absence
        // separately from the actual root operations; children remain unaffected.
        new(OverrideKind.SuppressOperation, Method: null, "/solutions", Match: PathMatch.Exact, Value: null,
            Reason: "Retained /solutions compatibility suppression; literal Bookings.md ^solution\\.solutionsRoot.*$ selector is absent in compatible specs"),

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
