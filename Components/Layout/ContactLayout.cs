using Microsoft.FluentUI.AspNetCore.Components;

namespace PersonalWebsite.Components.Layout;

public class ContactLayout : MainLayout
{
    protected override Appearance ContactAppearance { get => ClickedAppearance; }
}
