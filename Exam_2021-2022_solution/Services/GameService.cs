using Exam_2021_2022_solution.Models;

namespace Exam_2021_2022_solution.Services
{
	public class GameService
	{
		public ResultViewModel CalculateScore(int A, int B, int C)
		{
			//(A-B) / (B + C)
			int a = A - B;
			int b = B + C;
			double score = (double)a / (double)b;
			if (score > 1)
			{
				return new ResultViewModel { Score = score, IsWinner = true };
			}
			else
			{
				return new ResultViewModel { Score = score, IsWinner = false };
			}
		}
	}

}