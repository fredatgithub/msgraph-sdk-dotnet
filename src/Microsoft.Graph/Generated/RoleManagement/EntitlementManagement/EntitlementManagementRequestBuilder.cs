using Microsoft.Graph.Models;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleAssignments;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleAssignmentScheduleInstances;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleAssignmentScheduleRequests;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleAssignmentSchedules;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleDefinitions;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleRequests;
using Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilitySchedules;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.RoleManagement.EntitlementManagement {
    /// <summary>
    /// Provides operations to manage the entitlementManagement property of the microsoft.graph.roleManagement entity.
    /// </summary>
    public class EntitlementManagementRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the roleAssignments property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentScheduleInstancesRequestBuilder RoleAssignmentScheduleInstances { get =>
            new RoleAssignmentScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentScheduleRequestsRequestBuilder RoleAssignmentScheduleRequests { get =>
            new RoleAssignmentScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentSchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleAssignmentSchedulesRequestBuilder RoleAssignmentSchedules { get =>
            new RoleAssignmentSchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleDefinitions property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleEligibilityScheduleInstancesRequestBuilder RoleEligibilityScheduleInstances { get =>
            new RoleEligibilityScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleEligibilityScheduleRequestsRequestBuilder RoleEligibilityScheduleRequests { get =>
            new RoleEligibilityScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilitySchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public RoleEligibilitySchedulesRequestBuilder RoleEligibilitySchedules { get =>
            new RoleEligibilitySchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new EntitlementManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntitlementManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/entitlementManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new EntitlementManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntitlementManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/entitlementManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for roleManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateDeleteRequestInformation(Action<EntitlementManagementRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EntitlementManagementRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Container for roles and assignments for entitlement management resources.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateGetRequestInformation(Action<EntitlementManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EntitlementManagementRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in roleManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreatePatchRequestInformation(RbacApplication body, Action<EntitlementManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new EntitlementManagementRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for roleManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task DeleteAsync(Action<EntitlementManagementRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Container for roles and assignments for entitlement management resources.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<RbacApplication> GetAsync(Action<EntitlementManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RbacApplication>(requestInfo, RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in roleManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<RbacApplication> PatchAsync(RbacApplication body, Action<EntitlementManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RbacApplication>(requestInfo, RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EntitlementManagementRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new entitlementManagementRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public EntitlementManagementRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Container for roles and assignments for entitlement management resources.
        /// </summary>
        public class EntitlementManagementRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EntitlementManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EntitlementManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EntitlementManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new entitlementManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EntitlementManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EntitlementManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new entitlementManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public EntitlementManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
