using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalCorrectionFactor
    {
        public List<CorrectionFactor> GetCorrectionFactorByBatchId(ReqByBatchId obj)
            => DbAccess.GetDataByBatch<CorrectionFactor>(obj.BatchId, Constants.GetCorrectionFactorByBatchId, Constants.ConnStringReport);
    }
}
