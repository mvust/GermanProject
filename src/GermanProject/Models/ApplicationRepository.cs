using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace GermanProject.Models
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ApplicationRepository> _logger;

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
                _logger.LogError("Could not get chapters from database", ex);
                return null;
            }
        }

        public List<VocabWord> GetAllVocabByChapter(int chapter)
        {
            try
            {
                return _context.VocabWords
                    .Where(w => w.ChapterId == chapter)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get words from database by chapter number", ex);
                return null;
            }
        }

        public List<Result> GetResultbyUser(string user)
        {
            try
            {
                return _context.Results
                    .Where(r => r.UserName == user)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get result from database by user and chapter", ex);
                return null;
            }
        }
        public Result GetResultbyUserAndChapter(string user, int chapter)
        {
            try
            {
                return _context.Results
                    .Where(r => r.UserName == user && r.ChapterId == chapter)
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get result from database by user and chapter", ex);
                return null;
            }

        }

        public void UpdateResult(string user, int chapter, int correct, int wrong)
        {
            if (_context.Results.Any(r => r.UserName == user && r.ChapterId == chapter))
            {
                var result = GetResultbyUserAndChapter(user, chapter);
                result.Correct = correct;
                result.Wrong = wrong;
                _context.SaveChanges();
            }
            else
            {
                AddResult(user, chapter, correct, wrong);
            }
        }

        public void AddResult(string user, int chapter, int correct, int wrong)
        {
            try
            {
                var newResult = new Result
                {
                    UserName = user,
                    ChapterId = chapter,
                    Correct = correct,
                    Wrong = wrong
                };

                _context.Add(newResult);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not add result", ex);
            }
        }
    }
}