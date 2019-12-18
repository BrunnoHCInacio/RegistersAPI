﻿using RegisterPeoples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterPeoples.Interfaces
{
    public interface IPeopleRepository : IRepository<People>
    {
        Task<IEnumerable<People>> GetPeoplesAddress();
    }
}