namespace AspnetCore_angular04_EntityFramework_Vega_2.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }

        public bool IsRegistered { get; set; }
    }
}