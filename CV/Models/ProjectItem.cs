namespace CV.Models
{
    public class ProjectItem
    {
        public string Title { get; }
        public string Description { get; }
        public string Technologies { get; }
        public string? RepoUrl { get; }
        public string? LiveUrl { get; }

        public ProjectItem(string title, string description, string technologies, string? repoUrl = null, string? liveUrl = null)
        {
            Title = title;
            Description = description;
            Technologies = technologies;
            RepoUrl = repoUrl;
            LiveUrl = liveUrl;
        }
    }
}
