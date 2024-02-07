using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
	public class ContactİnfoDto
	{
		public int Id { get; set; }
		public string name { get; set; } = default!;
		public string email { get; set; } = default!;
		public string subject { get; set; } = default!;
		public string message { get; set; } = default!;
	}
}
