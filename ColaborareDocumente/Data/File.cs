namespace ColaborareDocumente.Data
{
    public class File
    {
        public int FileId { get; set; }
        public int ParentFolderId { get; set; }
        public string FileName { get; set; }
        public string BlobName { get; set; }
        public string BlobUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ArchivedBy { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool Archived { get; set; }

        // Constructor
        public File()
        {
            // Set defaults
            Archived = false;
            CreatedDate = DateTime.Now;
        }
    }
}
