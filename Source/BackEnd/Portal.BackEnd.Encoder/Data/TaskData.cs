// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.Domain.BackendContext.Enum;

namespace Portal.BackEnd.Encoder.Data
{
    public class TaskData
    {
        public string Resource { get; set; }

        public string Id { get; set; }

        public TypeOfTask Type { get; set; }
    }
}