using ALD_Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ALD_DAL
{
    public class DropDownForBatchID
    {
        public List<AllDropDownData> GetAllDropDownValues()
        {
            List<AllDropDownData> lstddl = new List<AllDropDownData>();
            using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                lstddl = conn.Query<AllDropDownData>("sp_GetAllBatchID").ToList();
            }
            return lstddl;
        }
    }
}
