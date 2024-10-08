// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Indication whether or not the legacy Configuration API (v1) should be exposed on the API Management service. Value is optional but must be 'Enabled' or 'Disabled'. If 'Disabled', legacy Configuration API (v1) will not be available for self-hosted gateways. Default value is 'Enabled'. </summary>
    public readonly partial struct LegacyApiState : IEquatable<LegacyApiState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LegacyApiState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LegacyApiState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Legacy Configuration API (v1) is enabled for the service and self-hosted gateways can connect to it. </summary>
        public static LegacyApiState Enabled { get; } = new LegacyApiState(EnabledValue);
        /// <summary> Legacy Configuration API (v1) is disabled for the service and self-hosted gateways can not connect to it. </summary>
        public static LegacyApiState Disabled { get; } = new LegacyApiState(DisabledValue);
        /// <summary> Determines if two <see cref="LegacyApiState"/> values are the same. </summary>
        public static bool operator ==(LegacyApiState left, LegacyApiState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LegacyApiState"/> values are not the same. </summary>
        public static bool operator !=(LegacyApiState left, LegacyApiState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LegacyApiState"/>. </summary>
        public static implicit operator LegacyApiState(string value) => new LegacyApiState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LegacyApiState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LegacyApiState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
