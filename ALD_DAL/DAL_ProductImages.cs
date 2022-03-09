using Entities;
using System.Linq;

namespace ALD_DAL
{
    public class DalProductImages
    {
        public SystemMessage CheckEligibilityForUpload(ImageUploadForBatch obj) =>
            DbAccess.CheckEligibilityForUpload(obj);

        public SystemMessage D_InsUpdImageForBatchID(ImageUploadForBatch obj) =>
            DbAccess.InsUpdImageForBatchId(obj);

        public ProductImages GetProductImages(ReqByBatchId obj)
        {
            var lst =
                DbAccess.GetDataByBatch<ProductImages>(obj.BatchId, Constants.GetImagesByBatchId, Constants.ConnStringReport);
            return lst.FirstOrDefault();
        }
    }
}
