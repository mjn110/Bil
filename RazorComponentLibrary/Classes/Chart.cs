using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorComponentLibrary.Classes
{
    public class Chart : BilComponent
    {
        public string Name { get; set; } = "Chart";
        public int Option1 { get; set; }
        public int Option2 { get; set; }
        public int Option3 { get; set; }

        public override RenderFragment Render() => comp =>
        {
            var seq = 0;
            comp.OpenElement(seq++, "div");
            comp.AddAttribute(seq++, "class", $"{GetWidthClass()} mb-3");
            comp.AddContent(seq++, (RenderFragment)(card =>
            {

                card.OpenElement(seq++, "div");
                card.AddAttribute(seq++, "class", $"card {GetColorClass()} text-dark {IsBordered()} {GetBorderClass()} shadow-sm");
                card.AddContent(seq++, (RenderFragment)(chart =>
                {
                    chart.OpenElement(seq++, "div");
                    chart.AddAttribute(seq++, "class", "col col-lg-12 d-flex justify-content-center p-3");
                    chart.AddAttribute(seq++, "style", "height:145px !important;");

                    chart.AddContent(seq++, (RenderFragment)( name =>
                    {
                        name.OpenElement(seq++, "div");
                        name.AddAttribute(seq++, "class", "pie m-0");
                        name.AddAttribute(seq++, "style", "--p:100; --c: lightgray");
                        name.AddContent(seq++, Name);
                        name.CloseElement();
                    }));
                    chart.AddContent(seq++, (RenderFragment)(opt1 =>
                    {
                        opt1.OpenElement(seq++, "div");
                        opt1.AddAttribute(seq++, "class", "pie m-0");
                        opt1.AddAttribute(seq++, "style", $"--p:{Option1}; --b:16px; --c: #007bff");
                        opt1.CloseElement();
                    }));
                    chart.AddContent(seq++, (RenderFragment)(opt2 =>
                    {
                        opt2.OpenElement(seq++, "div");
                        opt2.AddAttribute(seq++, "class", "pie m-0");
                        opt2.AddAttribute(seq++, "style", $"--p:{Option2}; --b:13px; --c: #dc3545");
                        opt2.CloseElement();
                    }));
                    chart.AddContent(seq++, (RenderFragment)(opt3 =>
                    {
                        opt3.OpenElement(seq++, "div");
                        opt3.AddAttribute(seq++, "class", "pie m-0");
                        opt3.AddAttribute(seq++, "style", $"--p:{Option3}; --b:10px; --c: #ebba34");
                        opt3.CloseElement();
                    }));

                    chart.CloseElement();
                }));
                card.CloseElement();
            }));
            comp.CloseElement();
        };
    }
}
