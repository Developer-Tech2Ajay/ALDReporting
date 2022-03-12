using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalRecipeReport
    {
        public List<Recipe_Report> GetRecipeReports(ReqByBatchId req) =>
        DbAccess.GetDataByBatch<Recipe_Report>(req.BatchId, Constants.GetRecipeDetails, Constants.ConnStringReport);


        public List<RecipeDetails> GetRecipeDetails(ReqByBatchId req) =>
         DbAccess.GetDataByBatch<RecipeDetails>(req.BatchId, Constants.GetRecipe, Constants.ConnStringReport);

    }
}
