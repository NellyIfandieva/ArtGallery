using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryDataModels
{
    public class Item
    {
        public int Id { get; set; }
        public ItemType Type { get; set; }
        public ItemIntended Intended { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Comments { get; set; }
        public bool Sold { get; set; }
    }
}
