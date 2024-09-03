// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Me.Authentication.EmailMethods;
using Microsoft.Graph.Me.Authentication.Fido2Methods;
using Microsoft.Graph.Me.Authentication.Methods;
using Microsoft.Graph.Me.Authentication.MicrosoftAuthenticatorMethods;
using Microsoft.Graph.Me.Authentication.Operations;
using Microsoft.Graph.Me.Authentication.PasswordMethods;
using Microsoft.Graph.Me.Authentication.PhoneMethods;
using Microsoft.Graph.Me.Authentication.SoftwareOathMethods;
using Microsoft.Graph.Me.Authentication.TemporaryAccessPassMethods;
using Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Me.Authentication
{
    /// <summary>
    /// Provides operations to manage the authentication property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class AuthenticationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the emailMethods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.EmailMethods.EmailMethodsRequestBuilder EmailMethods
        {
            get => new global::Microsoft.Graph.Me.Authentication.EmailMethods.EmailMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the fido2Methods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.Fido2Methods.Fido2MethodsRequestBuilder Fido2Methods
        {
            get => new global::Microsoft.Graph.Me.Authentication.Fido2Methods.Fido2MethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the methods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.Methods.MethodsRequestBuilder Methods
        {
            get => new global::Microsoft.Graph.Me.Authentication.Methods.MethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoftAuthenticatorMethods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.MicrosoftAuthenticatorMethods.MicrosoftAuthenticatorMethodsRequestBuilder MicrosoftAuthenticatorMethods
        {
            get => new global::Microsoft.Graph.Me.Authentication.MicrosoftAuthenticatorMethods.MicrosoftAuthenticatorMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.Operations.OperationsRequestBuilder Operations
        {
            get => new global::Microsoft.Graph.Me.Authentication.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passwordMethods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.PasswordMethods.PasswordMethodsRequestBuilder PasswordMethods
        {
            get => new global::Microsoft.Graph.Me.Authentication.PasswordMethods.PasswordMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the phoneMethods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.PhoneMethods.PhoneMethodsRequestBuilder PhoneMethods
        {
            get => new global::Microsoft.Graph.Me.Authentication.PhoneMethods.PhoneMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the softwareOathMethods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.SoftwareOathMethods.SoftwareOathMethodsRequestBuilder SoftwareOathMethods
        {
            get => new global::Microsoft.Graph.Me.Authentication.SoftwareOathMethods.SoftwareOathMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the temporaryAccessPassMethods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder TemporaryAccessPassMethods
        {
            get => new global::Microsoft.Graph.Me.Authentication.TemporaryAccessPassMethods.TemporaryAccessPassMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsHelloForBusinessMethods property of the microsoft.graph.authentication entity.</summary>
        public global::Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.WindowsHelloForBusinessMethodsRequestBuilder WindowsHelloForBusinessMethods
        {
            get => new global::Microsoft.Graph.Me.Authentication.WindowsHelloForBusinessMethods.WindowsHelloForBusinessMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/authentication{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/authentication{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property authentication for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The authentication methods that are supported for the user.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Authentication"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Authentication?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder.AuthenticationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Authentication> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder.AuthenticationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Authentication>(requestInfo, global::Microsoft.Graph.Models.Authentication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property authentication in me
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Authentication"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Authentication?> PatchAsync(global::Microsoft.Graph.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Authentication> PatchAsync(global::Microsoft.Graph.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Authentication>(requestInfo, global::Microsoft.Graph.Models.Authentication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property authentication for me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The authentication methods that are supported for the user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder.AuthenticationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder.AuthenticationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property authentication in me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Authentication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AuthenticationRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The authentication methods that are supported for the user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AuthenticationRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AuthenticationRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.Authentication.AuthenticationRequestBuilder.AuthenticationRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AuthenticationRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
