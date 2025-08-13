namespace Pet_App_workshop.Models
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string Name {get;set;}
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string Discription { get; set; }
        //public string? Image { get; set; }
        public string? Location { get; set; }
    }
}
