// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Secret definition. </summary>
    public partial class ContainerAppWritableSecret
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppWritableSecret"/>. </summary>
        public ContainerAppWritableSecret()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppWritableSecret"/>. </summary>
        /// <param name="name"> Secret Name. </param>
        /// <param name="value"> Secret Value. </param>
        /// <param name="identity"> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </param>
        /// <param name="keyVaultUri"> Azure Key Vault URL pointing to the secret referenced by the container app. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppWritableSecret(string name, string value, string identity, Uri keyVaultUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            Identity = identity;
            KeyVaultUri = keyVaultUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Secret Name. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> Secret Value. </summary>
        [WirePath("value")]
        public string Value { get; set; }
        /// <summary> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </summary>
        [WirePath("identity")]
        public string Identity { get; set; }
        /// <summary> Azure Key Vault URL pointing to the secret referenced by the container app. </summary>
        [WirePath("keyVaultUrl")]
        public Uri KeyVaultUri { get; set; }
    }
}
