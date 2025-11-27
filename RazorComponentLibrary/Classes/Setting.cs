using RazorComponentLibrary.Enums;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorComponentLibrary.Classes
{
    public class Setting : ComponentBase
    {

        public string Id { get; } = Guid.NewGuid().ToString(); // Generate a unique ID for each instance

        public Enums.Type Type { get; set; }

        [Parameter]
        public Color Color { get; set; }

        [Parameter]
        public bool Fill { get; set; } = false; // Default to not filled

        [Parameter]
        public bool Border { get; set; } = true; // Default to bordered

        [Parameter]
        public BorderSize BorderSize { get; set; } = BorderSize.border2; // Default border size

        [Parameter]
        public Width Width { get; set; }

        protected string GetColorClass()
        {
            if (Fill)
            {
                Border = false; // If Fill is true, set Border to false
                return $"bg-{Color} {GetTextColorClass()}"; // Return background color class if Fill is true
            }
            else if (!Fill && Color == Color.Default)
            {
                return string.Empty; // Return border color class if Fill is false and Color is set
            }
            return $"border-{Color} {GetTextColorClass()}"; // Return empty string if neither condition is met
        }

        protected string GetTextColorClass()
        {
            if (Fill)
            {
                Border = false; // If Fill is true, set Border to false
                return "text-light"; // Return light color class if Fill is true
            }
            else if (!Fill && Color == Color.Default)
            {
                return "text-dark"; // Return dark color class if Fill is false and Color is set
            }
            return "text-dark"; // Return dark color if neither condition is met
        }

        protected string IsBordered() {
            return Border ? "border" : "border-0"; // Return border class if Border is true, otherwise empty string
        }

        protected string GetBorderClass() =>
            BorderSize switch
            {
                BorderSize.border1 => "border-1",
                BorderSize.border2 => "border-2",
                BorderSize.border3 => "border-3",
                BorderSize.border4 => "border-4",
                BorderSize.border5 => "border-5",
                _ => string.Empty // Default case if no match
            };

        protected string GetWidthClass() =>
            Width switch
            {
                Width.col1 => "col-1",
                Width.col2 => "col-2",
                Width.col3 => "col-3",
                Width.col4 => "col-4",
                Width.col5 => "col-5",
                Width.col6 => "col-6",
                Width.col7 => "col-7",
                Width.col8 => "col-8",
                Width.col9 => "col-9",
                Width.col10 => "col-10",
                Width.col11 => "col-11",
                Width.col12 => "col-12",
                _ => string.Empty // Default case if no match
            };

    }
}
