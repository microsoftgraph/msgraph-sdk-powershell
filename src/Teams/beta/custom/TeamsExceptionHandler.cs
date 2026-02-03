namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using Microsoft.Graph.Beta.PowerShell.Runtime;
    using System;

    /// <summary>
    /// Exception handler for Teams.
    /// </summary>
    internal class TeamsExceptionHandler
    {
        /// <summary>
        /// Handle exceptions for teams workload.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <param name="targetObject">The target object.</param>
        /// <param name="errorLogger">The error logger.</param>
        /// <param name="eventListener">The event listener.</param>
        internal static void HandleException(
            Exception ex,
            object targetObject,
            Action<System.Management.Automation.ErrorRecord> errorLogger,
            Runtime.IEventListener eventListener)
        {
            if (ex is MGTeamsInternalServiceRequestException)
            {
                TeamsExceptionHandler.HandleTeamsInternalServiceRequestException(
                    ex as MGTeamsInternalServiceRequestException,
                    targetObject,
                    errorLogger);
            }
            else if (ex is MGTeamsInternalException)
            {
                TeamsExceptionHandler.HandleTeamsInternalException(
                    ex as MGTeamsInternalException,
                    targetObject,
                    errorLogger);
            }
            else
            {
                TeamsExceptionHandler.HandleGenericException(
                    ex,
                    targetObject,
                    errorLogger,
                    eventListener);
            }
        }

        /// <summary>
        /// Handle Teams Internal Service Request Exception.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <param name="targetObject">The target object.</param>
        /// <param name="errorLogger">The error logger.</param>
        private static void HandleTeamsInternalServiceRequestException(
            MGTeamsInternalServiceRequestException ex,
            object targetObject,
            Action<System.Management.Automation.ErrorRecord> errorLogger)
        {
            string code = ex.ODataError.Error?.Code;
            string message = ex.ODataError.Error?.Message;
            errorLogger(new global::System.Management.Automation.ErrorRecord(
                new global::System.Exception($"[{code}] : {message}"),
                code,
                global::System.Management.Automation.ErrorCategory.InvalidOperation,
                targetObject)
            {
                ErrorDetails = new global::System.Management.Automation.ErrorDetails(message)
            });
        }

        /// <summary>
        /// Handle Teams internal exception
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <param name="targetObject">The target object.</param>
        /// <param name="errorLogger">The error logger.</param>
        private static void HandleTeamsInternalException(
            MGTeamsInternalException ex,
            object targetObject,
            Action<System.Management.Automation.ErrorRecord> errorLogger)
        {
            errorLogger(new global::System.Management.Automation.ErrorRecord(
                ex,
                ex.ErrorType.ToString(),
                global::System.Management.Automation.ErrorCategory.InvalidOperation,
                targetObject)
            {
                ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message)
            });
        }

        /// <summary>
        /// Handle generic exception.
        /// </summary>
        /// <param name="ex">Exception.</param>
        /// <param name="targetObject">The target object.</param>
        /// <param name="errorLogger">The error logger.</param>
        /// <param name="eventListener">The event listener.</param>
        private static void HandleGenericException(
            Exception ex,
            object targetObject,
            Action<System.Management.Automation.ErrorRecord> errorLogger,
            Runtime.IEventListener eventListener)
        {
            string stackMessage = $"Ran into error: '{ex.StackTrace}'";

            // Log verbose.
            eventListener.Signal(
                Microsoft.Graph.Beta.PowerShell.Runtime.Events.Verbose,
                () => new Microsoft.Graph.Beta.PowerShell.Runtime.EventData
                {
                    Message = stackMessage,
                });

            UndeclaredResponseException undeclaredResponseException = ex as UndeclaredResponseException;
            if (undeclaredResponseException != null)
            {
                errorLogger(new System.Management.Automation.ErrorRecord(
                    undeclaredResponseException,
                    undeclaredResponseException.StatusCode.ToString(),
                    System.Management.Automation.ErrorCategory.InvalidOperation,
                    targetObject)
                {
                    ErrorDetails = new global::System.Management.Automation.ErrorDetails(undeclaredResponseException.Message)
                    {
                        RecommendedAction = undeclaredResponseException.Action
                    }
                });
            }
            else
            {
                errorLogger(new global::System.Management.Automation.ErrorRecord(
                    ex,
                    string.Empty,
                    global::System.Management.Automation.ErrorCategory.NotSpecified,
                    null));
            }
        }
    }
}
