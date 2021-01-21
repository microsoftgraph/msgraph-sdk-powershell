/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal class CustomAsyncCommandRuntime : ICommandRuntime2, IDisposable
    {
        private readonly ICommandRuntime2 _originalCommandRuntime;
        private readonly Thread _originalThread;

        private PSCmdlet _cmdlet;
        private ManualResetEventSlim _completed = new ManualResetEventSlim(false);
        private ManualResetEventSlim _readyToRun = new ManualResetEventSlim(false);

        private Action _runOnMainThread;
        private SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public CancellationToken CancellationToken;

        internal CustomAsyncCommandRuntime(PSCmdlet cmdlet, CancellationToken cancellationToken)
        {
            _originalCommandRuntime = cmdlet.CommandRuntime as ICommandRuntime2;
            _originalThread = Thread.CurrentThread;
            CancellationToken = cancellationToken;
            _cmdlet = cmdlet;
            cmdlet.CommandRuntime = this;
        }

        public bool AllowInteractive { get; set; } = false;

        public PSHost Host => _originalCommandRuntime.Host;

        public PSTransactionContext CurrentPSTransaction => _originalCommandRuntime.CurrentPSTransaction;

        public bool ShouldContinue(string query, string caption, bool hasSecurityImpact, ref bool yesToAll,
            ref bool noToAll)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.ShouldContinue(query, caption, hasSecurityImpact, ref yesToAll,
                    ref noToAll);
            }

            CheckForInteractive();

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var yta = yesToAll;
                var nta = noToAll;
                var result = false;

                // set the function to run
                _runOnMainThread = () =>
                    result = _originalCommandRuntime.ShouldContinue(query, caption, hasSecurityImpact, ref yta,
                        ref nta);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                yesToAll = yta;
                noToAll = nta;
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public bool ShouldContinue(string query, string caption)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.ShouldContinue(query, caption);
            }

            CheckForInteractive();

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var result = false;

                // set the function to run
                _runOnMainThread = () => result = _originalCommandRuntime.ShouldContinue(query, caption);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public bool ShouldContinue(string query, string caption, ref bool yesToAll, ref bool noToAll)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.ShouldContinue(query, caption, ref yesToAll, ref noToAll);
            }

            CheckForInteractive();

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var yta = yesToAll;
                var nta = noToAll;
                var result = false;

                // set the function to run
                _runOnMainThread = () =>
                    result = _originalCommandRuntime.ShouldContinue(query, caption, ref yta, ref nta);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                yesToAll = yta;
                noToAll = nta;
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public bool ShouldProcess(string target)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.ShouldProcess(target);
            }

            CheckForInteractive();

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var result = false;

                // set the function to run
                _runOnMainThread = () => result = _originalCommandRuntime.ShouldProcess(target);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public bool ShouldProcess(string target, string action)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.ShouldProcess(target, action);
            }

            CheckForInteractive();

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var result = false;

                // set the function to run
                _runOnMainThread = () => result = _originalCommandRuntime.ShouldProcess(target, action);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public bool ShouldProcess(string verboseDescription, string verboseWarning, string caption)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.ShouldProcess(verboseDescription, verboseWarning, caption);
            }

            CheckForInteractive();

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var result = false;

                // set the function to run
                _runOnMainThread = () =>
                    result = _originalCommandRuntime.ShouldProcess(verboseDescription, verboseWarning, caption);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public bool ShouldProcess(string verboseDescription, string verboseWarning, string caption,
            out ShouldProcessReason shouldProcessReason)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.ShouldProcess(verboseDescription, verboseWarning, caption,
                    out shouldProcessReason);
            }

            CheckForInteractive();

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var result = false;
                var reason = ShouldProcessReason.None;

                // set the function to run
                _runOnMainThread = () =>
                    result = _originalCommandRuntime.ShouldProcess(verboseDescription, verboseWarning, caption,
                        out reason);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                shouldProcessReason = reason;
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void ThrowTerminatingError(ErrorRecord errorRecord)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.ThrowTerminatingError(errorRecord);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.ThrowTerminatingError(errorRecord);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public bool TransactionAvailable()
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return _originalCommandRuntime.TransactionAvailable();
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                var result = false;

                // set the function to run
                _runOnMainThread = () => result = _originalCommandRuntime.TransactionAvailable();

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // set the output variables
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteCommandDetail(string text)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteCommandDetail(text);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteCommandDetail(text);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteDebug(string text)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteDebug(text);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteDebug(text);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteError(ErrorRecord errorRecord)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteError(errorRecord);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteError(errorRecord);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteInformation(InformationRecord informationRecord)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteInformation(informationRecord);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteInformation(informationRecord);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteObject(object sendToPipeline)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteObject(sendToPipeline);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteObject(sendToPipeline);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteObject(sendToPipeline, enumerateCollection);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteObject(sendToPipeline, enumerateCollection);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteProgress(ProgressRecord progressRecord)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteProgress(progressRecord);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteProgress(progressRecord);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteProgress(long sourceId, ProgressRecord progressRecord)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteProgress(sourceId, progressRecord);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteProgress(sourceId, progressRecord);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteVerbose(string text)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteVerbose(text);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteVerbose(text);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void WriteWarning(string text)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                _originalCommandRuntime.WriteWarning(text);
                return;
            }

            // otherwise, queue up the request and wait for the main thread to do the right thing. 
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();

                // set the function to run
                _runOnMainThread = () => _originalCommandRuntime.WriteWarning(text);

                // tell the main thread to go ahead
                _readyToRun.Set();

                // wait for the result (or cancellation!)
                WaitForCompletion();

                // return
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }

        public void Dispose()
        {
            if (_cmdlet != null)
            {
                _cmdlet.CommandRuntime = _originalCommandRuntime;
                _cmdlet = null;
            }

            _semaphore?.Dispose();
            _semaphore = null;
            _readyToRun?.Dispose();
            _readyToRun = null;
            _completed?.Dispose();
            _completed = null;
        }

        private void CheckForInteractive()
        {
            // This is an interactive call -- if we are not on the original thread, this will only work if this was done at ACR creation time;
            if (!AllowInteractive)
            {
                throw new Exception("AsyncCommandRuntime is not configured for interactive calls");
            }
        }

        private void WaitOurTurn()
        {
            // wait for our turn to play
            _semaphore?.Wait(CancellationToken);

            // ensure that completed is not set
            _completed.Reset();
        }

        private void WaitForCompletion()
        {
            // wait for the result (or cancellation!)
            WaitHandle.WaitAny(new[] {CancellationToken.WaitHandle, _completed?.WaitHandle});

            // let go of the semaphore
            _semaphore?.Release();
        }

        public void Wait(Task ProcessRecordAsyncTask, CancellationToken cancellationToken)
        {
            do
            {
                WaitHandle.WaitAny(new[]
                    {_readyToRun.WaitHandle, ((IAsyncResult) ProcessRecordAsyncTask).AsyncWaitHandle});
                if (_readyToRun.IsSet)
                {
                    // reset the request for the next time
                    _readyToRun.Reset();

                    // run the delegate on this thread
                    _runOnMainThread();

                    // tell the originator everything is complete
                    _completed.Set();
                }
            } while (!ProcessRecordAsyncTask.IsCompleted);

            if (ProcessRecordAsyncTask.IsFaulted)
            {
                // don't unwrap a Aggregate Exception -- we'll lose the stack trace of the actual exception.
                // if(  ProcessRecordAsyncTask.Exception is System.AggregateException aggregate ) {
                //   throw aggregate.InnerException;
                // }
                throw ProcessRecordAsyncTask.Exception;
            }
        }

        public T ExecuteSync<T>(Func<T> step)
        {
            // if we are on the original thread, just call straight thru.
            if (_originalThread == Thread.CurrentThread)
            {
                return step();
            }

            var result = default(T);
            try
            {
                // wait for our turn to talk to the main thread
                WaitOurTurn();
                // set the function to run
                _runOnMainThread = () => { result = step(); };
                // tell the main thread to go ahead
                _readyToRun.Set();
                // wait for the result (or cancellation!)
                WaitForCompletion();
                // return
                return result;
            }
            catch (OperationCanceledException exception)
            {
                // maybe don't even worry?
                throw exception;
            }
        }
    }
}