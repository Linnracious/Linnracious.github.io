namespace DevPortfolio.Models;

public enum NodeKind
{
    Education,
    Work,
    Project,
    Milestone
}

/// <summary>A single node in the "Time Machine" simulation timeline.</summary>
public sealed class TimelineEntry
{
    public required string Year { get; init; }
    public required string Title { get; init; }
    public required string Org { get; init; }
    public required string Summary { get; init; }
    public string Details { get; init; } = "";
    public string[] Tags { get; init; } = [];
    public NodeKind Kind { get; init; } = NodeKind.Work;
}
