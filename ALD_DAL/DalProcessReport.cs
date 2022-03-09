using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalReport
    {

        public List<ProcessReport> GetProcessDetailsByBatchId(ReqByBatchId obj)
            => DbAccess.GetDataByBatch<ProcessReport>(obj.BatchId, Constants.ProcessDetailByBatchId, Constants.ConnStringReport);

        public List<UniformityReport> GetUniformityDetailsByBatchId(ReqByBatchId obj)
            => DbAccess.GetDataByBatch<UniformityReport>(obj.BatchId, Constants.UniformityDetailByBatchId, Constants.ConnStringReport);

        public List<UniformityReport> GetLoadTcDetailsByBatchId(ReqByBatchId obj)
            => DbAccess.GetDataByBatch<UniformityReport>(obj.BatchId, Constants.LoadTCDeatilsByBatchID, Constants.ConnStringReport);

        public List<CorrectionFactor> GetCorrectionFactorByBatchId(ReqByBatchId obj)
            => DbAccess.GetDataByBatch<CorrectionFactor>(obj.BatchId, Constants.GetCorrectionFactorByBatchId, Constants.ConnStringReport);

        public List<ProcessReport> GetProcessByDur(ReportRq obj)
            => DbAccess.GetDataByDuration<ProcessReport>(obj, Constants.GetProcessDeatilsByDur, Constants.ConnStringReport);
       

    }
}
