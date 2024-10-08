// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using System;
using System.ComponentModel;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Built-in Sql roles that you can assign to users, groups, service
/// principals, and managed identities.
/// </summary>
/// <param name="value">The ID value of the role.</param>
public readonly struct SqlBuiltInRole(string value) : IEquatable<SqlBuiltInRole>
{
    private readonly string _value = value ?? throw new ArgumentNullException(nameof(value));

    /// <summary>
    /// Lets you manage SQL databases, but not access to them. Also, you
    /// can&apos;t manage their security-related policies or their parent SQL
    /// servers.
    /// </summary>
    public static SqlBuiltInRole SqlDBContributor { get; } = new(SqlDBContributorValue);
    internal const string SqlDBContributorValue = "9b7fa17d-e63e-47b0-bb0a-15c516ac86ec";

    /// <summary>
    /// Lets you manage SQL Managed Instances and required network
    /// configuration, but can&apos;t give access to others.
    /// </summary>
    public static SqlBuiltInRole SqlManagedInstanceContributor { get; } = new(SqlManagedInstanceContributorValue);
    internal const string SqlManagedInstanceContributorValue = "4939a1f6-9ae0-4e48-a1e0-f2cbe897382d";

    /// <summary>
    /// Lets you manage the security-related policies of SQL servers and
    /// databases, but not access to them.
    /// </summary>
    public static SqlBuiltInRole SqlSecurityManager { get; } = new(SqlSecurityManagerValue);
    internal const string SqlSecurityManagerValue = "056cd41c-7e88-42e1-933e-88ba6a50c9c3";

    /// <summary>
    /// Lets you manage SQL servers and databases, but not access to them, and
    /// not their security-related policies.
    /// </summary>
    public static SqlBuiltInRole SqlServerContributor { get; } = new(SqlServerContributorValue);
    internal const string SqlServerContributorValue = "6d8ee4ec-f05a-4a1d-8b00-a9b17e38b437";

    /// <summary>
    /// Allows for read and write access to Azure resources for SQL Server on
    /// Arc-enabled servers.
    /// </summary>
    public static SqlBuiltInRole AzureConnectedSqlServerOnboarding { get; } = new(AzureConnectedSqlServerOnboardingValue);
    internal const string AzureConnectedSqlServerOnboardingValue = "e8113dce-c529-4d33-91fa-e9b972617508";

    /// <summary>
    /// Try to get the name of a built-in Sql role from its ID value.
    /// </summary>
    /// <param name="value">The role value.</param>
    /// <returns>
    /// The name of the built-in Sql role if known, otherwise the ID will be returned.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string GetBuiltInRoleName(SqlBuiltInRole value) =>
        value._value switch
        {
            SqlDBContributorValue => nameof(SqlDBContributor),
            SqlManagedInstanceContributorValue => nameof(SqlManagedInstanceContributor),
            SqlSecurityManagerValue => nameof(SqlSecurityManager),
            SqlServerContributorValue => nameof(SqlServerContributor),
            AzureConnectedSqlServerOnboardingValue => nameof(AzureConnectedSqlServerOnboarding),
            _ => value._value
        };

    /// <summary>
    /// Determines if two SqlBuiltInRole values are the same.
    /// </summary>
    /// <param name="left">The first SqlBuiltInRole to compare.</param>
    /// <param name="right">The second SqlBuiltInRole to compare.</param>
    /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are the same; otherwise, false.</returns>
    public static bool operator ==(SqlBuiltInRole left, SqlBuiltInRole right) => left.Equals(right);

    /// <summary>
    /// Determines if two SqlBuiltInRole values are different.
    /// </summary>
    /// <param name="left">The first SqlBuiltInRole to compare.</param>
    /// <param name="right">The second SqlBuiltInRole to compare.</param>
    /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are different; otherwise, false.</returns>
    public static bool operator !=(SqlBuiltInRole left, SqlBuiltInRole right) => !left.Equals(right);

    /// <summary>
    /// Converts a string to a SqlBuiltInRole.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator SqlBuiltInRole(string value) => new(value);

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object? obj) => obj is SqlBuiltInRole other && Equals(other);

    /// <inheritdoc/>
    public bool Equals(SqlBuiltInRole other) => string.Equals(_value, other._value, StringComparison.Ordinal);

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public override string ToString() => _value;
}
