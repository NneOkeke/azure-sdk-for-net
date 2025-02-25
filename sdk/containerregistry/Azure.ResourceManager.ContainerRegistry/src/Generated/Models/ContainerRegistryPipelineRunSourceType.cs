// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of the source. </summary>
    public readonly partial struct ContainerRegistryPipelineRunSourceType : IEquatable<ContainerRegistryPipelineRunSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryPipelineRunSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryPipelineRunSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureStorageBlobValue = "AzureStorageBlob";

        /// <summary> AzureStorageBlob. </summary>
        public static ContainerRegistryPipelineRunSourceType AzureStorageBlob { get; } = new ContainerRegistryPipelineRunSourceType(AzureStorageBlobValue);
        /// <summary> Determines if two <see cref="ContainerRegistryPipelineRunSourceType"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryPipelineRunSourceType left, ContainerRegistryPipelineRunSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryPipelineRunSourceType"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryPipelineRunSourceType left, ContainerRegistryPipelineRunSourceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerRegistryPipelineRunSourceType"/>. </summary>
        public static implicit operator ContainerRegistryPipelineRunSourceType(string value) => new ContainerRegistryPipelineRunSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryPipelineRunSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryPipelineRunSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
