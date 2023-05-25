﻿using Institutional.Core.Core.Models;
using Institutional.Core.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institutional.Core.Repository.Concrete
{
    public class EFManagerRepository : EFRepository<Manager>, IManagerRepository
    {
        private readonly AppDbContext _appDbContext;
        public EFManagerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Manager> SignInAsync(Manager manager)
        {
            return await _appDbContext.Managers.FirstOrDefaultAsync(x => x.UserName == manager.UserName && x.Password == manager.Password);
        }
    }
}