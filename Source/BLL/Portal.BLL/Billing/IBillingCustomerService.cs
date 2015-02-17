﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Portal.Domain.BillingContext;

namespace Portal.BLL.Billing
{
    public interface IBillingCustomerService
    {
        Task<DomainCustomer> GetAsync(DomainCustomer customer);

        Task<DomainCustomer> AddAsync(DomainCustomerCreateOptions options);
    }
}