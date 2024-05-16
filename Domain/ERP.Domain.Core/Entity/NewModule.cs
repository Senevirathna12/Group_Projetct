using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity
{
	public class NewModule
	{
		[Key]
		public int ModuleId { get; set; }
		
		public  string ModuleCode { get; set; }

		public string ModuleName { get; set; }

		public int semester {  get; set; }

		public int Credit {  get; set; }

		public Teacher Teacher { get; set; }

		public int teacherId { get; set; }
		
		public int Department {  get; set; }
	}
}
