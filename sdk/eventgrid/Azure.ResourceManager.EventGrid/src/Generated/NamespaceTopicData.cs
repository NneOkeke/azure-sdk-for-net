// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the NamespaceTopic data model.
    /// Namespace topic details.
    /// </summary>
    public partial class NamespaceTopicData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NamespaceTopicData"/>. </summary>
        public NamespaceTopicData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NamespaceTopicData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the namespace topic. </param>
        /// <param name="publisherType"> Publisher type of the namespace topic. </param>
        /// <param name="inputSchema"> This determines the format that is expected for incoming events published to the topic. </param>
        /// <param name="eventRetentionInDays">
        /// Event retention for the namespace topic expressed in days. The property default value is 1 day.
        /// Min event retention duration value is 1 day and max event retention duration value is 1 day.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NamespaceTopicData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NamespaceTopicProvisioningState? provisioningState, PublisherType? publisherType, EventInputSchema? inputSchema, int? eventRetentionInDays, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PublisherType = publisherType;
            InputSchema = inputSchema;
            EventRetentionInDays = eventRetentionInDays;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning state of the namespace topic. </summary>
        [WirePath("properties.provisioningState")]
        public NamespaceTopicProvisioningState? ProvisioningState { get; }
        /// <summary> Publisher type of the namespace topic. </summary>
        [WirePath("properties.publisherType")]
        public PublisherType? PublisherType { get; set; }
        /// <summary> This determines the format that is expected for incoming events published to the topic. </summary>
        [WirePath("properties.inputSchema")]
        public EventInputSchema? InputSchema { get; set; }
        /// <summary>
        /// Event retention for the namespace topic expressed in days. The property default value is 1 day.
        /// Min event retention duration value is 1 day and max event retention duration value is 1 day.
        /// </summary>
        [WirePath("properties.eventRetentionInDays")]
        public int? EventRetentionInDays { get; set; }
    }
}
