using Microsoft.FluentUI.AspNetCore.Components;

namespace PersonalWebsite.Components.Layout;

public partial class PageLayoutBase
{
    protected virtual Appearance ProjectsAppearance()
    {
        return Appearance.Neutral;
    }

    protected virtual Appearance CareerAppearance()
    {
        return Appearance.Neutral;
    }

    protected virtual Appearance ContactAppearance()
    {
        return Appearance.Neutral;
    }
}
