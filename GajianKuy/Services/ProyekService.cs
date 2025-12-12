using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using GajianKuy.Database;
using System.Data;

namespace GajianKuy.Services
{
    public class ProyekService
    {
        private readonly DatabaseManager db;
        public ProyekService(DatabaseManager database)
        {
            db = database ?? throw new ArgumentNullException(nameof(database));
        }

        public (DataTable dt, string error) GetAll()
        {
            return db.ExecuteQuery("SELECT id, nama FROM proyek ORDER BY id");
        }
    }
}
