using Microsoft.AspNetCore.Components;

namespace TestWepApp.Components.Library.Components.Advanced
{
    public partial class  LIstView<TItem>
    {
        [Parameter]
        public RenderFragment<TItem> ItemTemplate { get; set; } = default!;

        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; } = default!;

    }
}
