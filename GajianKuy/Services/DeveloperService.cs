using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using GajianKuy.Database;
using GajianKuy.Models;

namespace GajianKuy.Services
{
    public class DeveloperService
    {
        private readonly DatabaseManager db;
        public DeveloperService(DatabaseManager db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }
        
        public (DataTable dt, string error) GetAll()
        {
            try
            {
                return db.ExecuteQuery("SELECT * FROM select_developer()");
            }
            catch (Exception ex)
            {
                return (new DataTable(), $"Failed to retrieve developer: {ex.Message}");
            }
        }

        public string Insert(Developer d)
        {
            if (d == null) return "Objek developer tidak boleh null";
            if (string.IsNullOrWhiteSpace(d.Nama) || string.IsNullOrWhiteSpace(d.StatusKontrak)) return "Harus diisi!";

            db.ExecuteNonQuery("SELECT insert_developer(@nama, @proyek_id, @status_kontrak, @fitur_selesai, @jumlah_bug)",
                new NpgsqlParameter("nama", d.Nama),
                new NpgsqlParameter("proyek_id", d.ProyekId),
                new NpgsqlParameter("status_kontrak", d.StatusKontrak),
                new NpgsqlParameter("fitur_selesai", d.FiturSelesai),
                new NpgsqlParameter("jumlah_bug", d.JumlahBug));

            return string.Empty;
        }

        public string Update(Developer d)
        {
            if (d == null) return "Objek developer tidak boleh null";
            if (string.IsNullOrWhiteSpace(d.Nama) || string.IsNullOrWhiteSpace(d.StatusKontrak)) return "Harus diisi!";

            db.ExecuteNonQuery("SELECT update_developer(@id, @nama, @proyek_id, @status_kontrak, @fitur_selesai, @jumlah_bug)",
                new NpgsqlParameter("id", d.Id),
                new NpgsqlParameter("nama", d.Nama),
                new NpgsqlParameter("proyek_id", d.ProyekId),
                new NpgsqlParameter("status_kontrak", d.StatusKontrak),
                new NpgsqlParameter("fitur_selesai", d.FiturSelesai),
                new NpgsqlParameter("jumlah_bug", d.JumlahBug));

            return string.Empty;
        }

        public string Delete(int id)
        {
            if (id <= 0) return "ID invalid";

            db.ExecuteNonQuery("SELECT delete_developer(@id)",
                new NpgsqlParameter("id", id));

            return string.Empty;
        }
    }
}
