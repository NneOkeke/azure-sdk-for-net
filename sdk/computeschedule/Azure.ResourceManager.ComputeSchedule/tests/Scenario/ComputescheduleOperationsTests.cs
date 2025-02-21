// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using System.Xml;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.ComputeSchedule.Models;
using NUnit.Framework;
using Azure.ResourceManager.Resources.Models;
using ResourceType = Azure.ResourceManager.ComputeSchedule.Models.ResourceType;

namespace Azure.ResourceManager.ComputeSchedule.Tests.Scenario
{
    public class ComputescheduleOperationsTests : ComputescheduleManagementTestBase
    {
        public ComputescheduleOperationsTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        [TestCase, Order(1)]
        [RecordedTest]
        public async Task TestCreateAutoAction()
        {
            string autoactionName = "dotnetsdk-autoaction-two";
            string rgName = DefaultResourceGroupResource.Data.Name;
            string subid = DefaultSubscription.Id.Name;

            DateTimeOffset autoactionStartDate = DateTimeOffset.UtcNow.AddDays(1);
            DateTimeOffset autoactionEndDate = DateTimeOffset.UtcNow.AddDays(15);

            AutoActionData data = new(new AzureLocation(Location))
            {
                Properties = new AutoActionProperties(ResourceType.VirtualMachine, ActionType.Start, autoactionStartDate,
                new AutoActionSchedule(
                        new TimeSpan(9, 0, 0),
                        TimeZoneInfo.Utc.Id,
                        new WeekDay[] { WeekDay.All },
                        new Month[] { Month.All },
                        [],
                        new ScheduledActionExecutionParameterDetail
                        {
                            RetryPolicy = new UserRequestRetryPolicy
                            {
                                RetryCount = 2,
                                RetryWindowInMinutes = 30,
                            },
                        },
                        ScheduledActionDeadlineType.InitiateAt),
                        Array.Empty<NotificationProperties>())
                {
                    EndOn = autoactionEndDate,
                    Disabled = true,
                },
                Tags =
                {
                    ["name"] = "dotnetsdktest",
                },
            };

            await TestCreateOrUpdateAutoAction(subid, rgName, autoactionName, data, Client);
        }
    }
}
