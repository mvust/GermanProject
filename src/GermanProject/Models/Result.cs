namespace GermanProject.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int ChapterId { get; set; }
        public int Correct { get; set; }
        public int Wrong { get; set; }
    }
}