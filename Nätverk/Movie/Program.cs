﻿using System;

namespace Movie
{
    class Program
    {
        public class SearchData
        {
            public string SearchType { get; set; }
            public string Expression { get; set; }

            public List<SearchResult> Results { get; set; }

            public string ErrorMessage { get; set; }
        }

        public class SearchResult
        {
            public string Id { get; set; }
            public string ResultType { get; set; }
            public string Image { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
