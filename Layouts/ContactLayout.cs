using Microsoft.FluentUI.AspNetCore.Components;

namespace PersonalWebsite.Layouts;

public class ContactLayout : MainLayout
{
    protected override Appearance ContactAppearance { get => ClickedAppearance; }
}
