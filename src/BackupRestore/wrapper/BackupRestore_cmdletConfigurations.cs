using System.Collections.Generic;
namespace WrapperGenerator;
public static partial class CmdletConfigurator
{
    // BackupRestore.md records the absent shared legacy source. Keep this empty:
    // structural Solution naming and existing derived parity require no new overrides.
    private static readonly List<Entry> BackupRestoreCmdletConfigurations = [];
}
