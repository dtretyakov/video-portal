﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.Domain.ProcessedVideoContext;

namespace MiddleEnd.Worker.Abstract
{
    public interface ITaskChecker
    {
        void CheckTasks();

        void CheckTask(IProcessedEntity entity);
    }
}