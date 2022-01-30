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
using ALD_Entities.Util;

namespace ALD_DAL
{
    public class DalRecipeReport
    {
        public List<Recipe_Report> GetRecipeReports(ProcessReport_RQ req) =>
        DbAccess.GetDataByBatch<Recipe_Report>(req.BatchId, Constants.GetRecipeDetails, Constants.ConnStringReport);


        public List<RecipeDetails> GetRecipeDetails(ProcessReport_RQ req) =>
         DbAccess.GetDataByBatch<RecipeDetails>(req.BatchId, Constants.GetRecipe, Constants.ConnStringReport);

    }
}
