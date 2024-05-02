using Microsoft.AspNetCore.Components;
namespace TestWepApp.BlazorApp.Components
{
    public partial class Dismissible
    {
        private bool show;
        [Parameter]
        public bool Show
        {
            get => show;
            set
            {
                if(value != show)
                {
                    show = value;
                    ShowChanged?.InvokeAsync(show);
                }
            }
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;

        public void Dismiss() => Show = false;

        [Parameter]
        public EventCallback<bool>? ShowChanged { get; set;}
    }

}