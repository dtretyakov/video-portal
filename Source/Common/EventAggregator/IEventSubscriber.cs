﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace EventAggregator
{
    public interface IEventSubscriber
    {
        Task SubscribeEvent();
    }
}