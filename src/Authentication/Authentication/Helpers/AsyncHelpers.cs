/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Threading;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class AsyncHelpers
    {
        /// <summary>
        ///     An instance of the Dummy IDisposable.
        /// </summary>
        /// <returns></returns>
        internal static IDisposable Dummy = new DummyDisposable();

        /// <summary>
        ///     An IDisposable that does absolutely nothing.
        /// </summary>
        internal class DummyDisposable : IDisposable
        {
            public void Dispose()
            {
            }
        }

        /// <summary>
        ///     An IDisposable that saves the SynchronizationContext,sets it to <c>null</c> and
        ///     restores it to the original upon <c>Dispose()</c>.
        ///     NOTE: This is designed to be less invasive than using <c>.ConfigureAwait(false)</c>
        ///     on every single <c>await</c> in library code (ie, places where we know we don't need
        ///     to continue in the same context as we went async)
        /// </summary>
        internal class NoSyncContext : IDisposable
        {
            private readonly SynchronizationContext _original = SynchronizationContext.Current;

            internal NoSyncContext()
            {
                SynchronizationContext.SetSynchronizationContext(null);
            }

            public void Dispose()
            {
                SynchronizationContext.SetSynchronizationContext(_original);
            }
        }

        /// <summary>
        ///     Sets the Synchronization Context to null, and returns an IDisposable that when disposed,
        ///     will restore the synchronization context to the original value.
        ///     This is used a less-invasive means to ensure that code in the library that doesn't
        ///     need to be continued in the original context doesn't have to have <c>ConfigureAwait(false)</c>
        ///     on every single <c>await</c>
        ///     If the <c>SynchronizationContext</c> is <c>null</c> when this is used, the resulting IDisposable
        ///     will not do anything (this prevents excessive re-setting of the <c>SynchronizationContext</c>)
        ///     <example>
        ///         Usage:
        ///         <code>
        /// using(NoSynchronizationContext) {
        ///     await SomeAsyncOperation();
        ///     await SomeOtherOperation();
        /// }
        /// </code>
        ///     </example>
        /// </summary>
        /// <returns>An IDisposable that will return the SynchronizationContext to original state</returns>
        internal static IDisposable NoSynchronizationContext =>
            SynchronizationContext.Current == null ? Dummy : new NoSyncContext();
    }
}