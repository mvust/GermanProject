namespace GermanProject.Models
{
    public class VocabWord
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public int ChapterPart { get; set; }
        public string Word { get; set; }
        public string Definition { get; set; }
    }
}