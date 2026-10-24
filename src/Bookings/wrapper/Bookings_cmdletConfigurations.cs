using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> BookingsCmdletConfigurations =
    [
        // Bookings.md's original selector matches GET/PATCH /solutions in both legacy specs.
        // The adjacent ledger bridges those singular/underscore IDs to the compatible
        // plural/dotted solutions.solutionsRoot IDs. Suppress only the exact root.
        new(OverrideKind.SuppressOperation, Method: null, "/solutions", Match: PathMatch.Exact, Value: null,
            Reason: "Bookings.md ^solution\\.solutionsRoot.*$; reviewed exact legacy-to-compatible GET/PATCH /solutions bridges"),

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
