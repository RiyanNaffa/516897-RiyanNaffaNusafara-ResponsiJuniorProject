using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajianKuy.Models
{
    public class Developer
    {
        public int Id { get;set; }
        public string Nama { get;set; }
        public string StatusKontrak { get;set; }
        public int FiturSelesai { get;set; }
        public int JumlahBug { get;set; }
        public int ProyekId { get;set; }
    }
}
