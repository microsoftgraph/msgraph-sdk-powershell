using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Models;
using Microsoft.PowerShell.Commands;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DriveNotFoundException = System.Management.Automation.DriveNotFoundException;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsLifecycle.Invoke, "GraphRequest", DefaultParameterSetName = Constants.UserParameterSet)]
    public class InvokeGraphRequest : PSCmdlet
    {
        private readonly CancellationTokenSource _cancelToken;
        private readonly InvokeGraphRequestUserAgent _graphRequestUserAgent;
        private string _originalFilePath;

        public InvokeGraphRequest()
        {
            _cancelToken = new CancellationTokenSource();
            _graphRequestUserAgent = new InvokeGraphRequestUserAgent(this);
            Method = GraphRequestMethod.GET;
            Authentication = GraphRequestAuthenticationType.Default;
        }

        /// <summary>
        ///     Http Method
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 1,
            Mandatory = true,
            HelpMessage = "Http Method")]
        public GraphRequestMethod Method { get; set; }

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
        ///     Optional Http Body
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 3,
            HelpMessage = "Request Body. Required when Method is Post or Patch",
            ValueFromPipeline = true)]
        public object Body { get; set; }

        /// <summary>
        ///     Optional Custom Headers
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 4,
            HelpMessage = "Optional Custom Headers")]
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        ///     Output file where the response body will be saved
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 5,
            HelpMessage = "Output file where the response body will be saved")]
        public string OutFile { get; set; }

        /// <summary>
        ///     Infer Download FileName from ContentDisposition Header
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 6,
            HelpMessage = "Infer Download FileName")]
        public SwitchParameter InferOutFileName { get; set; }

        /// <summary>
        ///     Gets or sets the InFile property.
        /// </summary>
        [Parameter]
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 7,
            HelpMessage = "Infile to Send in the Request")]
        public virtual string InFile { get; set; }

        /// <summary>
        ///     Indicates that the cmdlet returns the results, in addition to writing them to a file.
        ///     only valid when the OutFile parameter is also used.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 8,
            HelpMessage =
                "Indicates that the cmdlet returns the results, in addition to writing them to a file. Only valid when the OutFile parameter is also used. ")]
        public SwitchParameter PassThru { get; set; }

        /// <summary>
        ///     OAuth or Bearer Token to use instead of already acquired token
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 9,
            HelpMessage = "OAuth or Bearer Token to use instead of already acquired token")]
        public string Token { get; set; }

        /// <summary>
        ///     Add headers to Request Header collection without validation
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 10,
            HelpMessage = "Add headers to Request Header collection without validation")]
        public SwitchParameter SkipHeaderValidation { get; set; }

        /// <summary>
        ///     Custom Content Type
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 11,
            HelpMessage = "Custom Content Type")]
        public virtual string ContentType { get; set; }

        /// <summary>
        ///     Graph Authentication Type
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = Constants.UserParameterSet,
            Position = 12,
            HelpMessage = "Graph Authentication Type")]
        public GraphRequestAuthenticationType Authentication { get; set; }

        /// <summary>
        /// Gets or sets the SessionVariable property.
        /// </summary>
        [Parameter(Position = 13, ParameterSetName = Constants.UserParameterSet,
            Mandatory = false, HelpMessage = "Session Variable")]
        [Alias("SV")]
        public string SessionVariable { get; set; }

        /// <summary>
        ///  Response Headers Variable
        /// </summary>
        [Parameter(Position = 14, ParameterSetName = Constants.UserParameterSet,
            Mandatory = false,
            HelpMessage = "Response Headers Variable")]
        [Alias("RHV")]
        public string ResponseHeadersVariable { get; set; }

        /// <summary>
        /// Response Status Code Variable
        /// </summary>
        [Parameter(Position = 15, ParameterSetName = Constants.UserParameterSet,
            Mandatory = false,
            HelpMessage = "Response Status Code Variable")]
        public string StatusCodeVariable { get; set; }

        /// <summary>
        ///     Gets or sets whether to skip checking HTTP status for error codes.
        /// </summary>
        [Parameter(Position = 16, ParameterSetName = Constants.UserParameterSet, Mandatory = false, HelpMessage = "Skip Checking Http Errors")]
        public virtual SwitchParameter SkipHttpErrorCheck { get; set; }
        /// <summary>
        /// Gets or sets the Session property.
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 17, ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Custom Graph Request Session")]
        public GraphRequestSession GraphRequestSession { get; set; }

        /// <summary>
        ///     Custom User Specified User Agent
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 18, ParameterSetName = Constants.UserParameterSet,
            HelpMessage = "Custom User Specified User Agent")]
        public string UserAgent { get; set; }

        /// <summary>
        ///     Wait for .NET debugger to attach
        /// </summary>
        [Parameter(Mandatory = false,
            DontShow = true,
            HelpMessage = "Wait for .NET debugger to attach")]
        public SwitchParameter Break { get; set; }

        internal string QualifiedOutFile => QualifyFilePath(OutFile);

        internal bool ShouldSaveToOutFile => !string.IsNullOrEmpty(OutFile);

        internal bool ShouldWriteToPipeline => (!ShouldSaveToOutFile && !InferOutFileName) || PassThru;

        internal bool ShouldCheckHttpStatus => !SkipHttpErrorCheck;

        #region CmdLet LifeCycle
        protected override void BeginProcessing()
        {
            if (Break)
            {
                AttachDebugger.Break(this);
            }

            ValidateParameters();
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                PrepareSession();
                using var client = GetHttpClient();
                ValidateRequestUri(client);
                using var httpRequestMessage = GetRequest(Uri);
                using var httpRequestMessageFormatter = new HttpMessageFormatter(httpRequestMessage);

                FillRequestStream(httpRequestMessage);
                try
                {
                    ReportRequestStatus(httpRequestMessageFormatter.HttpRequestMessage);

                    var httpResponseMessage = GetResponse(client, httpRequestMessage);
                    using var httpResponseMessageFormatter = new HttpMessageFormatter(httpResponseMessage);
                    ReportResponseStatus(httpResponseMessageFormatter.HttpResponseMessage);

                    var isSuccess = httpResponseMessage.IsSuccessStatusCode;
                    if (ShouldCheckHttpStatus && !isSuccess)
                    {
                        var httpErrorRecord = GenerateHttpErrorRecord(httpResponseMessageFormatter, httpRequestMessage);
                        ThrowTerminatingError(httpErrorRecord);
                    }
                    ProcessResponse(httpResponseMessage);
                }
                catch (HttpRequestException ex)
                {
                    var er = new ErrorRecord(ex, "WebCmdletWebResponseException", ErrorCategory.InvalidOperation, httpRequestMessage);
                    if (ex.InnerException != null)
                    {
                        er.ErrorDetails = new ErrorDetails(ex.InnerException.Message);
                    }
                    ThrowTerminatingError(er);
                }
            }
            catch (HttpRequestException httpRequestException)
            {
                WriteError(new ErrorRecord(httpRequestException, ErrorCategory.ConnectionError.ToString(),
                    ErrorCategory.InvalidResult, null));
                throw;
            }
            catch (Exception exception)
            {
                WriteError(new ErrorRecord(exception, ErrorCategory.ConnectionError.ToString(),
                    ErrorCategory.InvalidOperation, null));
                throw;
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
        #endregion
        private static ErrorRecord GenerateHttpErrorRecord(HttpMessageFormatter httpResponseMessageFormatter, HttpRequestMessage httpRequestMessage)
        {
            var currentResponse = httpResponseMessageFormatter.HttpResponseMessage;
            var errorMessage = StringFormatCurrentCulture("ResponseStatusCodeFailure {0} {1}", currentResponse.StatusCode, currentResponse.ReasonPhrase);
            var httpException = new HttpResponseException(errorMessage, currentResponse);
            var errorRecord = new ErrorRecord(httpException, "WebCmdletWebResponseException", ErrorCategory.InvalidOperation, httpRequestMessage);
            var detailMsg = httpResponseMessageFormatter.ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();
            if (!string.IsNullOrEmpty(detailMsg))
            {
                errorRecord.ErrorDetails = new ErrorDetails(detailMsg);
            }

            return errorRecord;
        }

        private void ReportRequestStatus(HttpRequestMessage requestMessage)
        {
            long requestContentLength = 0;
            if (requestMessage.Content != null)
            {
                requestContentLength = requestMessage.Content.Headers.ContentLength.Value;
            }
            var reqVerboseMsg = StringFormatCurrentCulture("{0} {1} with {2}-byte payload",
                requestMessage.Method,
                requestMessage.RequestUri,
                requestContentLength);
            WriteVerbose(reqVerboseMsg);
        }

        private void ReportResponseStatus(HttpResponseMessage responseMessage)
        {
            var contentType = ContentHelper.GetContentType(responseMessage);
            var respVerboseMsg = StringFormatCurrentCulture("received {0}-byte response of content type {1}",
                responseMessage.Content.Headers.ContentLength,
                contentType);
            WriteVerbose(respVerboseMsg);
        }

        private static string StringFormatCurrentCulture(string format, params object[] args)
        {
            return string.Format(CultureInfo.CurrentCulture, format, args);
        }

        private static string FormatDictionary(IDictionary content)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content));

            var bodyBuilder = new StringBuilder();
            foreach (string key in content.Keys)
            {
                if (0 < bodyBuilder.Length) bodyBuilder.Append("&");

                var value = content[key];

                // URLEncode the key and value
                var encodedKey = WebUtility.UrlEncode(key);
                var encodedValue = string.Empty;
                if (value != null) encodedValue = WebUtility.UrlEncode(value.ToString());

                bodyBuilder.AppendFormat("{0}={1}", encodedKey, encodedValue);
            }

            return bodyBuilder.ToString();
        }

        private HttpRequestMessage GetRequest(Uri uri)
        {
            var requestUri = PrepareUri(uri);
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

        private Uri PrepareUri(Uri uri)
        {
            // before creating the web request,
            // preprocess Body if content is a dictionary and method is GET (set as query)
            LanguagePrimitives.TryConvertTo(Body, out IDictionary bodyAsDictionary);
            if (bodyAsDictionary != null && Method == GraphRequestMethod.GET)
            {
                var uriBuilder = new UriBuilder(uri);
                if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
                    uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + FormatDictionary(bodyAsDictionary);
                else
                    uriBuilder.Query = FormatDictionary(bodyAsDictionary);

                uri = uriBuilder.Uri;
                // set body to null to prevent later FillRequestStream
                Body = null;
            }

            return uri;
        }

        private static RestReturnType CheckReturnType(HttpResponseMessage response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));

            var rt = RestReturnType.Detect;
            var contentType = ContentHelper.GetContentType(response);
            if (string.IsNullOrEmpty(contentType))
                rt = RestReturnType.Detect;
            else if (ContentHelper.IsJson(contentType))
                rt = RestReturnType.Json;
            else if (ContentHelper.IsXml(contentType)) rt = RestReturnType.Xml;

            return rt;
        }

        internal void ProcessResponse(HttpResponseMessage response)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));

            var baseResponseStream = StreamHelper.GetResponseStream(response);

            if (ShouldWriteToPipeline)
            {
                using var responseStream = new BufferingStreamReader(baseResponseStream);
                // determine the response type
                var returnType = CheckReturnType(response);

                // Try to get the response encoding from the ContentType header.
                Encoding encoding = null;
                var charSet = response.Content.Headers.ContentType?.CharSet;
                if (!string.IsNullOrEmpty(charSet))
                {
                    // NOTE: Don't use ContentHelper.GetEncoding; it returns a
                    // default which bypasses checking for a meta charset value.
                    StreamHelper.TryGetEncoding(charSet, out encoding);
                }

                if (string.IsNullOrEmpty(charSet) && returnType == RestReturnType.Json)
                {
                    encoding = Encoding.UTF8;
                }

                Exception ex = null;

                var str = StreamHelper.DecodeStream(responseStream, ref encoding);

                string encodingVerboseName;
                try
                {
                    encodingVerboseName = string.IsNullOrEmpty(encoding.HeaderName)
                        ? encoding.EncodingName
                        : encoding.HeaderName;
                }
                catch (NotSupportedException)
                {
                    encodingVerboseName = encoding.EncodingName;
                }

                // NOTE: Tests use this verbose output to verify the encoding.
                WriteVerbose(StringFormatCurrentCulture("Content encoding: {0}", encodingVerboseName));
                var convertSuccess = TryConvert<Hashtable>(str, out var obj, ref ex);
                if (!convertSuccess)
                {
                    // fallback to string
                    obj = str;
                }

                WriteObject(obj);
            }

            if (ShouldSaveToOutFile)
            {
                StreamHelper.SaveStreamToFile(baseResponseStream, QualifiedOutFile, this, _cancelToken.Token);
            }

            if (InferOutFileName.IsPresent)
            {
                if (response.Content.Headers.ContentDisposition != null)
                {
                    if (!string.IsNullOrWhiteSpace(response.Content.Headers.ContentDisposition.FileName))
                    {
                        var fileName = response.Content.Headers.ContentDisposition.FileNameStar;
                        var fullFileName = QualifyFilePath(fileName);
                        WriteVerbose(string.Format(CultureInfo.InvariantCulture, "Inferred File Name {0} Saving to {1}", fileName, fullFileName));
                        StreamHelper.SaveStreamToFile(baseResponseStream, fullFileName, this,
                            _cancelToken.Token);
                    }
                }
                else
                {
                    WriteVerbose("Could not Infer File Name");
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
                vi.Set(ResponseHeadersVariable, WebResponseHelper.GetHeadersDictionary(response));
            }
        }

        private static bool TryConvert<T>(string str, out object obj, ref Exception exRef)
        {
            var converted = false;
            try
            {
                obj = JsonConvert.DeserializeObject<T>(str);
                if (obj == null)
                    JToken.Parse(str);
                else
                    converted = true;
            }
            catch (JsonException ex)
            {
                var msg = string.Format(CultureInfo.CurrentCulture, "JsonDeserializationFailed", ex.Message);
                exRef = new ArgumentException(msg, ex);
                obj = null;
            }
            catch (Exception jsonParseException)
            {
                exRef = jsonParseException;
                obj = null;
            }

            return converted;
        }

        private IAuthenticationProvider GetAuthProvider()
        {
            if (Authentication == GraphRequestAuthenticationType.UserProvidedToken)
            {
                return new InvokeGraphRequestAuthProvider(GraphRequestSession);
            }

            return AuthenticationHelpers.GetAuthProvider(GraphSession.Instance.AuthContext);
        }

        private HttpClient GetHttpClient()
        {
            var provider = GetAuthProvider();
            var client = HttpHelpers.GetGraphHttpClient(provider);
            return client;
        }

        private HttpResponseMessage GetResponse(HttpClient client, HttpRequestMessage request)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            if (request == null) throw new ArgumentNullException(nameof(request));

            var cancellationToken = _cancelToken.Token;
            var response = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                .GetAwaiter()
                .GetResult();
            return response;
        }

        private long SetRequestContent(HttpRequestMessage request, IDictionary content)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (content == null)
                throw new ArgumentNullException(nameof(content));

            var body = FormatDictionary(content);
            return SetRequestContent(request, body);
        }

        private long SetRequestContent(HttpRequestMessage request, string content)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (content == null)
                return 0;

            Encoding encoding = null;
            if (ContentType != null)
                // If Content-Type contains the encoding format (as CharSet), use this encoding format
                // to encode the Body of the WebRequest sent to the server. Default Encoding format
                // would be used if Charset is not supplied in the Content-Type property.
                try
                {
                    var mediaTypeHeaderValue = MediaTypeHeaderValue.Parse(ContentType);
                    if (!string.IsNullOrEmpty(mediaTypeHeaderValue.CharSet))
                        encoding = Encoding.GetEncoding(mediaTypeHeaderValue.CharSet);
                }
                catch (FormatException ex)
                {
                    if (!SkipHeaderValidation)
                    {
                        var outerEx = new ValidationMetadataException("ContentTypeException", ex);
                        var er = new ErrorRecord(outerEx, "WebCmdletContentTypeException",
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }
                catch (ArgumentException ex)
                {
                    if (!SkipHeaderValidation)
                    {
                        var outerEx = new ValidationMetadataException("ContentTypeException", ex);
                        var er = new ErrorRecord(outerEx, "WebCmdletContentTypeException",
                            ErrorCategory.InvalidArgument, ContentType);
                        ThrowTerminatingError(er);
                    }
                }

            var bytes = StreamHelper.EncodeToBytes(content, encoding);
            var byteArrayContent = new ByteArrayContent(bytes);
            request.Content = byteArrayContent;

            return byteArrayContent.Headers.ContentLength.Value;
        }

        private void FillRequestStream(HttpRequestMessage request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (ContentType != null)
            {
                GraphRequestSession.ContentHeaders[HttpKnownHeaderNames.ContentType] = ContentType;
            }
            else if (Method == GraphRequestMethod.POST)
            {
                GraphRequestSession.ContentHeaders.TryGetValue(HttpKnownHeaderNames.ContentType, out var contentType);
                if (string.IsNullOrWhiteSpace(contentType))
                {
                    // Assume application/json of not set by user
                    GraphRequestSession.ContentHeaders[HttpKnownHeaderNames.ContentType] =
                        CoreConstants.MimeTypeNames.Application.Json;
                }
            }

            // coerce body into a usable form
            if (Body != null)
            {
                var content = Body;

                // make sure we're using the base object of the body, not the PSObject wrapper
                var psBody = Body as PSObject;
                if (psBody != null)
                {
                    content = psBody.BaseObject;
                }
                else if (content is IDictionary dictionary && request.Method != HttpMethod.Get)
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
                    SetRequestContent(request,
                        (string)LanguagePrimitives.ConvertTo(content, typeof(string), CultureInfo.InvariantCulture));
                }
            }
            else if (InFile != null) // copy InFile data
            {
                try
                {
                    // open the input file
                    SetRequestContent(request, new FileStream(InFile, FileMode.Open, FileAccess.Read, FileShare.Read));
                }
                catch (UnauthorizedAccessException)
                {
                    var msg = string.Format(CultureInfo.InvariantCulture, "AccessDenied",
                        _originalFilePath);
                    throw new UnauthorizedAccessException(msg);
                }
            }

            // Add the content headers
            if (request.Content == null)
            {
                request.Content = new StringContent(string.Empty);
                request.Content.Headers.Clear();
            }

            foreach (var entry in GraphRequestSession.ContentHeaders)
            {
                if (!string.IsNullOrWhiteSpace(entry.Value))
                {
                    if (SkipHeaderValidation)
                        request.Content.Headers.TryAddWithoutValidation(entry.Key, entry.Value);
                    else
                        try
                        {
                            request.Content.Headers.Add(entry.Key, entry.Value);
                        }
                        catch (FormatException ex)
                        {
                            var outerEx = new ValidationMetadataException("ContentTypeException", ex);
                            var er = new ErrorRecord(outerEx, "WebCmdletContentTypeException",
                                ErrorCategory.InvalidArgument, ContentType);
                            ThrowTerminatingError(er);
                        }
                }
            }
        }

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
        /// Prepare GraphRequestSession to be used downstream.
        /// </summary>
        internal virtual void PrepareSession()
        {
            // Create a new GraphRequestSession object to work with if one is not supplied
            GraphRequestSession ??= new GraphRequestSession();
            if (SessionVariable != null)
            {
                // save the session back to the PS environment if requested
                var vi = SessionState.PSVariable;
                vi.Set(SessionVariable, GraphRequestSession);
            }

            if (Authentication == GraphRequestAuthenticationType.UserProvidedToken && !string.IsNullOrWhiteSpace(Token))
            {
                GraphRequestSession.Token = Token;
                GraphRequestSession.AuthenticationType = Authentication;
            }
            
            //
            // Handle Custom User Agents
            //
            GraphRequestSession.UserAgent = UserAgent ?? _graphRequestUserAgent.UserAgent;

            // Store the other supplied headers
            if (Headers != null)
            {
                foreach (var key in Headers.Keys)
                {
                    var value = Headers[key];

                    // null is not valid value for header.
                    // We silently ignore header if value is null.
                    if (!(value is null))
                    {
                        // add the header value (or overwrite it if already present)
                        GraphRequestSession.Headers[key] = value;
                    }
                }
            }
        }
        /// <summary>
        /// Validate the Request Uri must have the same Host as GraphHttpClient BaseAddress.
        /// </summary>
        /// <param name="httpClient"></param>
        private void ValidateRequestUri(HttpClient httpClient)
        {
            if (Uri == null)
            {
                var error = GetValidationError($"Must specify {nameof(Uri)}", "InvokeGraphRequestInvalidHost",
                    nameof(Uri));
                ThrowTerminatingError(error);
            }
            // Ensure that the Passed in Uri has the same Host as the HttpClient. 
            if (Uri.IsAbsoluteUri && httpClient.BaseAddress.Host != Uri.Host)
            {
                var error = GetValidationError($"Invalid Host {Uri.Host}", "InvokeGraphRequestInvalidHost",
                    nameof(Uri));
                ThrowTerminatingError(error);
            }
        }
        /// <summary>
        /// Validate Passed In Parameters
        /// </summary>
        private void ValidateParameters()
        {
            if (GraphRequestSession != null && SessionVariable != null)
            {
                var error = GetValidationError(
                    "The cmdlet cannot run because the following conflicting parameters are specified: Session and SessionVariable. Specify either Session or SessionVariable, then retry.",
                    "WebCmdletSessionConflictException");
                ThrowTerminatingError(error);
            }

            // When PATCH or POST is specified, ensure a body is present
            if (Method == GraphRequestMethod.PATCH || Method == GraphRequestMethod.POST && Body == null)
            {
                var error = GetValidationError($"{nameof(Body)} is required when Method is {Method}",
                    "InvokeGraphRequestBodyMissingWhenMethodIsSpecified", nameof(Body));
                ThrowTerminatingError(error);
            }

            if (PassThru && OutFile == null)
            {
                var error = GetValidationError($"{nameof(OutFile)} is missing",
                    "InvokeGraphRequestOutFileMissingException", nameof(PassThru));
                ThrowTerminatingError(error);
            }

            if (Authentication == GraphRequestAuthenticationType.Default && !string.IsNullOrWhiteSpace(Token))
            {
                var error = GetValidationError("AuthenticationTokenConflict",
                    "WebCmdletAuthenticationTokenConflictException");
                ThrowTerminatingError(error);
            }
            // Token shouldn't be null when UserProvidedToken is specified
            if (Authentication == GraphRequestAuthenticationType.UserProvidedToken && string.IsNullOrWhiteSpace(Token))
            {
                var error = GetValidationError("AuthenticationCredentialNotSupplied",
                    "WebCmdletAuthenticationCredentialNotSuppliedException");
                ThrowTerminatingError(error);
            }

            // Only Body or InFile can be specified at a time
            if (Body != null && InFile != null)
            {
                var error = GetValidationError("BodyConflict",
                    "WebCmdletBodyConflictException");
                ThrowTerminatingError(error);
            }

            // Ensure InFile is an Existing Item
            if (InFile != null)
            {
                ErrorRecord errorRecord = null;

                try
                {
                    var providerPaths = GetResolvedProviderPathFromPSPath(InFile, out var provider);

                    if (!provider.Name.Equals(FileSystemProvider.ProviderName, StringComparison.OrdinalIgnoreCase))
                    {
                        errorRecord = GetValidationError("NotFilesystemPath",
                            "WebCmdletInFileNotFilesystemPathException", InFile);
                    }
                    else
                    {
                        if (providerPaths.Count > 1)
                        {
                            errorRecord = GetValidationError("MultiplePathsResolved",
                                "WebCmdletInFileMultiplePathsResolvedException", InFile);
                        }
                        else if (providerPaths.Count == 0)
                        {
                            errorRecord = GetValidationError("NoPathResolved",
                                "WebCmdletInFileNoPathResolvedException", InFile);
                        }
                        else
                        {
                            if (Directory.Exists(providerPaths[0]))
                                errorRecord = GetValidationError("DirectoryPathSpecified",
                                    "WebCmdletInFileNotFilePathException", InFile);

                            _originalFilePath = InFile;
                            InFile = providerPaths[0];
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

                if (errorRecord != null) ThrowTerminatingError(errorRecord);
            }
        }

        private ErrorRecord GetValidationError(string msg, string errorId)
        {
            var ex = new ValidationMetadataException(msg);
            var error = new ErrorRecord(ex, errorId, ErrorCategory.InvalidArgument, this);
            return error;
        }

        private ErrorRecord GetValidationError(string msg, string errorId, params object[] args)
        {
            msg = string.Format(CultureInfo.InvariantCulture, msg, args);
            var ex = new ValidationMetadataException(msg);
            var error = new ErrorRecord(ex, errorId, ErrorCategory.InvalidArgument, this);
            return error;
        }
        /// <summary>
        /// Generate a fully qualified file path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string QualifyFilePath(string path)
        {
            var resolvedFilePath = PathUtils.ResolveFilePath(path, this, true);
            return resolvedFilePath;
        }
    }
}