using System;
using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace GermanProject.Models
{
    public class ApplicationRepository : IApplicationRepository
    {
        private ApplicationDbContext _context;
        private ILogger<ApplicationRepository> _logger;

        public ApplicationRepository(ApplicationDbContext context, ILogger<ApplicationRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IEnumerable<Chapter> GetAllChapters()
        {
            try
            {
                return _context.Chapters.OrderBy(c => c.ChapterId).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get trips chapters from database", ex);
                return null;
            }
            
        }
    }
}
