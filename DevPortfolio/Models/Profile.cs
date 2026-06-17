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

/// <summary>A completed certification. Url is optional — when set, the card links out to verify it.</summary>
public sealed class Certification
{
    public required string Name { get; init; }
    public required string Issuer { get; init; }
    public required string Year { get; init; }
    public string? Url { get; init; }
}

/// <summary>Static "who am I" data. Edit these placeholders with your real details.</summary>
public sealed class Profile
{
    public string Handle { get; init; } = "@linnracious";
    public string Name { get; init; } = "Henry Chen";
    public string Role { get; init; } = "Full-Stack Lead Developer / Associate Solution Manager / Project Manager";
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
        "C# / .NET", "Python", "Delphi","SQL", "JavaScript/TypeScript", "HTML", "CSS",
        "Aurelia", "React", "Blazor", "Oracle", "SQL Server", "Azure", "GitHub"
    ];

    public SkillGroup[] Skills { get; init; } =
    [
        new()
        {
            Category = "Technical",
            Items = ["Full-Stack Development", "API Design", "Code Review", "Database Design"]
        },
        new()
        {
            Category = "Technologies",
            Items = ["Laboratory Information Management Systems (LIMS)", "High Throughput Research (HTR)", "Electronic Lab Notebook (ELN)"]            
        },
        new()
        {
            Category = "Design",
            Items = ["Solution Design", "Technical Advisory", "Requirements Analysis", "System Integration"]
        },
        new()
        {
            Category = "Leadership",
            Items = ["Project Management", "Team Mentoring", "Stakeholder Management", "Agile Delivery"]
        }
    ];

    public Certification[] Certifications { get; init; } =
    [
        new() { Name = "Foundations of Cybersecurity", Issuer = "Google", Year = "2026", Url = "https://www.coursera.org/account/accomplishments/verify/ULLZKLZP1NSZ" },
        new() { Name = "Foundations of Project Management", Issuer = "Google", Year = "2025", Url = "https://www.coursera.org/account/accomplishments/verify/YOYW7642UTSI" },
        new() { Name = "Application Development using Microservices and Serverless", Issuer = "IBM", Year = "2025", Url = "https://www.coursera.org/account/accomplishments/verify/3B4G28IPZYE9" },
        new() { Name = "Scrum Master (PSM I)",        Issuer = "Scrum.org", Year = "2018", Url = "https://www.scrum.org/certificates/319609" }
    ];

    public SocialLink[] Socials { get; init; } =
    [
        new() { Label = "GitHub",   Url = "https://github.com/Linnracious",      Handle = "github.com/Linnracious" },
        new() { Label = "LinkedIn", Url = "https://linkedin.com/in/henry-chen-35868563", Handle = "linkedin.com/in/henry-chen-35868563" },
        new() { Label = "Email",    Url = "mailto:linnracious@gmail.com",              Handle = "linnracious@gmail.com" }
    ];
}
