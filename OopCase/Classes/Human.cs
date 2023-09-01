using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase.Classes {
	internal abstract class Human {


		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		public string? Tel { get; set; }
		public Human(string? firstName, string? lastName, string? telNumber){
			
		}

		public Human() { }

		public abstract List<string> GetInfo(List<Assign> assigns);
	}
}
