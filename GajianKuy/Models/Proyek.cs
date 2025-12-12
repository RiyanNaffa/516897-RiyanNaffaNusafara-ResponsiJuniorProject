using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajianKuy.Models
{
    public class Proyek
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Client { get; set; }
        public decimal Budget { get; set; }
    }
}
