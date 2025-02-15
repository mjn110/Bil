﻿using System.Collections.Generic;

namespace BlazorInterfaceLibrary.Data
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }

        public int TotalPage { get; private set; }

        public int Count { get; private set; }

        public PaginatedList(List<T> items, int pageIndex, int pageSize)
        {
            this.PageIndex = pageIndex;
            this.Count = items.Count;
            this.TotalPage = (int)Math.Ceiling(Count / (double)pageSize);

            items = items.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            this.AddRange(items);
            //CreateAsync(items, pageIndex, pageSize);
        }
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPage);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(List<T> source, int pageIndex, int pageSize)
        {
            //var count = await source.CountAsync();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(items, pageIndex, pageSize);
        }
    }

}

