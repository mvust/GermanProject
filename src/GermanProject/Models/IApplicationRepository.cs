using System.Collections.Generic;

namespace GermanProject.Models
{
    public interface IApplicationRepository
    {
        IEnumerable<Chapter> GetAllChapters();
        List<VocabWord> GetAllVocabByChapter(int chapter);
        List<Result> GetResultbyUser(string user);
        void AddResult(string user, int chapter, int correct, int wrong);
        void UpdateResult(string user, int chapter, int correct, int wrong);
        Result GetResultbyUserAndChapter(string user, int chapter);
    }
}