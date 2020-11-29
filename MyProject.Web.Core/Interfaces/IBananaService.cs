using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyProject.Web.Core.Models;

namespace MyProject.Web.Core.Interfaces
{
    public interface IBananaService
    {
        public Task<List<Banana>> GetBanana(Guid id);
        public Task<List<Banana>> GetAllBananas();

        public Task<Banana> DeleteBanana(Guid id);

        public Task<Banana> UpdateBanana(Guid id, int length);
    }
}