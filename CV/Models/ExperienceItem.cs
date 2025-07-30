namespace CV.Models
{
    public class ExperienceItem
    {
        public string Company { get; }
        public string Role { get; }
        public string Duration { get; }
        public IEnumerable<string> Details { get; }

        public ExperienceItem(string company, string role, string duration, IEnumerable<string> details)
        {
            Company = company;
            Role = role;
            Duration = duration;
            Details = details;
        }
    }
}
