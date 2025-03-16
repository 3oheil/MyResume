namespace MyResume.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public string InterestName { get; set; }
    }
}
