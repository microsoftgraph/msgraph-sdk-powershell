// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Extensions;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using Microsoft.Graph.PowerShell.Authentication.Properties;
using Microsoft.PowerShell.Commands;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.Graph.PowerShell.Authentication.Helpers.AsyncHelpers;
using DriveNotFoundException = System.Management.Automation.DriveNotFoundException;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsLifecycle.Invoke, "MgGraphRequest", DefaultParameterSetName = Constants.UserParameterSet, HelpUri = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/invoke-mggraphrequest")]
    [Alias("Invoke-GraphRequest", "Invoke-MgRestMethod")]
    public class InvokeMgGraphRequest : PSCmdlet
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private RequestUserAgent _graphRequestUserAgent;
        private IGraphEnvironment _originalEnvironment;
        private string _originalFilePath;

        /// <summary>
        ///     Http Method
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 1,
            HelpMessage = "HTTP Method")]
        public GraphRequestMethod Method { get; set; } = GraphRequestMethod.GET;

        /// <summary>
        ///     Uri to call using the Graph HttpClient can be segments such as /beta/me
        ///     or fully qualified url such as https://graph.microsoft.com/beta/me
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 2,
            Mandatory = true,
            HelpMessage =
                "Uri to call can be segments such as /beta/me or fully qualified https://graph.microsoft.com/beta/me")]
        public Uri Uri { get; set; }

        /// <summary>
        ///     Optional HTTP Body
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 3,
            HelpMessage = "Request Body. Required when Method is Post or Patch",
            ValueFromPipeline = true)]
        public object Body { get; set; }

        /// <summary>
        ///     Optional Custom Headers
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 4,
            HelpMessage = "Optional Custom Headers")]
        public IDictionary Headers { get; set; }

        /// <summary>
        ///     Relative or absolute path where the response body will be saved.
        ///     Not allowed when InferOutputFileName is specified.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 5,
            HelpMessage = "Output file where the response body will be saved")]
        public string OutputFilePath { get; set; }

        /// <summary>
        ///     Infer Download FileName from ContentDisposition Header.
        ///     Not allowed when OutputFilePath is specified.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 6,
            HelpMessage = "Infer output filename")]
        public SwitchParameter InferOutputFileName { get; set; }

        /// <summary>
        ///     Gets or sets the InputFilePath property to send in the request
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 7,
            HelpMessage = "Input file to send in the request")]
        public virtual string InputFilePath { get; set; }

        /// <summary>
        ///     Indicates that the cmdlet returns the results, in addition to writing them to a file.
        ///     only valid when the OutFile parameter is also used.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 8,
            HelpMessage =
                "Indicates that the cmdlet returns the results, in addition to writing them to a file. Only valid when the OutFile parameter is also used. ")]
        public SwitchParameter PassThru { get; set; }

        /// <summary>
        ///     Add headers to Request Header collection without validation
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 10,
            HelpMessage = "Add headers to Request Header collection without validation")]
        public SwitchParameter SkipHeaderValidation { get; set; }

        /// <summary>
        ///     Custom Content Type
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 11,
            HelpMessage = "Custom Content Type")]
        public virtual string ContentType { get; set; }

        /// <summary>
        ///     Specifies a web request session. Enter the variable name, including the dollar sign ($).
        ///     You can't use the SessionVariable and WebSession parameters in the same command.
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 13,
            HelpMessage = "Specifies a web request session. Enter the variable name, including the dollar sign ($)." +
                          "You can't use the SessionVariable and GraphRequestSession parameters in the same command.")]
        [Alias("SV")]
        public string SessionVariable { get; set; }

        /// <summary>
        ///     Response Headers Variable
        /// </summary>
        [Parameter(Mandatory = false,
            ParameterSetName = Constants.UserParameterSet,
            Position = 14,
            HelpMessage = "Response Headers Variable")]
        [Alias("RHV")]
        public string ResponseHeadersVariable { get; set; }

        /// <summary>
        ///     Response Status Code Variable
        /// </summary>
        [Parameter(Position = 15, ParameterSetName = Constants.UserParameterSet,
            Mandatory = false,
            HelpMessage = "Response Status Code Variable")]
        public string StatusCodeVariable { get; set; }

        /// <summary>
        ///     Gets or sets whether to skip checking HTTP status for error codes.
        /// </summary>
        [Parameter(Position = 16, ParameterSetName = Constants.UserParameterSet, Mandatory = false,
            HelpMessage = "Skip Checking HTTP Errors")]
        public virtual SwitchParameter SkipHttpErrorCheck { get; set; }

        /// <summary>
        ///     Gets or sets the Session property.
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 17,
            ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Custom Graph Request Session")]
        public GraphRequestSession GraphRequestSession { get; set; }

        /// <summary>
        ///     Custom User Specified User Agent
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 18,
            ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Custom User Specified User Agent")]
        public string UserAgent { get; set; }

        /// <summary>
        ///     OutputType to return to the caller, Defaults to HashTable
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 19,
            ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Output Type to return to the caller")]
        public OutputType OutputType { get; set; } = OutputType.HashTable;

        /// <summary>
        ///     Wait for .NET debugger to attach
        /// </summary>
        [Parameter(Mandatory = false,
            DontShow = true,
            HelpMessage = "Wait for .NET debugger to attach")]
        public SwitchParameter Break { get; set; }

        internal string QualifiedOutFile => QualifyFilePath(OutputFilePath);

        internal bool ShouldSaveToOutFile => !string.IsNullOrEmpty(OutputFilePath);

        /// <summary>
        ///     Only write to pipeline if outfile is not specified, inference is not specified but PassThru is set.
        /// </summary>
        internal bool ShouldWriteToPipeline => !ShouldSaveToOutFile && !InferOutputFileName || PassThru;

        internal bool ShouldCheckHttpStatus => !SkipHttpErrorCheck;

        /// <summary>
        ///     Only Set Default Content Type (application/json) for POST, PUT and PATCH requests, where its not specified via `-ContentType`.
        /// </summary>
        private bool ShouldSetDefaultContentType => Method == GraphRequestMethod.POST || Method == GraphRequestMethod.PUT || Method == GraphRequestMethod.PATCH;

        private static async Task<ErrorRecord> GenerateHttpErrorRecordAsync(
            HttpMessageFormatter httpResponseMessageFormatter,
            HttpRequestMessage httpRequestMessage)
        {
            using (NoSynchronizationContext)
            {
                // Load into buffer to avoid stream already consumed issues.
                await httpResponseMessageFormatter.LoadIntoBufferAsync();
                var currentResponse = httpResponseMessageFormatter.HttpResponseMessage;
                var errorMessage =
                    Resources.ResponseStatusCodeFailure.FormatCurrentCulture(currentResponse.StatusCode,
                        currentResponse.ReasonPhrase);
                var httpException = new HttpResponseException(errorMessage, currentResponse);
                var errorRecord = new ErrorRecord(httpException, ErrorConstants.Codes.InvokeGraphHttpResponseException,
                    ErrorCategory.InvalidOperation, httpRequestMessage);
                var detailMsg = await httpResponseMessageFormatter.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(detailMsg))
                {
                    errorRecord.ErrorDetails = new ErrorDetails(detailMsg);
                }

                return errorRecord;
            }
        }

        /// <summary>
        ///     When -Verbose is specified, print out response status
        /// </summary>
        /// <param name="requestMessageFormatter"></param>
        private async Task ReportRequestStatusAsync(HttpMessageFormatter requestMessageFormatter)
        {
            using (NoSynchronizationContext)
            {
                await requestMessageFormatter.LoadIntoBufferAsync();
                var requestMessage = requestMessageFormatter.HttpRequestMessage;
                var requestContentLength = requestMessage.Content?.Headers.ContentLength.Value ?? 0;
                var reqVerboseMsg = Resources.InvokeGraphRequestVerboseMessage.FormatCurrentCulture(
                    requestMessage.Method,
                    requestMessage.RequestUri,
                    requestContentLength);
                // If Verbose is specified, will print out Uri and Content Length
                WriteVerbose(reqVerboseMsg);
                var requestString = await requestMessageFormatter.ReadAsStringAsync();
                // If Debug is Specified, will print out the Http Request as a string
                WriteDebug(requestString);
            }
        }

        /// <summary>
        ///     When -Verbose is specified, print out response status
        /// </summary>
        /// <param name="responseMessageFormatter"></param>
        private async Task ReportResponseStatusASync(HttpMessageFormatter responseMessageFormatter)
        {
            using (NoSynchronizationContext)
            {
                await responseMessageFormatter.LoadIntoBufferAsync();
                var contentType = responseMessageFormatter.HttpResponseMessage.GetContentType();
                var respVerboseMsg = Resources.InvokeGraphResponseVerboseMessage.FormatCurrentCulture(
                    responseMessageFormatter.HttpResponseMessage.Content.Headers.ContentLength,
                    contentType);
                // If Verbose is specified, will print out Uri and Content Length
                WriteVerbose(respVerboseMsg);
                var responseString = await responseMessageFormatter.ReadAsStringAsync();
                // If Debug is Specified, will print out the Http Response as a string
                WriteDebug(responseString);
            }
        }

        /// <summary>
        ///     Compose a request, setting Uri and Headers.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        private HttpRequestMessage GetRequest(HttpClient httpClient, Uri uri)
        {

            var requestUri = PrepareUri(httpClient, uri);
            var httpMethod = GetHttpMethod(Method);
            // create the base WebRequest object
            var request = new HttpRequestMessage(httpMethod, requestUri);

            // pull in session data
            if (GraphRequestSession.Headers.Count > 0)
            {
                GraphRequestSession.ContentHeaders.Clear();
                foreach (var entry in GraphRequestSession.Headers)
                {
                    if (HttpKnownHeaderNames.ContentHeaders.Contains(entry.Key))
                    {
                        GraphRequestSession.ContentHeaders.Add(entry.Key, entry.Value);
                    }
                    else
                    {
                        if (SkipHeaderValidation)
                        {
                            request.Headers.TryAddWithoutValidation(entry.Key, entry.Value);
                        }
                        else
                        {
                            request.Headers.Add(entry.Key, entry.Value);
                        }
                    }
                }
            }

            // Set 'Transfer-Encoding: chunked' if 'Transfer-Encoding' is specified
            if (GraphRequestSession.Headers.ContainsKey(HttpKnownHeaderNames.TransferEncoding))
            {
                request.Headers.TransferEncodingChunked = true;
            }

            // Set 'User-Agent' if WebSession.Headers doesn't already contain it
            if (GraphRequestSession.Headers.TryGetValue(HttpKnownHeaderNames.UserAgent, out var userAgent))
            {
                GraphRequestSession.UserAgent = userAgent;
            }
            else
            {
                if (SkipHeaderValidation)
                {
                    request.Headers.TryAddWithoutValidation(HttpKnownHeaderNames.UserAgent,
                        GraphRequestSession.UserAgent);
                }
                else
                {
                    request.Headers.Add(HttpKnownHeaderNames.UserAgent, GraphRequestSession.UserAgent);
                }
            }
            return request;
        }

        /// <summary>
        ///     Compose Request Uri
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        private Uri PrepareUri(HttpClient httpClient, Uri uri)
        {
            UriBuilder uriBuilder;

            // For AbsoluteUri such as /beta/groups?$count=true, Get the scheme and host from httpClient
            // Then use them to compose a new Url with the URL fragment. 
            if (uri.IsAbsoluteUri)
            {
                _originalEnvironment = GraphSession.Instance.Environment;
                GraphSession.Instance.Environment = new GraphEnvironment
                {
                    Name = "MSGraphInvokeGraphRequest",
                    GraphEndpoint = Uri.GetBaseUrl()
                    // No need to set AAD endpoint since a token is provided.
                };
            }
            else
            {
                uriBuilder = new UriBuilder
                {
                    Scheme = httpClient.BaseAddress.Scheme,
                    Host = httpClient.BaseAddress.Host
                };
                uri = new Uri(uriBuilder.Uri, uri);
            }
            uriBuilder = new UriBuilder(uri);

            // before creating the web request,
            // preprocess Body if content is a dictionary and method is GET (set as query)
            if (Method == GraphRequestMethod.GET &&
                LanguagePrimitives.TryConvertTo(Body, out IDictionary bodyAsDictionary))
            {
                var bodyQueryParameters = bodyAsDictionary?.FormatDictionary();
                if (uriBuilder.Query != null && uriBuilder.Query.Length > 1 &&
                    !string.IsNullOrWhiteSpace(bodyQueryParameters))
                {
                    uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + bodyQueryParameters;
                }
                else if (!string.IsNullOrWhiteSpace(bodyQueryParameters))
                {
                    uriBuilder.Query = bodyQueryParameters;
                }

                // set body to null to prevent later FillRequestStream
                Body = null;
            }
            //Review fix made in https://github.com/microsoftgraph/msgraph-sdk-powershell/pull/2690
            return uriBuilder.Uri;
        }

        private void ThrowIfError(ErrorRecord error)
        {
            if (error != null)
            {
                ThrowTerminatingError(error);
            }
        }
        /// <summary>
        ///     Process Http Response
        /// </summary>
        /// <param name="response"></param>
        internal async Task ProcessResponseAsync(HttpResponseMessage response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));
            if (ShouldWriteToPipeline)
            {
                var returnType = response.CheckReturnType();
                switch (returnType)
                {
                    case RestReturnType.Json:
                        ErrorRecord error;
                        string responseString;
                        switch (OutputType)
                        {
                            case OutputType.HashTable:
                                responseString = await response.Content.ReadAsStringAsync();
                                var hashTable = responseString.ConvertFromJson(true, null, out error);
                                ThrowIfError(error);
                                WriteObject(hashTable);
                                break;
                            case OutputType.PSObject:
                                responseString = await response.Content.ReadAsStringAsync();
                                var psObject = responseString.ConvertFromJson(false, null, out error);
                                ThrowIfError(error);
                                WriteObject(psObject, true);
                                break;
                            case OutputType.HttpResponseMessage:
                                WriteObject(response);
                                break;
                            case OutputType.Json:
                                responseString = await response.Content.ReadAsStringAsync();
                                WriteObject(responseString);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(OutputType));
                        }
                        break;
                    case RestReturnType.PlainText:
                        responseString = await response.Content.ReadAsStringAsync();
                        WriteObject(responseString);
                        break;
                    case RestReturnType.OctetStream:
                        if (OutputType == OutputType.HttpResponseMessage)
                            WriteObject(response);
                        else
                            ThrowIfError(GetValidationError(Resources.NonJsonResponseWithoutInfer, ErrorConstants.Codes.InvokeGraphContentTypeException, returnType, response.Content.Headers.ContentDisposition));
                        break;
                    default:
                        if (OutputType == OutputType.HttpResponseMessage)
                            WriteObject(response);
                        else
                            ThrowIfError(GetValidationError(Resources.NonJsonResponseWithoutOutputFilePath, ErrorConstants.Codes.InvokeGraphContentTypeException, returnType));
                        break;
                }
            }
            if (ShouldSaveToOutFile)
            {
                response.GetResponseStream().SaveStreamToFile(QualifiedOutFile, this, _cancellationTokenSource.Token);
            }

            if (InferOutputFileName.IsPresent)
            {
                if (response.Content.Headers.ContentDisposition != null)
                {
                    if (!string.IsNullOrWhiteSpace(response.Content.Headers.ContentDisposition.FileName))
                    {
                        var fileName = response.Content.Headers.ContentDisposition.FileNameStar ?? response.Content.Headers.ContentDisposition.FileName;
                        if (!string.IsNullOrWhiteSpace(fileName))
                        {
                            var sanitizedFileName = SanitizeFileName(fileName);
                            var fullFileName = QualifyFilePath(sanitizedFileName);
                            WriteVerbose(
                                Resources.InferredFileNameVerboseMessage.FormatCurrentCulture(fileName, fullFileName));
                            response.GetResponseStream().SaveStreamToFile(fullFileName, this, _cancellationTokenSource.Token);
                        }
                        else
                        {
                            var errorRecord = GetValidationError(Resources.InferredFileNameIncorrect,
                                ErrorConstants.Codes.InvokeGraphRequestCouldNotInferFileName, fileName);
                            WriteError(errorRecord);
                        }
                    }
                }
                else
                {
                    var errorRecord = GetValidationError(Resources.InferredFileNameErrorMessage,
                        ErrorConstants.Codes.InvokeGraphRequestCouldNotInferFileName);
                    WriteError(errorRecord);
                }
            }

            if (!string.IsNullOrEmpty(StatusCodeVariable))
            {
                var vi = SessionState.PSVariable;
                vi.Set(StatusCodeVariable, (int)response.StatusCode);
            }

            if (!string.IsNullOrEmpty(ResponseHeadersVariable))
            {
                var vi = SessionState.PSVariable;
                vi.Set(ResponseHeadersVariable, response.GetHttpResponseHeaders());
            }
        }

        /// <summary>
        ///     When Inferring file names from Content disposition, ensure that
        ///     only valid path characters are in the file name
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string SanitizeFileName(string fileName)
        {
            var illegalCharacters = Path.GetInvalidFileNameChars().Concat(Path.GetInvalidPathChars()).ToArray();
            return string.Concat(fileName.Split(illegalCharacters));
        }

        /// <summary>
        ///     Executes the HTTP Request and returns a response
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> GetResponseAsync(HttpClient client, HttpRequestMessage request)
        {
            using (NoSynchronizationContext)
            {
                if (client == null)
                {
                    throw new ArgumentNullException(nameof(client));
                }

                if (request == null)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                var cancellationToken = _cancellationTokenSource.Token;
                var response = await client.SendAsync(request, cancellationToken);
                return response;
            }
        }

        /// <summary>
        ///     Set the request content.
        ///     Convert Dictionaries to Json
        ///     Passing a dictionary to the body object should be translated to Json.
        ///     Almost everything on Microsoft Graph works converts dictionaries and arrays to JSON.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private long SetRequestContent(HttpRequestMessage request, IDictionary content)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            // Covert all dictionaries to Json
            var body = JsonConvert.SerializeObject(content);
            return SetRequestContent(request, body);
        }

        /// <summary>
        ///     Set the request content
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private long SetRequestContent(HttpRequestMessage request, string content)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (content == null)
            {
                return 0;
            }

            Encoding encoding = null;
            // When contentType is set, coerce to correct encoding. 
            if (!string.IsNullOrWhiteSpace(ContentType))
            {
                // If Content-Type contains the encoding format (as CharSet), use this encoding format
                // to encode the Body of the GraphRequest sent to the server. Default Encoding format
                // would be used if Charset is not supplied in the Content-Type property.
                try
                {
                    var mediaTypeHeaderValue = MediaTypeHeaderValue.Parse(ContentType);
                    if (!string.IsNullOrEmpty(mediaTypeHeaderValue.CharSet))
                    {
                        encoding = Encoding.GetEncoding(mediaTypeHeaderValue.CharSet);
                    }
                }
                catch (FormatException ex)
                {
                    if (!SkipHeaderValidation)
                    {
                        var outerEx = new ValidationMetadataException(Resources.ContentTypeExceptionErrorMessage, ex);
                        var er = new ErrorRecord(outerEx, ErrorConstants.Codes.InvokeGraphContentTypeException,
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }
                catch (ArgumentException ex)
                {
                    if (!SkipHeaderValidation)
                    {
                        var outerEx = new ValidationMetadataException(Resources.ContentTypeExceptionErrorMessage, ex);
                        var er = new ErrorRecord(outerEx, ErrorConstants.Codes.InvokeGraphContentTypeException,
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }
            }

            var bytes = content.EncodeToBytes(encoding);
            var byteArrayContent = new ByteArrayContent(bytes);
            request.Content = byteArrayContent;

            return byteArrayContent.Headers.ContentLength.Value;
        }

        /// <summary>
        ///     Hydrate the request with the requisite data.
        ///     for Body handle Dictionaries, Streams and Byte Arrays, coerce
        ///     into a string if none of the above types.
        /// </summary>
        /// <param name="request"></param>
        private void FillRequestStream(HttpRequestMessage request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (ContentType != null)
            {
                GraphRequestSession.ContentHeaders[HttpKnownHeaderNames.ContentType] = ContentType;
            }
            else if (ShouldSetDefaultContentType)
            {
                GraphRequestSession.ContentHeaders.TryGetValue(HttpKnownHeaderNames.ContentType, out var contentType);
                if (string.IsNullOrWhiteSpace(contentType))
                {
                    // Assume application/json if not set by user
                    GraphRequestSession.ContentHeaders[HttpKnownHeaderNames.ContentType] =
                        CoreConstants.MimeTypeNames.Application.Json;
                }
            }

            // coerce body into a usable form
            if (Body != null)
            {
                var content = Body;
                // make sure we're using the base object of the body, not the PSObject wrapper
                if (Body is PSObject psBody)
                {
                    content = psBody.BaseObject;
                }

                // Passing a dictionary to the body object should be translated to Json.
                // Almost everything on Microsoft Graph works converts dictionaries and arrays to JSON.
                if (content is IDictionary dictionary && request.Method != HttpMethod.Get)
                {
                    SetRequestContent(request, dictionary);
                }
                else if (content is Stream stream)
                {
                    SetRequestContent(request, stream);
                }
                else if (content is byte[] bytes)
                {
                    SetRequestContent(request, bytes);
                }
                else
                {
                    // Assume its a string
                    SetRequestContent(request,
                        (string)LanguagePrimitives.ConvertTo(content, typeof(string), CultureInfo.InvariantCulture));
                }
            }
            else if (InputFilePath != null) // copy InputFilePath data
            {
                try
                {
                    // open the input file
                    SetRequestContent(request,
                        new FileStream(InputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read));
                }
                catch (UnauthorizedAccessException)
                {
                    var msg = Resources.AccessDenied.FormatCurrentCulture(_originalFilePath);
                    throw new UnauthorizedAccessException(msg);
                }
            }

            // Add the content headers
            // Only Set Content Headers when its not a GET Request
            if (request.Content == null && Method != GraphRequestMethod.GET)
            {
                request.Content = new StringContent(string.Empty);
                request.Content.Headers.Clear();
            }

            foreach (var entry in GraphRequestSession.ContentHeaders.Where(header =>
                !string.IsNullOrWhiteSpace(header.Value)))
            {
                if (SkipHeaderValidation)
                {
                    request.Content?.Headers.TryAddWithoutValidation(entry.Key, entry.Value);
                }
                else
                {
                    try
                    {
                        request.Content?.Headers.Add(entry.Key, entry.Value);
                    }
                    catch (FormatException ex)
                    {
                        var outerEx =
                            new ValidationMetadataException(Resources.ContentTypeExceptionErrorMessage, ex);
                        var er = new ErrorRecord(outerEx, ErrorConstants.Codes.InvokeGraphContentTypeException,
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }
            }
        }

        /// <summary>
        ///     Sets the body of the to be a byte array
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private static long SetRequestContent(HttpRequestMessage request, byte[] content)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (content == null)
                return 0;

            var byteArrayContent = new ByteArrayContent(content);
            request.Content = byteArrayContent;

            return byteArrayContent.Headers.ContentLength.Value;
        }

        /// <summary>
        ///     Sets the body of the request to be a Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="contentStream"></param>
        /// <returns></returns>
        private static long SetRequestContent(HttpRequestMessage request, Stream contentStream)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (contentStream == null)
                throw new ArgumentNullException(nameof(contentStream));

            var streamContent = new StreamContent(contentStream);
            request.Content = streamContent;

            return streamContent.Headers.ContentLength.Value;
        }

        /// <summary>
        ///     Maps from HttpVerb to System.Net.Http.HttpMethod
        /// </summary>
        /// <returns>System.Net.Http.HttpMethod</returns>
        private static HttpMethod GetHttpMethod(GraphRequestMethod graphRequestMethod)
        {
            return new HttpMethod(graphRequestMethod.ToString().ToUpperInvariant());
        }

        /// <summary>
        ///     Prepare GraphRequestSession to be used downstream.
        /// </summary>
        internal virtual void PrepareSession()
        {
            // Create a new GraphRequestSession object to work with if one is not supplied
            GraphRequestSession = GraphRequestSession ?? new GraphRequestSession();
            if (SessionVariable != null)
            {
                // save the session back to the PS environment if requested
                var vi = SessionState.PSVariable;
                vi.Set(SessionVariable, GraphRequestSession);
            }

            // Handle Custom User Agents
            GraphRequestSession.UserAgent = UserAgent ?? _graphRequestUserAgent.UserAgent;

            // Store the other supplied headers
            if (Headers != null)
            {
                foreach (string key in Headers.Keys)
                {
                    var value = Headers[key];

                    // null is not valid value for header.
                    // We silently ignore header if value is null.
                    if (!(value is null))
                    {
                        // add the header value (or overwrite it if already present)
                        GraphRequestSession.Headers[key] = value.ToString();
                    }
                }
            }
        }

        private void ValidateRequestUri()
        {
            if (Uri == null)
            {
                var error = GetValidationError(
                    Resources.InvokeGraphRequestMissingUriErrorMessage,
                    ErrorConstants.Codes.InvokeGraphRequestInvalidHost,
                    nameof(Uri));
                ThrowTerminatingError(error);
            }

            if (string.IsNullOrWhiteSpace(Uri.ToString()))
            {
                var error = GetValidationError(
                    Resources.InvokeGraphRequestInvalidUriErrorMessage,
                    ErrorConstants.Codes.InvokeGraphRequestInvalidHost,
                    nameof(Uri));
                ThrowTerminatingError(error);
            }
        }

        private void ValidateParameters()
        {
            if (GraphRequestSession != null && SessionVariable != null)
            {
                var error = GetValidationError(
                    Resources.GraphRequestSessionConflict,
                    ErrorConstants.Codes.InvokeGraphRequestSessionConflictException);
                ThrowTerminatingError(error);
            }

            if (PassThru && OutputFilePath == null)
            {
                var error = GetValidationError(
                    Resources.PassThruWithOutputFilePathMissing,
                    ErrorConstants.Codes.InvokeGraphRequestOutFileMissingException,
                    nameof(PassThru), nameof(OutputFilePath));
                ThrowTerminatingError(error);
            }

            if (GraphSession.Instance.AuthContext == null)
            {
                var errorRecord = new ErrorRecord(new AuthenticationException(Core.ErrorConstants.Message.MissingAuthContext),
                    ErrorCategory.AuthenticationError.ToString(),
                    ErrorCategory.AuthenticationError, null);
                ThrowTerminatingError(errorRecord);
            }

            // Only Body or InputFilePath can be specified at a time
            if (Body != null && !string.IsNullOrWhiteSpace(InputFilePath))
            {
                var error = GetValidationError(
                    Resources.BodyConflict,
                    ErrorConstants.Codes.InvokeGraphRequestBodyConflictException,
                    nameof(Body), nameof(InputFilePath));
                ThrowTerminatingError(error);
            }

            if (InferOutputFileName.IsPresent && !string.IsNullOrWhiteSpace(OutputFilePath))
            {
                var error = GetValidationError(
                    Resources.InferFileNameOutFilePathConflict,
                    ErrorConstants.Codes.InvokeGraphRequestBodyConflictException,
                    nameof(InferOutputFileName), nameof(OutputFilePath));
                ThrowTerminatingError(error);
            }

            // Ensure InputFilePath is an Existing Item
            if (InputFilePath != null)
            {
                ErrorRecord errorRecord = null;

                try
                {
                    var providerPaths = GetResolvedProviderPathFromPSPath(InputFilePath, out var provider);

                    if (!provider.Name.Equals(FileSystemProvider.ProviderName, StringComparison.OrdinalIgnoreCase))
                    {
                        errorRecord = GetValidationError(
                            Resources.NotFileSystemPath,
                            ErrorConstants.Codes.InvokeGraphRequestFileNotFilesystemPathException,
                            InputFilePath);
                    }
                    else
                    {
                        if (providerPaths.Count > 1)
                        {
                            errorRecord = GetValidationError(
                                Resources.MultiplePathsResolved,
                                ErrorConstants.Codes.InvokeGraphRequestInputFileMultiplePathsResolvedException, InputFilePath);
                        }
                        else if (providerPaths.Count == 0)
                        {
                            errorRecord = GetValidationError(
                                Resources.NoPathResolved,
                                ErrorConstants.Codes.InvokeGraphRequestInputFileNoPathResolvedException, InputFilePath);
                        }
                        else
                        {
                            if (Directory.Exists(providerPaths[0]))
                            {
                                errorRecord = GetValidationError(
                                    Resources.DirectoryPathSpecified,
                                    ErrorConstants.Codes.InvokeGraphRequestInputFileNotFilePathException, InputFilePath);
                            }

                            _originalFilePath = InputFilePath;
                            InputFilePath = providerPaths[0];
                        }
                    }
                }
                catch (ItemNotFoundException pathNotFound)
                {
                    errorRecord = new ErrorRecord(pathNotFound.ErrorRecord, pathNotFound);
                }
                catch (ProviderNotFoundException providerNotFound)
                {
                    errorRecord = new ErrorRecord(providerNotFound.ErrorRecord, providerNotFound);
                }
                catch (DriveNotFoundException driveNotFound)
                {
                    errorRecord = new ErrorRecord(driveNotFound.ErrorRecord, driveNotFound);
                }

                if (errorRecord != null)
                    ThrowTerminatingError(errorRecord);
            }
        }

        /// <summary>
        ///     Composes a validation error
        /// </summary>
        private ErrorRecord GetValidationError(string msg, string errorId)
        {
            var ex = new ValidationMetadataException(msg);
            return new ErrorRecord(ex, errorId, ErrorCategory.InvalidArgument, this);
        }

        /// <summary>
        ///     Composes a validation error
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="errorId"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private ErrorRecord GetValidationError(string msg, string errorId, params object[] args)
        {
            msg = msg.FormatCurrentCulture(args);
            var ex = new ValidationMetadataException(msg);
            var error = new ErrorRecord(ex, errorId, ErrorCategory.InvalidArgument, this);
            return error;
        }

        /// <summary>
        ///     Generate a fully qualified file path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string QualifyFilePath(string path)
        {
            var resolvedFilePath = PathUtils.ResolveFilePath(path, this, true);
            return resolvedFilePath;
        }

        /// <summary>
        ///     Resets GraphSession environment back to its original state.
        ///     Original state can remain to be the previous state defined by the user, 
        ///     or the default global state. User defined state can be removed by calling,
        ///     Remove-MgEnvironment Command
        /// </summary>
        private void ResetGraphSessionEnvironment()
        {
            _originalEnvironment = GraphSession.Instance.Environment;
        }

        #region CmdLet LifeCycle

        protected override void BeginProcessing()
        {
            if (Break)
            {
                this.Break();
            }
            _graphRequestUserAgent = new RequestUserAgent(this.Host.Version, this.MyInvocation);
            ValidateParameters();
            base.BeginProcessing();
        }

        private async Task ProcessRecordAsync()
        {
            using (NoSynchronizationContext)
            {
                try
                {
                    PrepareSession();
                    var client = HttpHelpers.GetGraphHttpClient();
                    ValidateRequestUri();
                    using (var httpRequestMessage = GetRequest(client, Uri))
                    {
                        var httpRequestMessageFormatter = new HttpMessageFormatter(httpRequestMessage);
                        FillRequestStream(httpRequestMessage);
                        try
                        {
                            await ReportRequestStatusAsync(httpRequestMessageFormatter);
                            var httpResponseMessage = await GetResponseAsync(client, httpRequestMessage);
                            var httpResponseMessageFormatter = new HttpMessageFormatter(httpResponseMessage);
                            await ReportResponseStatusASync(httpResponseMessageFormatter);
                            var isSuccess = httpResponseMessage.IsSuccessStatusCode;
                            if (ShouldCheckHttpStatus && !isSuccess)
                            {
                                var httpErrorRecord = await GenerateHttpErrorRecordAsync(httpResponseMessageFormatter, httpRequestMessage);
                                ThrowTerminatingError(httpErrorRecord);
                            }
                            await ProcessResponseAsync(httpResponseMessage);
                        }
                        catch (HttpRequestException ex)
                        {
                            var er = new ErrorRecord(ex, ErrorConstants.Codes.InvokeGraphHttpResponseException,
                                ErrorCategory.InvalidOperation,
                                httpRequestMessage);
                            if (ex.InnerException != null)
                            {
                                er.ErrorDetails = new ErrorDetails(ex.InnerException.Message);
                            }

                            ThrowTerminatingError(er);
                        }
                    }
                }
                catch (HttpRequestException httpRequestException)
                {
                    var errorRecord = new ErrorRecord(httpRequestException, ErrorCategory.ConnectionError.ToString(),
                        ErrorCategory.ConnectionError, null);
                    ThrowTerminatingError(errorRecord);
                }
                catch (AuthenticationException authenticationException)
                {
                    var errorRecord = new ErrorRecord(authenticationException, ErrorCategory.AuthenticationError.ToString(),
                        ErrorCategory.AuthenticationError, null);
                    ThrowTerminatingError(errorRecord);
                }
                catch (Exception exception)
                {
                    var errorRecord = new ErrorRecord(exception, ErrorCategory.NotSpecified.ToString(),
                        ErrorCategory.InvalidOperation, null);
                    ThrowTerminatingError(errorRecord);
                }
            }
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                using (var asyncCommandRuntime = new CustomAsyncCommandRuntime(this, _cancellationTokenSource.Token))
                {
                    asyncCommandRuntime.Wait(ProcessRecordAsync());
                }
            }
            catch (AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach (var innerException in aggregateException.Flatten().InnerExceptions)
                {
                    var errorRecords = innerException.Data;
                    if (errorRecords.Count > 1)
                    {
                        foreach (DictionaryEntry dictionaryEntry in errorRecords)
                        {
                            WriteError((ErrorRecord)dictionaryEntry.Value);
                        }
                    }
                    else
                    {
                        WriteError(new ErrorRecord(innerException, string.Empty, ErrorCategory.NotSpecified, null));
                    }
                }
            }
            catch (Exception exception) when (exception as PipelineStoppedException == null ||
                                              (exception as PipelineStoppedException).InnerException != null)
            {
                // Write exception out to error channel.
                WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.NotSpecified, null));
            }
        }

        protected override void EndProcessing()
        {
            ResetGraphSessionEnvironment();
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            ResetGraphSessionEnvironment();
            _cancellationTokenSource.Cancel();
            base.StopProcessing();
        }

        #endregion
    }
}