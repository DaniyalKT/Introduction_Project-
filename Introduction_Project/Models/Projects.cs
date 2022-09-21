namespace Introduction_Project.Models
{
    public class Projects
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }

        public Projects(long id, string name, string description, string images)
        {
            Id = id;
            Name = name;
            Description = description;
            Images = images;
        }
    }
}
