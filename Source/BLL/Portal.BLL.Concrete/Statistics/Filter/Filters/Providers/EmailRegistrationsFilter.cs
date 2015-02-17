﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.BLL.Statistics.Filter;
using Portal.Domain.StatisticContext;

namespace Portal.BLL.Concrete.Statistics.Filter.Filters.Providers
{
    public class EmailRegistrationsFilter : StatFilterBase<IStatUserRegistrationFilter>, IStatUserRegistrationFilter
    {
        public void Call(DomainStatUserRegistration domainStatUserRegistration, DomainReport domainReport)
        {
            if (domainStatUserRegistration.IdentityProvider == "Email")
            {
                domainReport.EmailRegistrations++;
            }
            if (Filter != null)
            {
                Filter.Call(domainStatUserRegistration, domainReport);
            }
        }
    }
}