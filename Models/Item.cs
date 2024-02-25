using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detail_Shopping.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        
        //country of origin
        public string Origin { get; set; }
        public DateTime Time { get; set; }
        public string UPC { get; set; }
    }
}
