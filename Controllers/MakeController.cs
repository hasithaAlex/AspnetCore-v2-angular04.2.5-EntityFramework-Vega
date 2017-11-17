using System.Collections.Generic;
using System.Threading.Tasks;
using AspnetCore_angular04_EntityFramework_Vega_2.Controllers.Resources;
using AspnetCore_angular04_EntityFramework_Vega_2.Models;
using AspnetCore_angular04_EntityFramework_Vega_2.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspnetCore_angular04_EntityFramework_Vega_2.Controllers
{
    public class MakeController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public MakeController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }

        [HttpGet("/api/makes-using-autoMapper")]
        public async Task<IEnumerable<MakeResource>> GetMakesUsingAutoMapper()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>,List<MakeResource>>(makes);
        }
    }
}