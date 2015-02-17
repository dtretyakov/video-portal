﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using MongoRepository;
using Portal.DAL.Context;
using Portal.DAL.Entities.QueryObject;

namespace Portal.DAL.Statistics
{
    public interface IStatisticsRepository<T> : ITableRepository<T> where T : IEntity
    {
        IEnumerable<T> GetStatEntities(StatQueryObject queryObject);
    }
}