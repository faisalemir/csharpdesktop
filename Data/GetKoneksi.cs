using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GetKoneksi
    {
        protected string connectionstring = string.Empty;
        public string sql = string.Empty;

        public SqlConnection konek = new SqlConnection();
        public SqlDataAdapter dtAdapter = new SqlDataAdapter();
        public SqlCommand cmd = new SqlCommand();

        public DataTable dtTable = new DataTable();
        public DataColumn dtCols = new DataColumn();
        public DataRow dtRow = null;

        public Boolean koneksidatabase()
        {
            try
            {
                connectionstring = ConfigurationManager.ConnectionStrings["koneksidb"].ConnectionString;
                konek = new SqlConnection(connectionstring);
                konek.Open();
                konek.Close();

                return true;
            }
            catch (SqlException ex)
            {
                GetLog log = new GetLog();
                log.Create(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name, MethodBase.GetCurrentMethod().Name);

                return false;
            }
        }
    }
}
