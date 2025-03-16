namespace MyResume.Models
{
    public class Language
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public string LanguageName { get; set; }
        public string Proficiency { get; set; }
    }
}
