namespace MyResume.Models
{
    public class Education
    {
        public int Id { get; set; }
        public int  ResumeId { get; set; }
        public Resume Resume { get; set; }
        public string Degree { get; set; }
        public string Institutaion { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
    }
}
