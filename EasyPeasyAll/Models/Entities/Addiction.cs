namespace EasyPeasyAll.Models.Entities
{
    public class Addiction
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public string? IconUrl { get; set; }

        public int AddictionCategoryID { get; set; }

        public AddictionCategory Category { get; set; }
    }
}
