namespace DevPortfolio.Models;

public sealed class SocialLink
{
    public required string Label { get; init; }
    public required string Url { get; init; }
    public required string Handle { get; init; }
}

/// <summary>A named cluster of related skills, rendered as a labeled row of pills.</summary>
public sealed class SkillGroup
{
    public required string Category { get; init; }
    public required string[] Items { get; init; }
}

/// <summary>Static "who am I" data. Edit these placeholders with your real details.</summary>
public sealed class Profile
{
    public string Handle { get; init; } = "@linnracious";
    public string Name { get; init; } = "Henry Chen";
    public string Role { get; init; } = "Full-Stack Advisory Developer / Junior Solution Manager / Project Manager";
    public string Location { get; init; } = "Midland, Michigan, USA";
    public string PhotoUrl { get; init; } = "assets/main.png";

    public string[] Bio { get; init; } =
    [
        "I build things for the web and beyond — turning caffeine and curiosity into resilient systems.",
        "My stack runs from .NET and C# on the metal up through TypeScript and the modern front-end. I care about clean architecture, fast feedback loops, and interfaces that feel alive.",
        "When I'm offline you'll find me chasing synthwave playlists, mechanical keyboards, and the next side project."
    ];

    public string[] Stack { get; init; } =
    [
        "C# / .NET", "Blazor", "JavaScript/TypeScript", "HTML", "CSS",
        "Aurelia", "React", "Oracle", "SQL Server", "Azure"
    ];

    public SkillGroup[] Skills { get; init; } =
    [
        new()
        {
            Category = "Engineering",
            Items = ["Clean Architecture", "Full-Stack Development", "API Design", "Code Review", "Database Design"]
        },
        new()
        {
            Category = "Solutioning",
            Items = ["Solution Design", "Technical Advisory", "Requirements Analysis", "System Integration"]
        },
        new()
        {
            Category = "Leadership",
            Items = ["Project Management", "Team Mentoring", "Stakeholder Communication", "Agile Delivery"]
        }
    ];

    public SocialLink[] Socials { get; init; } =
    [
        new() { Label = "GitHub",   Url = "https://github.com/Linnracious",      Handle = "github.com/Linnracious" },
        new() { Label = "LinkedIn", Url = "https://linkedin.com/in/henry-chen-35868563", Handle = "linkedin.com/in/henry-chen-35868563" },
        new() { Label = "Email",    Url = "mailto:linnracious@gmail.com",              Handle = "linnracious@gmail.com" }
    ];
}
