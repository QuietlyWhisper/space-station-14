using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Ghost.RoleGroups.UI;

[GenerateTypedNameReferences]
public sealed partial class GhostRoleGroupStartWindow : DefaultWindow
{
    public delegate void StartRoleGroup(string name, string description);

    public GhostRoleGroupStartWindow(StartRoleGroup startAction)
    {
        RobustXamlLoader.Load(this);

        StartButton.OnPressed += _ => startAction.Invoke(RoleName.Text, RoleDescription.Text);
    }
}
