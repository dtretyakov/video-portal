﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Portal.BLL.Services
{
    public interface IPasswordService
    {
        Task<bool> ChangePasswordAsync(string userId, string newPassword, string oldPassword);

        Task ChangePasswordAsync(string userId, string newPassword);

        Task SetPasswordAsync(string userId, string passwordHash, string passwordSalt);
    }
}