namespace PortfolioSite.Models;

public class PortfolioViewModel
{
    public required string Name { get; init; }
    public required string Headline { get; init; }
    public required string Summary { get; init; }
    public required string PhotoPath { get; init; }
    public required IReadOnlyList<string> Highlights { get; init; }
    public required FeaturedProject FeaturedProject { get; init; }
    public required IReadOnlyList<ProjectItem> Projects { get; init; }
    public required IReadOnlyList<SkillGroup> SkillGroups { get; init; }
    public required IReadOnlyList<ExperienceItem> Experiences { get; init; }
    public required IReadOnlyList<EducationItem> Education { get; init; }
    public required ThesisInfo Thesis { get; init; }
    public required IReadOnlyList<string> Activities { get; init; }
    public required ContactInfo Contact { get; init; }
}

public class FeaturedProject
{
    public required string Label { get; init; }
    public required string Title { get; init; }
    public required string Summary { get; init; }
    public required IReadOnlyList<string> Technologies { get; init; }
    public required IReadOnlyList<string> Outcomes { get; init; }
    public required string GitHubUrl { get; init; }
    public required string LiveUrl { get; init; }
}

public class ProjectItem
{
    public required string Title { get; init; }
    public required string TechStack { get; init; }
    public required string GitHubUrl { get; init; }
    public required string LiveUrl { get; init; }
    public required IReadOnlyList<string> Highlights { get; init; }
}

public class SkillGroup
{
    public required string Title { get; init; }
    public required IReadOnlyList<string> Items { get; init; }
}

public class ExperienceItem
{
    public required string Role { get; init; }
    public required string Company { get; init; }
    public required string Period { get; init; }
    public required IReadOnlyList<string> Highlights { get; init; }
}

public class EducationItem
{
    public required string Degree { get; init; }
    public required string Institute { get; init; }
    public required string Details { get; init; }
}

public class ThesisInfo
{
    public required string Label { get; init; }
    public required string Title { get; init; }
    public required string Summary { get; init; }
    public required IReadOnlyList<string> Points { get; init; }
}

public class ContactInfo
{
    public required string Location { get; init; }
    public required string Phone { get; init; }
    public required string Email { get; init; }
    public required IReadOnlyList<ContactLink> Links { get; init; }
}

public class ContactLink
{
    public required string Label { get; init; }
    public required string Url { get; init; }
}
