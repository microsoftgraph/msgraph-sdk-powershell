using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> MailCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/mailfolders/{}/messages/{}/$value", PathMatch.Exact, Value: null,
            Reason: "Mail.md directive 1: omit Get-MgUserMailFolderMessageContent; retain other content routes and methods"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/messages/{}/replyall", PathMatch.Exact, "ReplyAllUserMessage",
            Reason: "Mail.md directive 2: Invoke-MgReplyAllUserMessage"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/mailfolders/{}/messages/{}/replyall", PathMatch.Exact, "ReplyAllUserMailFolderMessage",
            Reason: "Mail.md directive 2: Invoke-MgReplyAllUserMailFolderMessage"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/mailfolders/{}/childfolders/{}/messages/{}/replyall", PathMatch.Exact, "ReplyAllUserMailFolderChildFolderMessage",
            Reason: "Mail.md directive 2: Invoke-MgReplyAllUserMailFolderChildFolderMessage"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/messages/{}/createreplyall", PathMatch.Exact, "UserMessageReplyAll",
            Reason: "Mail.md directive 3: New-MgUserMessageReplyAll"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/users/{}/messages/{}/createreplyall", PathMatch.Exact, "New",
            Reason: "Mail.md directive 3: createReplyAll creates a reply draft"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/mailfolders/{}/messages/{}/createreplyall", PathMatch.Exact, "UserMailFolderMessageReplyAll",
            Reason: "Mail.md directive 3: New-MgUserMailFolderMessageReplyAll"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/users/{}/mailfolders/{}/messages/{}/createreplyall", PathMatch.Exact, "New",
            Reason: "Mail.md directive 3: createReplyAll creates a reply draft"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/mailfolders/{}/childfolders/{}/messages/{}/createreplyall", PathMatch.Exact, "UserMailFolderChildFolderMessageReplyAll",
            Reason: "Mail.md directive 3: New-MgUserMailFolderChildFolderMessageReplyAll"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/users/{}/mailfolders/{}/childfolders/{}/messages/{}/createreplyall", PathMatch.Exact, "New",
            Reason: "Mail.md directive 3: createReplyAll creates a reply draft"),
        new(OverrideKind.SuppressOperation, Method: null, "/replies/{}/replyto", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: the replyTo nav ships nothing under any root"),
    ];
}
