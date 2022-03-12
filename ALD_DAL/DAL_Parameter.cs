using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalParameter
    {
        public List<EParameter> D_GetParameterByBatchID(ReqByBatchId obj)
            => DbAccess.GetDataByBatch<EParameter>(obj.BatchId, Constants.GetParameterByBatchId,Constants.ConnStringReport);
        public List<EParameter> D_GetParameterByDur(ReportRq obj)
           => DbAccess.GetDataByDuration<EParameter>(obj, Constants.GetParameterByDuration, Constants.ConnStringReport);

    }
}
