using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GetData : GetKoneksi
    {
        public DataTable get_dtTable(string sql)
        {
            Boolean check = koneksidatabase();

            if (check)
            {
                try
                {
                    konek.Open();
                    cmd = new SqlCommand(sql, konek);
                    dtAdapter = new SqlDataAdapter(cmd);

                    dtTable = new DataTable();
                    dtAdapter.Fill(dtTable);
                    konek.Close();
                }
                catch (SqlException ex)
                {
                    konek.Close();
                    GetLog log = new GetLog();
                    log.Create(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name, MethodBase.GetCurrentMethod().Name);
                }
            }

            return dtTable;
        }

        public Boolean CRUD_data(string sql)
        {
            Boolean check = koneksidatabase();

            if (check)
            {
                try
                {
                    konek.Open();
                    cmd = new SqlCommand(sql, konek);
                    cmd.ExecuteNonQuery();
                    konek.Close();

                    return true;
                }
                catch (SqlException ex)
                {
                    konek.Close();
                    GetLog log = new GetLog();
                    log.Create(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name, MethodBase.GetCurrentMethod().Name);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public String CRUD_scalar(string sql)
        {
            Boolean check = koneksidatabase();

            if (check)
            {
                try
                {
                    konek.Open();
                    cmd = new SqlCommand(sql, konek);
                    string kd = cmd.ExecuteScalar().ToString();
                    konek.Close();

                    return kd;
                }
                catch (SqlException ex)
                {
                    konek.Close();
                    GetLog log = new GetLog();
                    log.Create(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name, MethodBase.GetCurrentMethod().Name);

                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public Boolean CRUD_batch(List<string> sql_batch)
        {
            Boolean check = koneksidatabase();

            if (check)
            {
                konek.Open();
                SqlTransaction transact = konek.BeginTransaction();

                try
                {
                    foreach (var tmp_sql in sql_batch)
                    {
                        cmd = new SqlCommand(tmp_sql, konek);
                        cmd.Transaction = transact;
                        cmd.ExecuteNonQuery();
                    }
                    transact.Commit();
                    konek.Close();

                    return true;
                }
                catch (SqlException ex)
                {
                    transact.Rollback();
                    konek.Close();
                    GetLog log = new GetLog();
                    log.Create(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name, MethodBase.GetCurrentMethod().Name);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
