using Microsoft.FluentUI.AspNetCore.Components;

namespace PersonalWebsite.Components.Layout;

public class ProjectsLayout : MainLayout
{
    protected override Appearance ProjectsAppearance { get => ClickedAppearance; }
}