// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventHubs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubAuthorizationRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_EventHubAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleCreate.json
            // this example is just showing the usage of "EventHubs_CreateOrUpdateAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubAuthorizationRuleResource
            EventHubAuthorizationRuleCollection collection = eventHub.GetEventHubAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-Authrules-2513";
            EventHubsAuthorizationRuleData data = new EventHubsAuthorizationRuleData
            {
                Rights = { EventHubsAccessRight.Listen, EventHubsAccessRight.Send },
            };
            ArmOperation<EventHubAuthorizationRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationRuleName, data);
            EventHubAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_EventHubAuthorizationRuleGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleGet.json
            // this example is just showing the usage of "EventHubs_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubAuthorizationRuleResource
            EventHubAuthorizationRuleCollection collection = eventHub.GetEventHubAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-Authrules-2513";
            EventHubAuthorizationRuleResource result = await collection.GetAsync(authorizationRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_EventHubAuthorizationRuleListAll()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleListAll.json
            // this example is just showing the usage of "EventHubs_ListAuthorizationRules" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubAuthorizationRuleResource
            EventHubAuthorizationRuleCollection collection = eventHub.GetEventHubAuthorizationRules();

            // invoke the operation and iterate over the result
            await foreach (EventHubAuthorizationRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventHubsAuthorizationRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_EventHubAuthorizationRuleGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleGet.json
            // this example is just showing the usage of "EventHubs_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubAuthorizationRuleResource
            EventHubAuthorizationRuleCollection collection = eventHub.GetEventHubAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-Authrules-2513";
            bool result = await collection.ExistsAsync(authorizationRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_EventHubAuthorizationRuleGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubAuthorizationRuleGet.json
            // this example is just showing the usage of "EventHubs_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-960";
            string eventHubName = "sdk-EventHub-532";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubAuthorizationRuleResource
            EventHubAuthorizationRuleCollection collection = eventHub.GetEventHubAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-Authrules-2513";
            NullableResponse<EventHubAuthorizationRuleResource> response = await collection.GetIfExistsAsync(authorizationRuleName);
            EventHubAuthorizationRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventHubsAuthorizationRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
