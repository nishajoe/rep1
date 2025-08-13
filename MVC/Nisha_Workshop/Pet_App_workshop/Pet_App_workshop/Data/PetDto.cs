namespace Pet_App_workshop.Data
{
    public class PetDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string Discription { get; set; } 
        //public IFormFile Image { get; set; }
        public string? Location { get; set; }
    }
}
