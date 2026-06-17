namespace DevPortfolio.Services;

/// <summary>
/// Global UI mode. "Simulation" = the immersive 3D Time Machine view;
/// "Flat" = the calmer, accessible reading view (EXIT SIMULATION).
/// </summary>
public sealed class SimulationState
{
    private bool _simulationActive = false;

    public bool SimulationActive => _simulationActive;

    public event Action? Changed;

    public void Toggle()
    {
        _simulationActive = !_simulationActive;
        Changed?.Invoke();
    }

    public void Set(bool active)
    {
        if (_simulationActive == active) return;
        _simulationActive = active;
        Changed?.Invoke();
    }
}
