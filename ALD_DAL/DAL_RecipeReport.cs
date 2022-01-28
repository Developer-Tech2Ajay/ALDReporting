using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALD_Entities.E_AlarmReport;
using ALD_Entities.ProcessReport;
using ALD_Entities.Recipe;
using Dapper;

namespace ALD_DAL
{
    public class DAL_RecipeReport
    {
        public List<Recipe_Report> GetRecipeReports(ProcessReport_RQ _req)
        {
            List<Recipe_Report> recipeReports = new List<Recipe_Report>();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", _req.BatchId);

                    recipeReports = conn.Query<Recipe_Report>("sp_GetRecipeDetails", queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
            return recipeReports;
        }

        public List<RecipeDetails> GetRecipeDetails(ProcessReport_RQ _req)
        {
            List<RecipeDetails> recipeDetails = new List<RecipeDetails>();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", _req.BatchId);

                    recipeDetails = conn.Query<RecipeDetails>("sp_GetRecipe", queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return recipeDetails;
        }
    }
}
