using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase.Classes {
	internal abstract class Human {

		

		public Human(string? firstName, string? lastName, string? telNumber){
			
		}

		public abstract List<string> GetInfo(List<Assign> assigns)
	}
}
