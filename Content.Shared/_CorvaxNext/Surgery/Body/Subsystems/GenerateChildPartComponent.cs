using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._CorvaxNext.Surgery.Body.Subsystems;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class GenerateChildPartComponent : Component
{

    [DataField(required: true)]
    public EntProtoId Id = "";

    [DataField, AutoNetworkedField]
    public EntityUid? ChildPart;

    [DataField]
    public bool Active = false;
}
