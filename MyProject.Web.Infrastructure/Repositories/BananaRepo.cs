using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Web.Core.Interfaces;
using MyProject.Web.Core.Models;

namespace MyProject.Web.Infrastructure.Repositories
{
    public class BananaRepo : IBananaRepo
    {
        private readonly List<Banana> _myBananas = new List<Banana>();

        public async Task<List<Banana>> GetBanana(Guid id)
        {
            return await Task.Run(() =>
            {
                var bananaList = _myBananas.Where(banana => banana.Id.Equals(id)).ToList();
                return bananaList;
            });
        }

        public async Task<List<Banana>> GetAllBananas()
        {
            return await Task.Run(() => { return _myBananas; });
        }

        public async Task<Banana> DeleteBanana(Guid id)
        {
            return await Task.Run((() =>
            {
                var theBanana = _myBananas.First(banana => banana.Id == id);
                _myBananas.Remove(theBanana);
                return theBanana;
            }));
        }

        public async Task<Banana> UpdateBanana(Guid id, int length)
        {
            if (_myBananas.Any(banana => banana.Id == id))
                return await Task.Run(() =>
                {
                    var theBanana = _myBananas.First(banana => banana.Id == id);
                    theBanana.Length = length;
                    return theBanana;
                });
            else
                return await Task.Run(() =>
                {
                    var newBanana = new Banana
                    {
                        Id = id,
                        Length = length
                    };
                    _myBananas.Add(newBanana);
                    return newBanana;
                });
        }
    }
}