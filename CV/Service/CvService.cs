using CV.Interface;
using CV.Models;

namespace CV.Service
{
    public class CvService : ICvService
    {
        public HomeInfo GetHomeInfo() => new HomeInfo
        {
            Name = "Ugwuja Mmesoma",
            Tagline = "C# .Net Software Developer || .Net Core"
        };

        public AboutInfo GetAboutInfo() => new AboutInfo
        {
            Summary = "I’m a self‑motivated and highly versatile C# Developer with strong commitment to continuous improvement and a passion for world‑class tech services."
        };

        public IEnumerable<ExperienceItem> GetExperience() => new[]
        {
            new ExperienceItem(
                "Trustesse Limited",
                "Backend Developer",
                "June 2025 – Present",
                new[]
                {
                    "Collaborate with front‑end developers, designers, and product managers.",
                    "Write clean, scalable, well‑documented code.",
                    "Integrate APIs and manage database interactions.",
                    "Participate in code reviews and agile development."
                }),
            new ExperienceItem(
                "Software Development (Contract)",
                "Contract Developer",
                "Jan 2024 – May 2025",
                new[]
                {
                    "Designed & maintained robust, scalable APIs using .NET Framework.",
                    "Collaborated with product managers on client projects.",
                    "Revised, refactored, and debugged code; unit testing & DB maintenance."
                }),
            new ExperienceItem(
                "ALX",
                "Associate Software Developer",
                "Jan 2023 – Dec 2023",
                new[]
                {
                    "Built .NET applications and collaborated on requirements."
                })
        };

        public IEnumerable<ProjectItem> GetProjects() => new[]
        {
            new ProjectItem(
                "Music App",
                "Multi‑role music application with Admin, Artist, and User accounts; features JWT auth, portfolio, bookings, SignalR chat, Stripe payments, reviews & analytics dashboard.",
                "ASP.NET Core, EF Core, SQL Server, SignalR, Stripe, JWT",
                "https://github.com/Smartvik2/MusicApp"
            ),
            new ProjectItem(
                "Church Web App",
                "ASP.NET Core Web API backend for media uploads and auth; deployed on Azure.",
                "C#, .NET Framework, Azure, SQL Server, MailKit",
                "https://github.com/Smartvik2/DG.git",
                "http://www.divinegraceunec.com.ng"
            ),
            new ProjectItem(
                "StripePay API",
                "Secure ASP.NET Core Web API integrating Stripe for payments with initialization, verification, and webhooks.",
                "C#, .NET Framework, Stripe, SQL Server",
                "https://github.com/Smartvik2/PaymentGateway.git"
            ),
            new ProjectItem(
                "Angry Bird Game",
                "2D desktop game in C# WinForms featuring gravity physics, collision detection, and scoring.",
                "C#, WinForms, GDI+",
                "https://github.com/Smartvik2/AngryBirds-Game.git"
            )
        };

        public IEnumerable<string> GetSkills() => new[]
        {
            "C#, ASP.NET Core API",
            "ASP.NET MVC, Blazor",
            "Entity Framework, SQL Server",
            "Redis",
            "JavaScript, HTML, CSS",
            "Azure, GitHub",
            "Agile & Jira",
            "OOP Principles, Analytical Thinking, Team Collaboration"
        };

        public EducationInfo GetEducation() => new EducationInfo
        {
            Institution = "University of Nigeria, Enugu Campus",
            Degree = "Bachelor of Medical Radiography",
            Years = "2019 – 2024"
        };

        public ContactInfo GetContactInfo() => new ContactInfo
        {
            Address = "21 Oyesiku Street, Alapere, Ketu, Lagos State, Nigeria",
            Phone = "+234 703 501 784",
            Email = "excellentmmesoma6@gmail.com",
            GitHub = "https://github.com/Smartvik2"
        };
    }
}
