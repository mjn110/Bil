using RazorComponentLibrary.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorComponentLibrary.Classes
{
    public abstract class List : Setting
    {
        [Parameter]
        public List<dynamic> list { get; set; } = new List<dynamic>();
        public Pagination<dynamic> PaginatedList { get; set; } = null;

        [Parameter]
        public int RecordsPerPage { get; set; } = 3;

        public void AddPersons()
        {
            PaginatedList = new Pagination<dynamic>(list, 1, RecordsPerPage);
        }

        public void ChangePage(int index)
        {
            PaginatedList = new Pagination<dynamic>(list, index, RecordsPerPage);
        }

        public void MoveForward(Person person)
        {
            if (person.Status < 3)
            {
                person.Status++;
                StateHasChanged();
            }
        }

        public void MoveBack(Person person)
        {
            if (person.Status > 1)
            {
                person.Status--;
                StateHasChanged();
            }
        }
    }
}
