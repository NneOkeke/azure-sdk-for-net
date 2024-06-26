// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Display of the operation. </summary>
    public partial class ResourceOperationDisplay
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

        /// <summary> Initializes a new instance of <see cref="ResourceOperationDisplay"/>. </summary>
        internal ResourceOperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceOperationDisplay"/>. </summary>
        /// <param name="provider"> The resource provider name. </param>
        /// <param name="resource"> The resource name. </param>
        /// <param name="operation"> The operation. </param>
        /// <param name="description"> The description of the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceOperationDisplay(string provider, string resource, string operation, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource provider name. </summary>
        public string Provider { get; }
        /// <summary> The resource name. </summary>
        public string Resource { get; }
        /// <summary> The operation. </summary>
        public string Operation { get; }
        /// <summary> The description of the operation. </summary>
        public string Description { get; }
    }
}
