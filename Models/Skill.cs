namespace MyResume.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int ResumeId  { get; set; }
        public Resume Resume { get; set; }
        public string SkillName { get; set; }
        public int Proficiency { get; set; }
    }
}
