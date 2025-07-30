using CV.Models;

namespace CV.Interface
{
    public interface ICvService
    {
        HomeInfo GetHomeInfo();
        AboutInfo GetAboutInfo();
        IEnumerable<ExperienceItem> GetExperience();
        IEnumerable<ProjectItem> GetProjects();
        IEnumerable<string> GetSkills();
        EducationInfo GetEducation();
        ContactInfo GetContactInfo();
    }
}
