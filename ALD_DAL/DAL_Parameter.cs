using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalParameter
    {
        public List<EParameter> D_GetParameterByBatchID(ProcessReport_RQ obj)
            => DbAccess.GetDataByBatch<EParameter>(obj.BatchId, Constants.GetParameterByBatchId,Constants.ConnStringReport);

    }
}
