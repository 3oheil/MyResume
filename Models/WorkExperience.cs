namespace MyResume.Models
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public string? JobTitle { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate {  get; set; }
    }
}