using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalProcessReport
    {

        public List<ProcessReport> GetProcessDetailsByBatchId(ProcessReport_RQ obj)
            => DbAccess.GetDataByBatch<ProcessReport>(obj.BatchId, Constants.ProcessDetailByBatchId, Constants.ConnStringReport);

        public List<UniformityReport> GetUniformityDetailsByBatchId(UniformityReport_RQ obj)
            => DbAccess.GetDataByBatch<UniformityReport>(obj.BatchId, Constants.UniformityDetailByBatchId, Constants.ConnStringReport);

    }
}
