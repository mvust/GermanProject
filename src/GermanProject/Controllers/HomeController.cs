using System;
using GermanProject.Models;
using GermanProject.ViewModels.Home;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace GermanProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationRepository _repository;

        public HomeController(IApplicationRepository repository)
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
        [HttpGet]
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
                
                if (answers[0].Definition.Equals(quiz.Answer1, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[1].Definition.Equals(quiz.Answer2, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[2].Definition.Equals(quiz.Answer3, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[3].Definition.Equals(quiz.Answer4, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[4].Definition.Equals(quiz.Answer5, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[5].Definition.Equals(quiz.Answer6, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[6].Definition.Equals(quiz.Answer7, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[7].Definition.Equals(quiz.Answer8, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }


                if (answers[8].Definition.Equals(quiz.Answer9, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[9].Definition.Equals(quiz.Answer10, StringComparison.OrdinalIgnoreCase))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

               _repository.UpdateResult(User.Identity.Name, quiz.Chapter, correct, wrong);
               return RedirectToAction("Results", "Home");
            }

            return View();
        }

        [Authorize]
        public IActionResult Results()
        {
            return View(_repository.GetResultbyUser(User.Identity.Name));
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