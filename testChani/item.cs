using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testChani
{
    public class Item
    {
        private string title;
        private string url;
        private string price;

        public Item(string title, string url, string price)
        {
            this.title = title;
            this.url = url;
            this.price = price;
        }
        public string Title { get {return title; } set{; } }
        public string Url { get { return url; }set {; } }
        public string Price { get {return price; } set {; } }

    }
}
