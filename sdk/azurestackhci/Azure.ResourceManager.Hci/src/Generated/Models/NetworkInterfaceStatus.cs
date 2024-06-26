// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The observed state of network interfaces. </summary>
    public partial class NetworkInterfaceStatus
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

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceStatus"/>. </summary>
        internal NetworkInterfaceStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceStatus"/>. </summary>
        /// <param name="errorCode"> NetworkInterface provisioning error code. </param>
        /// <param name="errorMessage"> Descriptive error message. </param>
        /// <param name="provisioningStatus"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkInterfaceStatus(string errorCode, string errorMessage, NetworkInterfaceStatusProvisioningStatus provisioningStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ProvisioningStatus = provisioningStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> NetworkInterface provisioning error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Descriptive error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Gets the provisioning status. </summary>
        public NetworkInterfaceStatusProvisioningStatus ProvisioningStatus { get; }
    }
}
