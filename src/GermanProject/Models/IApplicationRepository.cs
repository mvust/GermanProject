using System.Collections.Generic;

namespace GermanProject.Models
{
    public interface IApplicationRepository
    {
        IEnumerable<Chapter> GetAllChapters();
    }
}