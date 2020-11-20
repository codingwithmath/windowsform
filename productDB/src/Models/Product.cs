using System;

namespace productDB.src.Models
{
    class Product
    {
        public string Title;
        public string Category;
        public string Description;
        public string Url;
        public DateTime timestamps { get; set; }
        public Product()
        {

        }

        public Product(string title, string category, string description, string url)
        {
            Title = title;
            Category = category;
            Description = description;
            Url = url;
        }
    }
}
