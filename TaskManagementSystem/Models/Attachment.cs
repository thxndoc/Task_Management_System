namespace TaskManagementSystem.Models
{
    public class Attachment
    {
        public int AttachmentId { get; set; }
        public int TaskId { get; set; }
        public int UploadedByUserId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; } // size in bytes
        public string UploadedDate { get; set; }
    }
}
