using RazorComponentLibrary.Enums;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace RazorComponentLibrary.Classes
{
    //[JsonDerivedType(typeof(Badge), "badge")]
    //[JsonDerivedType(typeof(Chart), "chart")]
    public abstract class BilComponent : Setting
    {
        public abstract RenderFragment Render();
    }
}
