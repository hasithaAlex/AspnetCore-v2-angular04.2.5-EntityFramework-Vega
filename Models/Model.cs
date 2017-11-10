namespace AspnetCore_angular04_EntityFramework_Vega_2.Models
{
    public class Model
    {
        public int Id { get; set; } 
        public string Name { get; set; }    

        public Make Make { get; set; }
        public int MakeId { get; set; }        
    }
}