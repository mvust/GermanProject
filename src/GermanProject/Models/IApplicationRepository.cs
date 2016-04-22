using System.Collections.Generic;

namespace GermanProject.Models
{
    public interface IApplicationRepository
    {
        IEnumerable<Chapter> GetAllChapters();
        List<VocabWord> GetAllVocabByChapter(int chapter);
        Result GetResultbyUserAndChapter(string user, int chapter);
        void AddResult(string user, int chapter, int correct, int wrong);
        void UpdateResult(string user, int chapter, int correct, int wrong);
    }
}