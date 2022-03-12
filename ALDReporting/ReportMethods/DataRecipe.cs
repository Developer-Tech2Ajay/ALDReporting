using ALD_DAL;
using Entities;
using Microsoft.Reporting.WinForms;

namespace ALDReporting.ReportMethods
{
    public class DataRecipe
    {
        public DataRecipe()
        {
                
        }

        public DataRecipe(ReportViewer rptViewer,string batchId)
        {
            var dalRr = new DalRecipeReport();
            CommonUtils.AddDataSource(rptViewer, "dsRecipeDetails", CustomSystemClass.ToDataTable<Recipe_Report>(dalRr.GetRecipeReports(new ReqByBatchId() { BatchId = batchId })));
            CommonUtils.AddDataSource(rptViewer, "dsRecipe", CustomSystemClass.ToDataTable<RecipeDetails>(dalRr.GetRecipeDetails(new ReqByBatchId() { BatchId = batchId })));
            rptViewer.LocalReport.DisplayName = "Recipe Report  " + batchId;
            //rptViewer.RemoveOptionToDownload();
            rptViewer.RefreshReport();
        }
        
    }
}
    