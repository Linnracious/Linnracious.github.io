namespace DevPortfolio.Models;

public sealed class SocialLink
{
    public required string Label { get; init; }
    public required string Url { get; init; }
    public required string Handle { get; init; }
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

    public SocialLink[] Socials { get; init; } =
    [
        new() { Label = "GitHub",   Url = "https://github.com/your-handle",      Handle = "github.com/your-handle" },
        new() { Label = "LinkedIn", Url = "https://linkedin.com/in/your-handle", Handle = "linkedin.com/in/your-handle" },
        new() { Label = "Email",    Url = "mailto:you@example.com",              Handle = "you@example.com" },
        new() { Label = "X",        Url = "https://x.com/your-handle",           Handle = "x.com/your-handle" }
    ];
}
