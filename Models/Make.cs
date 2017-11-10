using System.Collections.Generic;

namespace AspnetCore_angular04_EntityFramework_Vega_2.Models
{
    public class Make
    {
        public Make()
        {
            Model = new Collection<Model>();
        }
        public int Id { get; set; } 
        public string Name { get; set; }    

        public ICollection<Model> Models { get; set; }    
    }
}