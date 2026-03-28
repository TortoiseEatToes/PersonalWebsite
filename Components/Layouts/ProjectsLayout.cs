using Microsoft.FluentUI.AspNetCore.Components;

namespace PersonalWebsite.Components.Layouts;

public class ProjectsLayout : MainLayout
{
    protected override Appearance ProjectsAppearance { get => ClickedAppearance; }
}