﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Portal.DTO.Subscriptions
{
    public class TrackingStatPerUrl
    {
        public string ProjectId { get; set; }

        public string RedirectUrl { get; set; }

        public long Count { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }
    }
}