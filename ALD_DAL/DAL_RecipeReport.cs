using Entities;
using System.Collections.Generic;

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
