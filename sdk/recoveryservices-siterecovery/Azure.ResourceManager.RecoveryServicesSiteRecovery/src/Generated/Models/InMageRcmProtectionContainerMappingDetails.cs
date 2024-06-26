// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm provider specific container mapping details. </summary>
    public partial class InMageRcmProtectionContainerMappingDetails : ProtectionContainerMappingProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmProtectionContainerMappingDetails"/>. </summary>
        internal InMageRcmProtectionContainerMappingDetails()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmProtectionContainerMappingDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="enableAgentAutoUpgrade"> A value indicating whether the flag for enable agent auto upgrade. </param>
        internal InMageRcmProtectionContainerMappingDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string enableAgentAutoUpgrade) : base(instanceType, serializedAdditionalRawData)
        {
            EnableAgentAutoUpgrade = enableAgentAutoUpgrade;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> A value indicating whether the flag for enable agent auto upgrade. </summary>
        public string EnableAgentAutoUpgrade { get; }
    }
}
