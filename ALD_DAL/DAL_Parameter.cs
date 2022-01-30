using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalParameter
    {
        public List<E_Parameter> D_GetParameterByBatchID(ProcessReport_RQ obj)
            => DbAccess.GetDataByBatch<E_Parameter>(obj.BatchId, Constants.GetParameterByBatchId,Constants.ConnStringReport);

    }
}
