using Exam_2021_2022_solution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exam_2021_2022_solution.Pages
{ 
    public class ResultModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public ResultViewModel resultViewModel { get; set; }
        public void OnGet()
        {
        }
    }
}
