using System;
using GermanProject.Models;
using GermanProject.ViewModels.Home;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace GermanProject.Controllers
{
    public class AppController : Controller
    {
        private readonly IApplicationRepository _repository;

        public AppController(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chapters()
        {
            var chapters = _repository.GetAllChapters();
            return View(chapters);
        }

        public IActionResult Review(int chapter)
        {
            var review = _repository.GetAllVocabByChapter(chapter);
            return View(review);
        }

        [Authorize]
        public IActionResult Quiz(int chapter)
        {
            ViewData["VocabWords"] = _repository.GetAllVocabByChapter(chapter);
            return View();
        }

        [HttpPost]
        public IActionResult Quiz(QuizViewModel quiz)
        {
            if (ModelState.IsValid)
            {
                var answers = _repository.GetAllVocabByChapter(quiz.Chapter);
                var correct = 0;
                var wrong = 0;

                for (var i = 0; i < quiz.Answer.Count; i++)
                {
                    if (answers[i].Definition.Equals(quiz.Answer[i], StringComparison.OrdinalIgnoreCase))
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                
                _repository.UpdateResult(User.Identity.Name, quiz.Chapter, correct, wrong);
                return RedirectToAction("Results", "App");
            }

            return View();
        }

        [Authorize]
        public IActionResult Results()
        {
            var results = _repository.GetResultbyUser(User.Identity.Name);
            return View(results);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}