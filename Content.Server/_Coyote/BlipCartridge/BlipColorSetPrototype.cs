using Robust.Shared.Prototypes;

namespace Content.Server._Coyote.BlipCartridge;

/// <summary>
/// This is a prototype for...
/// </summary>
[Prototype]
public sealed partial class BlipColorSetPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; } = default!;

    /// <summary>
    /// The name to display in the UI.
    /// </summary>
    [DataField]
    public string Name = string.Empty;

    /// <summary>
    /// The color that gets shown on the radar screen.
    /// </summary>
    [DataField]
    public string Color = string.Empty;

    /// <summary>
    /// The color that gets shown on the radar screen when the blip is highlighted.
    /// i have no idea how this works in game, but maybe someone will figure it out
    /// </summary>
    [DataField]
    public string HighlightedColor = string.Empty;
}
