using Microsoft.FluentUI.AspNetCore.Components;

namespace PersonalWebsite.Layouts;

public class ProjectsLayout : MainLayout
{
    protected override Appearance ProjectsAppearance { get => ClickedAppearance; }
}