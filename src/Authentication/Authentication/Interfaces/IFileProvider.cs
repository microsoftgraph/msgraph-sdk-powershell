// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.IO;

namespace Microsoft.Graph.PowerShell.Authentication.Interfaces
{
    public interface IFileProvider : IDisposable
    {
        string FilePath { get; }
        Stream Stream { get; }
        StreamReader CreateReader();
        StreamWriter CreateWriter();
    }
}
