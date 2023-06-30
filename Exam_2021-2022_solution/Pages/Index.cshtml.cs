using Exam_2021_2022_solution.Models;
using Exam_2021_2022_solution.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_2021_2022_solution.Pages
{
	public class IndexModel : PageModel
	{
		private readonly GameService _gameService;
		[BindProperty]
		public AppBindingModel Game {  get; set; }
		public IndexModel(GameService gameService)
		{
			_gameService = gameService;
		}
		public void OnGet()
		{

		}
		public IActionResult OnPost()
		{
			if(Game.A < Game.B)
			{
				ModelState.AddModelError("Custom Validattion", "A Should be greater then B !");
			}
			if(Game.A < Game.C)
			{
				ModelState.AddModelError("Customer Validation", "A Should be greater then C !");
			}
			if(ModelState.IsValid)
			{
				ResultViewModel res = _gameService.CalculateScore(Game.A, Game.B, Game.C);
				res.Name = Game.FullName;
				return RedirectToPage("Result",res);
			}
			return Page();
		}
	}
}
