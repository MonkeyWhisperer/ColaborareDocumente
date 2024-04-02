namespace ColaborareDocumente.Data
{
    public class Folder
    {
        public int FolderId { get; set; }
        public int ParentFolderId { get; set; }
        public string FolderName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ArchivedBy { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool Archived { get; set; }

        // Constructor
        public Folder()
        {
            // Set defaults
            Archived = false;
            CreatedDate = DateTime.Now;
        }
    }
}
