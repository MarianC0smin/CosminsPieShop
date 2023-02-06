using CosminsPieShop.Models;
using Microsoft.AspNetCore.Components;

namespace CosminsPieShop.Pages.App
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
