using DevPortfolio.Models;

namespace DevPortfolio.Services;

/// <summary>
/// Central placeholder content for the portfolio. Swap these out with your real
/// data — everything the UI renders flows from here.
/// </summary>
public sealed class PortfolioData
{
    public Profile Profile { get; } = new();

    public IReadOnlyList<TimelineEntry> Timeline { get; } =
    [
        new()
        {
            Year = "2010",
            Title = "B.S.E of Chemical Engineer",
            Org = "University of Michigan-Ann Arbor",
            Summary = "What is even Chemical Engineering? Just Chemistry right?",
            Details = "Enrolled at the University of Michigan Chemical Engineering program, with a passion and curiosity for chemistry! Go Mass Balances! Go Blue!",
            Tags = ["Chemical Engineering"],
            Kind = NodeKind.Education
        },
        new()
        {
            Year = "2011",
            Title = "Minor in Computer Science",
            Org = "University of Michigan-Ann Arbor",
            Summary = "When it first compiled.",
            Details = "Began enrolling in classes to target a minor in Computer Science because I enjoyed the practical hands-on aspects of computer science to balance with the theoretical thinking for chemical engineering.",
            Tags = ["Computer Science"],
            Kind = NodeKind.Education
        },
        new()
        {
            Year = "2012",
            Title = "Web Module Developer",
            Org = "Encyclopedia of Chemical Engineering Equipment@University of Michigan",
            Summary = "Let's work with some web pages!",
            Details = "Collaborated with a team of 5 to develop online encyclopedia of ChE equipment. Researched over hundreds of chemical engineering companies and equipment. Delivered an informative and comprehensive online encyclopedia for the public. <strong>HTML</strong>",
            Tags = ["HTML", "JavaScript"],
            Kind = NodeKind.Work
        },  
        new()      
        {
            Year = "2014",
            Title = "B.S.E of Chemical Engineer, Minor in Computer Science",
            Org = "University of Michigan-Ann Arbor",
            Summary = "Where it first compiled",
            Details = "Graduated Cum laude, with a focus on Research & Development for Product Design and experienced in software development and algorithms.",
            Tags = ["Chemical Engineering", "Computer Science"],
            Kind = NodeKind.Education
        },
        new()
        {
            Year = "2014",
            Title = "Junior Software Engineer / Information Technology Analyst",
            Org = "The Dow Chemical Company",
            Summary = "Shipped to production on week two. Survived.",
            Details = "Owned a customer-facing dashboard rebuild. Cut page load time by 60% and learned why staging environments exist.",
            Tags = ["React", "Node", "PostgreSQL"],
            Kind = NodeKind.Work
        },
        new()
        {
            Year = "2021",
            Title = "OpenSource: NeonGrid",
            Org = "Personal Project",
            Summary = "A GPU-accelerated data-viz toolkit. 2k+ stars.",
            Details = "Designed an extensible rendering pipeline and a plugin API. Maintaining it taught me more about empathy than any management course.",
            Tags = ["WebGL", "TypeScript", "OSS"],
            Kind = NodeKind.Project
        },
        new()
        {
            Year = "2022",
            Title = "Software Engineer II",
            Org = "Helix Dynamics",
            Summary = "Led the migration to a modular monolith.",
            Details = "Reduced deployment incidents by 75% with feature flags and progressive rollouts. Mentored two juniors into mid-level roles.",
            Tags = [".NET", "Azure", "CI/CD"],
            Kind = NodeKind.Work
        },
        new()
        {
            Year = "2023",
            Title = "Founding Engineer",
            Org = "Stealth Startup",
            Summary = "Zero to one. Built the platform from an empty repo.",
            Details = "Architected an event-driven backend serving 50k MAU. Set the engineering culture, the test strategy, and the on-call rotation.",
            Tags = ["Architecture", "gRPC", "Kafka"],
            Kind = NodeKind.Milestone
        },
        new()
        {
            Year = "2025",
            Title = "Independent Consultant",
            Org = "Self-Employed",
            Summary = "Helping teams ship faster without breaking things.",
            Details = "Currently advising on performance, DX, and front-end architecture. Building this very portfolio in Blazor WASM + GSAP.",
            Tags = ["Consulting", "Blazor", "DX"],
            Kind = NodeKind.Milestone
        }
    ];
}
