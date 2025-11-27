using RazorComponentLibrary.Enums;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorComponentLibrary.Classes
{
    public class Badge : BilComponent
    {
        public string Text { get; set; } = "Badge";
        public string Value { get; set; }

        public override RenderFragment Render() => comp =>
        {
            var seq = 0;
            comp.OpenElement(seq++, "div");
            comp.AddAttribute(seq++, "class", $"{GetWidthClass()} mb-3");
            comp.AddContent(seq++, (RenderFragment)(badge =>
            { 
                badge.OpenElement(seq++, "div");
                badge.AddAttribute(seq++, "class", $"card {GetColorClass()} text-dark {IsBordered()} {GetBorderClass()} shadow-sm");

                badge.AddContent(seq++, (RenderFragment)(builder =>
                {
                    builder.OpenElement(seq++, "h6");
                    builder.AddAttribute(seq++, "class", "m-3 float-left");
                    builder.AddContent(seq++, Text);
                    builder.CloseElement();
                }));

                badge.AddContent(seq++, (RenderFragment)(badgeBody =>
                {
                    badgeBody.OpenElement(seq++, "div");
                    badgeBody.AddAttribute(seq++, "class", "card-body");
                    badgeBody.AddContent(seq++, (RenderFragment)(Value =>
                    {
                        Value.OpenElement(seq++, "p");
                        Value.AddAttribute(seq++, "class", "display-5 px-3 m-auto h-100");
                        Value.AddContent(seq++, this.Value);
                        Value.CloseElement();
                    }));
                    badgeBody.CloseElement();
                }));

                badge.CloseElement();
            }));
            comp.CloseElement();
        };
    }
}