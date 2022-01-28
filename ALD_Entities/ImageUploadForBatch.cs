namespace ALD_Entities
{
    public class ImageUploadForBatch
    {
        public string BatchID { get; set; }
        public string ImageType { get; set; }
        public string ImageFilePath { get; set; }
        public bool IsOverWrite { get; set; }
    }
}
