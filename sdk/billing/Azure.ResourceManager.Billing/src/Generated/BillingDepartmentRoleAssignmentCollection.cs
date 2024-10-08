// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingDepartmentRoleAssignmentResource"/> and their operations.
    /// Each <see cref="BillingDepartmentRoleAssignmentResource"/> in the collection will belong to the same instance of <see cref="BillingDepartmentResource"/>.
    /// To get a <see cref="BillingDepartmentRoleAssignmentCollection"/> instance call the GetBillingDepartmentRoleAssignments method from an instance of <see cref="BillingDepartmentResource"/>.
    /// </summary>
    public partial class BillingDepartmentRoleAssignmentCollection : ArmCollection, IEnumerable<BillingDepartmentRoleAssignmentResource>, IAsyncEnumerable<BillingDepartmentRoleAssignmentResource>
    {
        private readonly ClientDiagnostics _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics;
        private readonly BillingRoleAssignmentsRestOperations _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingDepartmentRoleAssignmentCollection"/> class for mocking. </summary>
        protected BillingDepartmentRoleAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingDepartmentRoleAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingDepartmentRoleAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingDepartmentRoleAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingDepartmentRoleAssignmentResource.ResourceType, out string billingDepartmentRoleAssignmentBillingRoleAssignmentsApiVersion);
            _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient = new BillingRoleAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingDepartmentRoleAssignmentBillingRoleAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingDepartmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingDepartmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a billing role assignment. The operation is supported only for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_CreateOrUpdateByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="data"> The properties of the billing role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BillingDepartmentRoleAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string billingRoleAssignmentName, BillingRoleAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateOrUpdateByDepartmentAsync(Id.Parent.Name, Id.Name, billingRoleAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation<BillingDepartmentRoleAssignmentResource>(new BillingDepartmentRoleAssignmentOperationSource(Client), _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics, Pipeline, _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateCreateOrUpdateByDepartmentRequest(Id.Parent.Name, Id.Name, billingRoleAssignmentName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a billing role assignment. The operation is supported only for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_CreateOrUpdateByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="data"> The properties of the billing role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BillingDepartmentRoleAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string billingRoleAssignmentName, BillingRoleAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateOrUpdateByDepartment(Id.Parent.Name, Id.Name, billingRoleAssignmentName, data, cancellationToken);
                var operation = new BillingArmOperation<BillingDepartmentRoleAssignmentResource>(new BillingDepartmentRoleAssignmentOperationSource(Client), _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics, Pipeline, _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateCreateOrUpdateByDepartmentRequest(Id.Parent.Name, Id.Name, billingRoleAssignmentName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a role assignment for the caller on a department. The operation is supported only for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> is null. </exception>
        public virtual async Task<Response<BillingDepartmentRoleAssignmentResource>> GetAsync(string billingRoleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.GetByDepartmentAsync(Id.Parent.Name, Id.Name, billingRoleAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a role assignment for the caller on a department. The operation is supported only for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> is null. </exception>
        public virtual Response<BillingDepartmentRoleAssignmentResource> Get(string billingRoleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.GetByDepartment(Id.Parent.Name, Id.Name, billingRoleAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the role assignments for the caller on a department. The operation is supported for billing accounts of type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_ListByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingDepartmentRoleAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingDepartmentRoleAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateListByDepartmentRequest(Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateListByDepartmentNextPageRequest(nextLink, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingDepartmentRoleAssignmentResource(Client, BillingRoleAssignmentData.DeserializeBillingRoleAssignmentData(e)), _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics, Pipeline, "BillingDepartmentRoleAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the role assignments for the caller on a department. The operation is supported for billing accounts of type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_ListByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingDepartmentRoleAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingDepartmentRoleAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateListByDepartmentRequest(Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.CreateListByDepartmentNextPageRequest(nextLink, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingDepartmentRoleAssignmentResource(Client, BillingRoleAssignmentData.DeserializeBillingRoleAssignmentData(e)), _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics, Pipeline, "BillingDepartmentRoleAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string billingRoleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.GetByDepartmentAsync(Id.Parent.Name, Id.Name, billingRoleAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string billingRoleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.GetByDepartment(Id.Parent.Name, Id.Name, billingRoleAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingDepartmentRoleAssignmentResource>> GetIfExistsAsync(string billingRoleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.GetByDepartmentAsync(Id.Parent.Name, Id.Name, billingRoleAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingDepartmentRoleAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/departments/{departmentName}/billingRoleAssignments/{billingRoleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingRoleAssignments_GetByDepartment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingDepartmentRoleAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingRoleAssignmentName"> The ID that uniquely identifies a role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingRoleAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingRoleAssignmentName"/> is null. </exception>
        public virtual NullableResponse<BillingDepartmentRoleAssignmentResource> GetIfExists(string billingRoleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingRoleAssignmentName, nameof(billingRoleAssignmentName));

            using var scope = _billingDepartmentRoleAssignmentBillingRoleAssignmentsClientDiagnostics.CreateScope("BillingDepartmentRoleAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingDepartmentRoleAssignmentBillingRoleAssignmentsRestClient.GetByDepartment(Id.Parent.Name, Id.Name, billingRoleAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingDepartmentRoleAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new BillingDepartmentRoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingDepartmentRoleAssignmentResource> IEnumerable<BillingDepartmentRoleAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingDepartmentRoleAssignmentResource> IAsyncEnumerable<BillingDepartmentRoleAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
