using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase.Classes {
	internal class Doctor : Human {


        public string? Special { get; set; }
        public Doctor(string? firstName, string? lastName, string? speciale , string? telNumber) : base (firstName, lastName, telNumber){
			FirstName = firstName;
			LastName = lastName;
			Special = speciale;
		}

		public override List<string> GetInfo(List<Assign> assigns) {

			return GetInfo(assigns);
		}
	}
}
