// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// For example, between &apos;2022-12-23&apos; and &apos;2023-01-05&apos;.
/// </summary>
public partial class ContainerServiceDateSpan : ProvisionableConstruct
{
    /// <summary>
    /// The start date of the date span.
    /// </summary>
    public BicepValue<DateTimeOffset> Start 
    {
        get { Initialize(); return _start!; }
        set { Initialize(); _start!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _start;

    /// <summary>
    /// The end date of the date span.
    /// </summary>
    public BicepValue<DateTimeOffset> End 
    {
        get { Initialize(); return _end!; }
        set { Initialize(); _end!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _end;

    /// <summary>
    /// Creates a new ContainerServiceDateSpan.
    /// </summary>
    public ContainerServiceDateSpan()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerServiceDateSpan.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _start = DefineProperty<DateTimeOffset>("Start", ["start"]);
        _end = DefineProperty<DateTimeOffset>("End", ["end"]);
    }
}
