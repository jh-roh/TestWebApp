using Microsoft.AspNetCore.Components;

namespace TestWepApp.Components.Library.Components.Advanced
{
    public partial class ListView2<TItem>
    {
        [Parameter]
        public RenderFragment<RenderFragment>? ListTemplate { get; set; }

        [Parameter]
        public RenderFragment<TItem> ItemTemplate { get; set; } = default!;

        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; } = default!;


    }
}
