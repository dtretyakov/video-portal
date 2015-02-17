﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Portal.Domain.SubscriptionContext;

namespace Portal.BLL.Subscriptions
{
    public interface IPendingClientService
    {
        Task<DomainPendingClient> AddAsync(DomainPendingClient company);

        Task<DomainPendingClient> GetAndDeleteAsync(string id);
    }
}