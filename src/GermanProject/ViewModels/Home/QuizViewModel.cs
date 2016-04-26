using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GermanProject.Models;

namespace GermanProject.ViewModels.Home
{
    public class QuizViewModel
    {
        public int Chapter { get; set; }
        public List<string> Answer { get; set; } 
    }
}
