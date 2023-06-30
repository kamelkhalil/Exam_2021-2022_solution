using System.ComponentModel.DataAnnotations;

namespace Exam_2021_2022_solution.Models
{
	public class AppBindingModel
	{
		[Required(ErrorMessage ="the Full Name is Requirred")]
		[Display(Name ="Full Name : ")]
		public string FullName { get; set; }
		[Required]
		[Range(0,300, ErrorMessage = "A Should be between 1 and 300")]
		public int A { get; set; }
		[Required]
		[Range(0, 300, ErrorMessage = "C Should be between 1 and 300")]
		public int B { get; set; }
		[Required]
		[Range(0, 300, ErrorMessage = "C Should be between 1 and 300")]
		public int C { get; set; }
	}
}
