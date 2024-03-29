﻿using Gaia.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using URF.Core.Abstractions.Trackable;
using URF.Core.Services;

namespace Gaia.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(ITrackableRepository<User> repository) : base(repository)
        {
        }
    }
}
