using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase.Classes {
	internal class Doctor : Human {

		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public Doctor(string? firstName, string? lastName, string? Spicale , string? telNumber) : base (firstName, lastName, telNumber){
			FirstName = firstName;
			LastName = lastName;
		}

		public override List<string> GetInfo(List<Assign> assigns) {

			return GetInfo(assigns);
		}
	}
}
