using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyProject.Web.Core.Interfaces;
using MyProject.Web.Core.Models;

namespace MyProject.Web.Core.Services
{
    public class BananaService : IBananaService
    {
        private IBananaRepo _repository;

        public BananaService(IBananaRepo repository)
        {
            _repository = repository;
        }


        public async Task<List<Banana>> GetBanana(Guid id)
        {
            return await _repository.GetBanana(id);
        }

        public async Task<List<Banana>> GetAllBananas()
        {
            return await _repository.GetAllBananas();
        }

        public async Task<Banana> DeleteBanana(Guid id)
        {
            return await _repository.DeleteBanana(id);
        }

        public async Task<Banana> UpdateBanana(Guid id, int length)
        {
            return await _repository.UpdateBanana(id, length);
        }
    }
}