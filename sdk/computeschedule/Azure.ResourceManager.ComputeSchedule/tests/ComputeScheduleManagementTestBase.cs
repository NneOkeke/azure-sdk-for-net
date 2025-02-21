// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ComputeSchedule.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Azure.ResourceManager.ComputeSchedule.Tests
{
    public class ComputescheduleManagementTestBase : ManagementRecordedTestBase<ComputescheduleManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected SubscriptionResource DefaultSubscription { get; private set; }
        protected AzureLocation Location { get; private set; }
        protected GenericResourceCollection _genericResourceCollection;
        protected ResourceGroupResource DefaultResourceGroupResource;

        protected ComputescheduleManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected ComputescheduleManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                Client = GetArmClient();
                SubscriptionResource subIdRes = await Client.GetDefaultSubscriptionAsync();
                DefaultSubscription = Client.GetSubscriptionResource(subIdRes.Id);
                DefaultResourceGroupResource = await DefaultSubscription.GetResourceGroupAsync(TestEnvironment.ResourceGroup);
                Location = DefaultResourceGroupResource.Data.Location;
                _genericResourceCollection = Client.GetGenericResources();
            }
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        protected static SubscriptionResource GenerateSubscriptionResource(ArmClient client, string subid)
        {
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subid);
            return client.GetSubscriptionResource(subscriptionResourceId);
        }

        #region AA Operations
        // Create/UpdateAutoAction
        protected static async Task<ArmOperation<AutoActionResource>> TestCreateOrUpdateAutoAction(string subid, string rgName, string aaName, AutoActionData aaData ,ArmClient client)
        {
            SubscriptionResource subscriptionResource = GenerateSubscriptionResource(client, subid);
            ArmOperation<AutoActionResource> result;

            try
            {
                ResourceGroupResource rg = await subscriptionResource.GetResourceGroups().GetAsync(rgName);
                AutoActionCollection collection = rg.GetAutoActions();

                result = await collection.CreateOrUpdateAsync(WaitUntil.Completed, aaName, aaData);

                var resultItem = result.Value;
                Console.WriteLine($"Succeeded on id: {resultItem.Id}");
                Console.WriteLine($"Succeeded on id: {resultItem}");
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine($"Request failed with ErrorCode:{ex.ErrorCode} and ErrorMessage: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                throw;
            }
            return result;
        }
        #endregion
    }
}
