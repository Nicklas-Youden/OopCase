using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase.Classes {
	internal class Patient : Human {
		public Patient()
		{
		}

		public Patient(string? firstName, string? lastName, string? telNumber, Doctor doctor) : base (firstName, lastName, telNumber){
		
		}

		public override List<string> GetInfo(List<Assign> assigns)
		{

			return GetInfo(assigns);
		}
	}
}
