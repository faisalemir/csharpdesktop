using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ModelMahasiswa
    {
        public decimal id_mahasiswa { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string created_by { get; set; }
        public Nullable<DateTime> created_date { get; set; }
        public string modified_by { get; set; }
        public Nullable<DateTime> modified_date { get; set; }
        public bool is_deleted { get; set; }
    }

    public class DataMahasiswa : GetData
    {
        protected List<ModelMahasiswa> list = new List<ModelMahasiswa>();

        public Boolean insert(ModelMahasiswa m)
        {
            sql = "INSERT INTO tb_mahasiswa(nama, alamat, created_by) " +
                  "VALUES('{0}','{1}','{2}')";
            sql = String.Format(sql, m.nama, m.alamat, m.created_by);

            return CRUD_data(sql); // mengirim sql query untuk di eksekusi
        }

        public Boolean insert_batch(List<ModelMahasiswa> list)
        {
            List<string> sql_batch = new List<string>();

            sql = "INSERT INTO tb_mahasiswa(nama, alamat, created_by) " +
                  "VALUES('{0}','{1}','{2}')";

            foreach (ModelMahasiswa m in list)
            {
                string tmp_sql = String.Format(sql, m.nama, m.alamat, m.created_by);
                sql_batch.Add(tmp_sql);
            }

            return CRUD_batch(sql_batch); // mengirim sql query untuk di eksekusi
        }

        public Boolean update(ModelMahasiswa m)
        {
            sql = "UPDATE tb_mahasiswa SET nama='{1}', alamat='{2}', modified_by='{3}', modified_date=GETDATE() WHERE id_mahasiswa='{0}'";
            sql = String.Format(sql, m.id_mahasiswa, m.nama, m.alamat, m.modified_by);
            return CRUD_data(sql); // mengirim sql query untuk di eksekusi
        }

        public Boolean delete(ModelMahasiswa m)
        {
            sql = "UPDATE tb_mahasiswa SET is_deleted=1 WHERE id_mahasiswa='{0}'";
            sql = String.Format(sql, m.id_mahasiswa);
            return CRUD_data(sql); // mengirim sql query untuk di eksekusi
        }

        public List<ModelMahasiswa> selectall()
        {
            sql = "SELECT * FROM tb_mahasiswa WHERE is_deleted=0";
            dtTable = get_dtTable(sql); // mengirim sql query untuk di eksekusi

            try
            {
                // mapping data hasil eksekusi query ke class object model (list)
                list = dtTable.AsEnumerable()
                        .Select(row => new ModelMahasiswa()
                        {
                            id_mahasiswa = row.Field<decimal>("id_mahasiswa"),
                            nama = row.Field<string>("nama"),
                            alamat = row.Field<string>("alamat"),
                            created_by = row.Field<string>("created_by"),
                            created_date = row.Field<Nullable<DateTime>>("created_date"),
                            modified_by = row.Field<string>("modified_by"),
                            modified_date = row.Field<Nullable<DateTime>>("modified_date"),
                            is_deleted = row.Field<bool>("is_deleted")
                        }).ToList();
            }
            catch (Exception ex)
            {
                GetLog log = new GetLog();
                log.Create(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return list;
        }

        public ModelMahasiswa selectbyid(int id)
        {
            ModelMahasiswa m = new ModelMahasiswa();

            sql = String.Format("SELECT * FROM tb_mahasiswa WHERE id_mahasiswa='{0}'", id);
            try
            {
                dtRow = get_dtTable(sql).Rows[0]; // mengirim sql query untuk di eksekusi

                // mapping data hasil eksekusi query ke class object model (satuan)
                m.id_mahasiswa = dtRow.Field<int>("id_mahasiswa");
                m.nama = dtRow.Field<string>("nama");
                m.alamat = dtRow.Field<string>("alamat");
                m.created_by = dtRow.Field<string>("created_by");
                m.created_date = dtRow.Field<Nullable<DateTime>>("created_date");
                m.modified_by = dtRow.Field<string>("modified_by");
                m.modified_date = dtRow.Field<Nullable<DateTime>>("modified_date");
                m.is_deleted = dtRow.Field<bool>("is_deleted");
            }
            catch (Exception ex)
            {
                GetLog log = new GetLog();
                log.Create(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name, MethodBase.GetCurrentMethod().Name);
            }

            return m;
        }
    }
}
