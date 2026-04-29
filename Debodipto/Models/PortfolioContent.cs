namespace PortfolioSite.Models;

public static class PortfolioContent
{
    public static PortfolioViewModel Create() =>
        new()
        {
            Name = "Debodipto Samadder",
            Headline = "Full Stack Developer, System Engineer, and AI-Driven Builder",
            Summary = "I design reliable digital products across backend engineering, infrastructure, and intelligent workflows. My work blends Django, ASP.NET MVC, system engineering, and practical AI tooling to build polished applications that solve real business needs.",
            PhotoPath = "~/images/debodipto-samadder.jpg",
            Highlights =
            [
                "Full stack developer focused on Django, Django REST Framework, and ASP.NET MVC.",
                "System engineer with hands-on experience in Linux, networking, hosting, and server fundamentals.",
                "AI-enabled problem solver using ChatGPT, GitHub Copilot, and OpenAI Codex in day-to-day delivery."
            ],
            FeaturedProject = new FeaturedProject
            {
                Label = "Featured Django Project",
                Title = "Bike Source - Used Bike Marketplace",
                Summary = "A full-stack Django marketplace built for end-to-end used bike buying and selling workflows. It highlights my ability to design production-ready commerce features, role-based user journeys, secure admin workflows, and deployment-friendly architecture with Docker and PostgreSQL.",
                Technologies =
                [
                    "Django", "Python", "MySQL", "PostgreSQL",
                    "HTML", "CSS", "Docker", "Role-Based Access"
                ],
                Outcomes =
                [
                    "Developed a full-stack e-commerce workflow for buying and selling used bikes.",
                    "Implemented product listing, cart, checkout, order management, and user dashboard modules.",
                    "Built wishlist, session-based bike comparison, review system, and order tracking features.",
                    "Designed Buyer, Seller, and Admin roles with secure access control and approval workflows.",
                    "Configured Docker-based development and deployed a production-ready PostgreSQL-backed application."
                ],
                GitHubUrl = "https://github.com/debodipto/Bike-Source",
                LiveUrl = "https://bike-source-1.onrender.com/"
            },
            Projects =
            [
                new ProjectItem
                {
                    Title = "ResuniqAI - AI Powered Resume Builder Platform",
                    TechStack = "ASP.NET Core MVC, .NET 10, EF Core, SQLite, Identity, QuestPDF, OpenAI API",
                    GitHubUrl = "https://github.com/debodipto/ResuniqAI",
                    LiveUrl = "https://resuniqai-1.onrender.com/",
                    Highlights =
                    [
                        "Developed an AI-powered resume builder with ATS-friendly templates and PDF export functionality.",
                        "Integrated OpenAI API for resume summary, cover letter, interview coaching, and ATS scoring features.",
                        "Implemented secure authentication with role-based premium subscription access.",
                        "Built admin dashboard for managing users, payments, jobs, and platform operations.",
                        "Designed scalable MVC architecture with service-based backend structure."
                    ]
                },
                new ProjectItem
                {
                    Title = "DSJ's Book Store - Online Bookstore Management System",
                    TechStack = "ASP.NET Core MVC, EF Core, SQLite, Identity, Bootstrap",
                    GitHubUrl = "https://github.com/debodipto/DSJ-s_Book_Store",
                    LiveUrl = "https://dsjsbookstore.onrender.com/Home/Index",
                    Highlights =
                    [
                        "Built a complete eCommerce bookstore with cart, checkout, orders, wishlist, and review modules.",
                        "Implemented advanced search and filtering by title, author, genre, and price range.",
                        "Developed admin panel for managing books, stock, orders, reports, and analytics dashboard.",
                        "Applied repository pattern and role-based authentication for secure maintainable architecture.",
                        "Added business insights including sales summary, top-selling books, and low-stock alerts."
                    ]
                }
            ],
            SkillGroups =
            [
                new SkillGroup
                {
                    Title = "Development Stack",
                    Items =
                    [
                        "Python", "C", "C++", "C#", "SQL", "JavaScript", "HTML5", "CSS3",
                        "Django", "Django REST Framework", "ASP.NET Core MVC", ".NET", ".NET 10", "Razor Pages",
                        "Entity Framework Core", "Bootstrap", "QuestPDF", "Repository Pattern", "Dependency Injection",
                        "REST API Development", "JWT Authentication", "CRUD Operations", "MVC Architecture",
                        "ASP.NET Core Identity", "Role-Based Access Control"
                    ]
                },
                new SkillGroup
                {
                    Title = "Database and Platforms",
                    Items =
                    [
                        "MySQL", "PostgreSQL", "SQL Server", "SQLite",
                        "Git", "GitHub", "Docker", "Linux", "VS Code", "Visual Studio",
                        "PythonAnywhere", "Postman", "CI/CD Fundamentals"
                    ]
                },
                new SkillGroup
                {
                    Title = "System Engineering",
                    Items =
                    [
                        "Ubuntu", "CentOS", "RedHat", "Windows",
                        "TCP/IP", "LAN/WAN", "Routing", "Subnetting", "DNS",
                        "Nginx", "Apache", "AWS Fundamentals", "VPS Management",
                        "WHM/cPanel Basics", "SSL Installation & Configuration",
                        "Docker Basics", "Kubernetes Basics"
                    ]
                },
                new SkillGroup
                {
                    Title = "AI and Workflow Tools",
                    Items =
                    [
                        "ChatGPT", "GitHub Copilot", "OpenAI Codex"
                    ]
                }
            ],
            Experiences =
            [
                new ExperienceItem
                {
                    Role = "Software Engineer Intern",
                    Company = "Eutropia IT Solution",
                    Period = "June 2025 - November 2025",
                    Highlights =
                    [
                        "Developed and deployed 10+ backend features using Django for a production-level application.",
                        "Designed and implemented 15+ RESTful APIs and optimized database queries to improve performance by around 25%.",
                        "Collaborated with team members to integrate frontend components and enhance system reliability."
                    ]
                },
                new ExperienceItem
                {
                    Role = "Digital Marketing Intern",
                    Company = "MNMRiDEZ via Eutropia IT Solution",
                    Period = "March 2025 - May 2025",
                    Highlights =
                    [
                        "Managed and scheduled content across multiple social media platforms.",
                        "Designed marketing creatives and supported campaign execution.",
                        "Collaborated with cross-functional teams to improve engagement and outreach."
                    ]
                }
            ],
            Education =
            [
                new EducationItem
                {
                    Degree = "Bachelor of Science in Computer Science & Engineering",
                    Institute = "University of Asia Pacific (UAP), Dhaka, Bangladesh",
                    Details = "Passing Year: 2025"
                },
                new EducationItem
                {
                    Degree = "Higher Secondary Certificate",
                    Institute = "Shahid Smrity Degree College, Nesarabad, Pirojpur",
                    Details = "Passing Year: 2020"
                },
                new EducationItem
                {
                    Degree = "Secondary School Certificate",
                    Institute = "Swarupkathi Pilot Secondary School, Nesarabad, Pirojpur",
                    Details = "Passing Year: 2018"
                }
            ],
            Thesis = new ThesisInfo
            {
                Label = "Academic Thesis",
                Title = "Demonstration of Li-Fi based V2V and V2X Communication Model for Dynamic Traffic Route-Planning",
                Summary = "Research-centered academic work focused on next-generation wireless communication and intelligent transportation systems through a Li-Fi based communication model.",
                Points =
                [
                    "Conducted research on Li-Fi based wireless communication technology.",
                    "Focused on Vehicle-to-Vehicle (V2V) and Vehicle-to-Everything (V2X) communication systems.",
                    "Explored smart traffic management and dynamic route-planning concepts.",
                    "Developed practical knowledge in networking, data communication, and intelligent transportation systems."
                ]
            },
            Activities =
            [
                "Vice President, Cyber Security Club, CSE-UAP (Fall 2024)",
                "Organizing Vice President, UAP Cyber Siege (Fall 2024)",
                "General Member, UAP-YES (Spring 2023 to Spring 2025)"
            ],
            Contact = new ContactInfo
            {
                Location = "Kalabagan, Dhanmondi, Dhaka, Bangladesh",
                Phone = "(+880) 1728-825929",
                Email = "debodiptosamadder@gmail.com",
                Links =
                [
                    new ContactLink
                    {
                        Label = "LinkedIn",
                        Url = "https://www.linkedin.com/in/debodipto-samadder-55b3a3212/"
                    },
                    new ContactLink
                    {
                        Label = "GitHub",
                        Url = "https://github.com/debodipto"
                    },
                    new ContactLink
                    {
                        Label = "Codeforces",
                        Url = "https://codeforces.com/profile/Debodipto"
                    }
                ]
            }
        };
}
