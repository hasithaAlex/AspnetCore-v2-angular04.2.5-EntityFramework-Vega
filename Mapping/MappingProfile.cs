using AspnetCore_angular04_EntityFramework_Vega_2.Controllers.Resources;
using AspnetCore_angular04_EntityFramework_Vega_2.Models;
using AutoMapper;

namespace AspnetCore_angular04_EntityFramework_Vega_2.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {   
            CreateMap<Make, MakeResource>();    
            CreateMap<Model, ModelResource>();    
        }       
    }
}