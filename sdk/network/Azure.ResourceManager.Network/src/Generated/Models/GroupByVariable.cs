// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Define user session group by clause variables. </summary>
    public partial class GroupByVariable
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

        /// <summary> Initializes a new instance of <see cref="GroupByVariable"/>. </summary>
        /// <param name="variableName"> User Session clause variable. </param>
        public GroupByVariable(ApplicationGatewayFirewallUserSessionVariable variableName)
        {
            VariableName = variableName;
        }

        /// <summary> Initializes a new instance of <see cref="GroupByVariable"/>. </summary>
        /// <param name="variableName"> User Session clause variable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GroupByVariable(ApplicationGatewayFirewallUserSessionVariable variableName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VariableName = variableName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GroupByVariable"/> for deserialization. </summary>
        internal GroupByVariable()
        {
        }

        /// <summary> User Session clause variable. </summary>
        public ApplicationGatewayFirewallUserSessionVariable VariableName { get; set; }
    }
}
