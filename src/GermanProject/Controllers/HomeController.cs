using GermanProject.Models;
using GermanProject.ViewModels.Manage;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.CodeAnalysis.CSharp;

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
            var quiz = _repository.GetAllVocabByChapter(chapter);
            return View(quiz);
        }

        [HttpPost]
        public IActionResult Quiz(QuizViewModel quiz)
        {
            if (ModelState.IsValid)
            {
                var answers = _repository.GetAllVocabByChapter(1);
                var correct = 0;
                var wrong = 0;
                
                if (answers[0].Definition == quiz.Answer1)
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (answers[1].Definition == quiz.Answer2)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                if (answers[2].Definition == quiz.Answer3)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                if (answers[3].Definition == quiz.Answer4)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                if (answers[4].Definition == quiz.Answer5)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                if (answers[5].Definition == quiz.Answer6)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                if (answers[6].Definition == quiz.Answer7)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                if (answers[7].Definition == quiz.Answer8)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }


                if (answers[8].Definition == quiz.Answer9)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                if (answers[9].Definition == quiz.Answer10)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }

                _repository.UpdateResult(User.Identity.Name, 1, correct, wrong);
                return RedirectToAction("Results", "Home");
            }

            // If we got this far, something failed, redisplay form
            return View();
        }

        [Authorize]
        public IActionResult Results()
        {
            var user = User.Identity.Name;
            var result = _repository.GetResultbyUserAndChapter(user, 1);
            return View(result);
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