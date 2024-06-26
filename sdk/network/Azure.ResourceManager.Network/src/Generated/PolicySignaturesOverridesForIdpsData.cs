// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the PolicySignaturesOverridesForIdps data model.
    /// Contains all specific policy signatures overrides for the IDPS
    /// </summary>
    public partial class PolicySignaturesOverridesForIdpsData
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

        /// <summary> Initializes a new instance of <see cref="PolicySignaturesOverridesForIdpsData"/>. </summary>
        public PolicySignaturesOverridesForIdpsData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicySignaturesOverridesForIdpsData"/>. </summary>
        /// <param name="name"> Contains the name of the resource (default). </param>
        /// <param name="id"> Will contain the resource id of the signature override resource. </param>
        /// <param name="resourceType"> Will contain the type of the resource: Microsoft.Network/firewallPolicies/intrusionDetectionSignaturesOverrides. </param>
        /// <param name="properties"> Will contain the properties of the resource (the actual signature overrides). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicySignaturesOverridesForIdpsData(string name, ResourceIdentifier id, ResourceType? resourceType, PolicySignaturesOverridesForIdpsProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Id = id;
            ResourceType = resourceType;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Contains the name of the resource (default). </summary>
        public string Name { get; set; }
        /// <summary> Will contain the resource id of the signature override resource. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Will contain the type of the resource: Microsoft.Network/firewallPolicies/intrusionDetectionSignaturesOverrides. </summary>
        public ResourceType? ResourceType { get; set; }
        /// <summary> Will contain the properties of the resource (the actual signature overrides). </summary>
        internal PolicySignaturesOverridesForIdpsProperties Properties { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Signatures
        {
            get
            {
                if (Properties is null)
                    Properties = new PolicySignaturesOverridesForIdpsProperties();
                return Properties.Signatures;
            }
        }
    }
}
