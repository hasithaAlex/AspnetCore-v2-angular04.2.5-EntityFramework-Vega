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
    public class FeatureController : Controller
    {
        private readonly VegaDbContext context;

        private readonly IMapper mapper;

        public FeatureController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }

    }
}