using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Web.Core.Interfaces;
using MyProject.Web.Core.Models;

namespace MyProject.Web.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BananasController : Controller
    {
        private readonly IBananaService _service;
        
        public BananasController(IBananaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Banana>> GetBanana([FromQuery] Guid guid)
        {
            if (guid == new Guid("00000000-0000-0000-0000-000000000000"))
                return await _service.GetAllBananas();
            else
                return await _service.GetBanana(guid);
        }

        //todo
        /*
         * ~ READ ABOUT URL PARAMETERS
         * ~ READ ABOUT ROUTE PARAMETERS
         * ??? READ ABOUT REST
         * ~ CREATE SERVICE FOR BANANA
         * ~ CREATE REPOSITORY FOR BANANA
         * ~ INSTALL MYSQL
         * READ ABOUT DOT NET Data Context Entity Framework Core (U ARE GONNA NEED Pomelo from Nuget to be able to inject a MySql Data Context)
         * Get From Nuget : (Microcost.EntityFrameworkCore Microcost.EntityFrameworkCore.Tools, Microcost.EntityFrameworkCore.Tools.DotNet) ~~~ in infrastructure presupun
         * DotNetTools ???
         * CREATE Migration for your model
         * RUN Migration for your model
         * READ ABOUT MIGRATIONS and how they work
         */
        [HttpPost]
        [Route("/[controller]/add")]
        public async Task<Banana> AddBanana([FromBody] Guid id,[FromQuery]int length)
        {
            return await _service.UpdateBanana(id, length);
        }
        [HttpDelete]
        [Route("/[controller]/delete")]
        public async Task<Banana> DeleteBanana([FromBody] Guid id)
        {
            return await _service.DeleteBanana(id);
        }
        /*
        [HttpPost]
        [Route("/[controller]/crazy")]
        public ActionResult<Banana> GetCrazyBanana([FromBody] int length)
        {
            return new Banana
            {
                Length = length
            };
        }
        */
    }
}