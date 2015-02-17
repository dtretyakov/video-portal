﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace Asp.Infrastructure.Validation
{
    /// <summary>
    ///     Zip code validation attribute.
    /// </summary>
    public class ZipCodeAttribute : RegularExpressionAttribute
    {
        public ZipCodeAttribute() : base(@"^[a-zA-Z0-9\s-]{5,10}$")
        {
        }
    }
}