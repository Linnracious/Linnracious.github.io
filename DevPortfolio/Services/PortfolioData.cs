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
            Year = "2010.9",
            Title = "B.S.E of Chemical Engineer",
            Org = "University of Michigan-Ann Arbor",
            Summary = "What is even Chemical Engineering? Just Chemistry right?",
            Details = "Enrolled at the University of Michigan Chemical Engineering program, with a passion and curiosity for chemistry! Go Mass Balances! Go Blue!",
            Tags = ["Chemical Engineering"],
            Kind = NodeKind.Education
        },
        new()
        {
            Year = "2011.9",
            Title = "Minor in Computer Science",
            Org = "University of Michigan-Ann Arbor",
            Summary = "When it first compiled.",
            Details = "Began enrolling in classes to target a minor in Computer Science because I enjoyed the practical hands-on aspects of computer science to balance with the theoretical thinking for chemical engineering.",
            Tags = ["Computer Science"],
            Kind = NodeKind.Education
        },
        new()
        {
            Year = "2012.5",
            Title = "Web Module Developer",
            Org = "Encyclopedia of Chemical Engineering Equipment@University of Michigan",
            Summary = "Let's work with some web pages!",
            Details = "Collaborated with a team of 5 to develop online encyclopedia of ChE equipment. Researched over hundreds of chemical engineering companies and equipment. Delivered an informative and comprehensive online encyclopedia for the public. </br> <a href='https://encyclopedia.che.engin.umich.edu/' target='_blank'>Open link</a>",
            Tags = ["HTML", "JavaScript"],
            Kind = NodeKind.Work
        },  
        new()      
        {
            Year = "2014.5",
            Title = "B.S.E of Chemical Engineer, Minor in Computer Science",
            Org = "University of Michigan-Ann Arbor",
            Summary = "Finally done downloading...",
            Details = "Graduated Cum laude, with a focus on Research & Development for Product Design and experienced in software development and algorithms.",
            Tags = ["Chemical Engineering", "Computer Science"],
            Kind = NodeKind.Education
        },
        new()
        {
            Year = "2014.6",
            Title = "Junior Software Engineer / Information Technology Analyst",
            Org = "The Dow Chemical Company",
            Summary = "From code magus to programming wizard",
            Details = "Began with software projects around a Laboratory Information Management System (LIMS) to developing and owning APIs, clients, and pipelines to extend its capability for 1000+ researchers. Over time, developed and supported over 20+ critical R&D applications.",
            Tags = ["JavaScript", "HTML", "Knockout.js", "Durandal.js", "D3.js", "Bootstrap", ".NET", "C#"],
            Kind = NodeKind.Work
        },
        new()
        {
            Year = "2019.7",
            Title = "Senior Software Engineer / Senior Information Technology Analyst",
            Org = "The Dow Chemical Company",
            Summary = "Lead, teach and optimize!",
            Details = "Championing the adoption of agile and scrum methodologies on the team, scaled up the LIMS ecosystem with 4 new additional business functions, and developed into a more business analyst role, working with stakeholders to deliver strategy and 10M+ value for their functions.",
            Tags = ["Agile", "SCRUM", "Aurelia", "TFS", "Azure DevOps", "Business Analyst", "CI/CD"],
            Kind = NodeKind.Milestone
        },
        new()
        {
            Year = "2024.7",
            Title = "Lead Software Engineer / Advisory Developer / Associate Solution Manager",
            Org = "The Dow Chemical Company",
            Summary = "Patience you must have, my young Padawans",
            Details = "Lead a team of 10+ jumior and senior developers on a journey to eradicate 10+ years of technical debt and security vulnerability, updating our frameworks, infrastructure and pipelines to adhere to modern principals and standards and eliminating 20+ EOL servers and patching and uplifting 50+ applications and mastering ownership of the life cycle management of the entire team's portfolio.",
            Tags = ["Life Cycle Management", "Tech Debt", "Security", "Microsoft Defender", "CodeQL/Advanced Security"],
            Kind = NodeKind.Milestone
        },
        new()
        {
            Year = "2026+",
            Title = "Lead Software Engineer / Advisory Developer / Associate Solution Manager",
            Org = "The Dow Chemical Company",
            Summary = "Who am AI?",
            Details = "Designed and drafted the requirements and specificiation documents for a multi-facted project management software integrating with many aspects of Microsoft's platforms such as Outlook, Azure DevOps, Planner, and OneNote in order to centralize the work a project manager need to track and plan projects to one location. This was AI-driven development mainly using Claude-Opus 4.* version while I managed the tasks and some manual bug fixes.",
            Tags = ["AI", "Claude", "Opus48", "Blazor", "CoPilot", "Project Management"],
            Kind = NodeKind.Project
        }
    ];
}
