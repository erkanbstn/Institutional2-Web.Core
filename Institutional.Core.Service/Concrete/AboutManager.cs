﻿using Institutional.Core.Core.Models;
using Institutional.Core.Repository.Abstract;
using Institutional.Core.Service.Abstract;
namespace Institutional.Core.Service.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task DeleteAsync(About t)
        {
            await _aboutRepository.DeleteAsync(t);
        }

        public async Task<List<About>> GetAboutListWithType(string Type)
        {
            return await _aboutRepository.GetAboutListWithType(Type);
        }

        public async Task<About> GetByIdAsync(int id)
        {
            return await _aboutRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(About t)
        {
            await _aboutRepository.InsertAsync(t);
        }

        public async Task<List<About>> ToListAsync()
        {
            return await _aboutRepository.ToListAsync();
        }

        public async Task UpdateAsync(About t)
        {
            await _aboutRepository.UpdateAsync(t);
        }
    }
}
