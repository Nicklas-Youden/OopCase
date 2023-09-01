// See https://aka.ms/new-console-template for more information


using OopCase.Classes;
// List of doctors
Doctor Peter = new("Peter", "Hansen", "Øjenlæge", "11111111");
Doctor Martin = new("Martin", "Jensen", "Radiologi", "22222222");
Doctor Thomas = new("Thomas", "Olsen", "Kirurgi", "33333333");
Doctor Ole = new("Ole", "Nilsen", "Oncologi", "44444444");

List<Doctor> doctor = new() { Peter, Martin, Thomas, Ole };

List<Assign> assings = new List<Assign>();
List<Patient> patients = new();

Patient patient = new Patient();

while(true)
{

	Console.Write("Patient Fornavn: ");
	patient.FirstName = Console.ReadLine();
	Console.Write("Patient efternavn: ");
	patient.LastName = Console.ReadLine();
	Console.Write("Patient til.nr: ");
	patient.Tel = Console.ReadLine();
	while(true)
	{
		ShowDoctors(doctor);
		Doctor? doctorChoice = null;
		//Check that doctor isnt already on patient, and onkologi and kirug is not, and doctor not have more than 3 patients
		do
		{
			doctorChoice = AssignDoctor(doctor);
		}
		while(!CheckDoctor(doctorChoice));


		//Assign a = new Assign(patient, doctorChoice);

		Console.WriteLine($"Læge {doctorChoice.FirstName} {doctorChoice.LastName} er blevet tilføjet");

		Console.WriteLine("Har du løst til at tilmelleflære læger?");
		Console.Write("Skriv 'Ja' For at tilføje en til læge");
		string Choice = Console.ReadLine().ToLower().Trim();

		if(Choice != "ja")
		{
			Console.Clear();
			break;
		}
	
	}

	patients.Add(patient);
}

bool CheckDoctor(Doctor doc)
{
	//if docter > 3 patients then check doctor = false
	//List docter inside paitent if doctorthere = true then CheckDoctor= false
	foreach(var doctorloop in patient.DoctorsList)
	{
		if(doc == doctorloop) return false;
		if(doc.Special == "Onkologi" && doctorloop.Special == "Kirug") return false;
		if(doc.Special == "Kirug" && doctorloop.Special == "Onkologi") return false;
	}

	int counter = 0;
	foreach(var patientLoop in patients)
	{
		foreach(var docloop in patientLoop.DoctorsList)
		{
			if(docloop == doc) counter++;
			if(counter > 3) return false;
		}
	}
	//List docter inside paitent doctor.Spicale idk 
	return true;
}

static void ShowDoctors(List<Doctor> doctor)
{
	for(int i = 0; i < doctor.Count; i++)
	{
		Doctor item = doctor[i];
		Console.WriteLine($"Læge ID: {i + 1}, læge:{item.FirstName} {item.LastName}");
	}
}



static Doctor AssignDoctor(List<Doctor> doctor)
{
	Console.WriteLine("Tildel Læge med id: ");
	Doctor? doctorChoice = null;
	do
	{
		string? doctorID = Console.ReadLine();
		switch(doctorID)
		{
			case "1":
				doctorChoice = doctor[0]; break;
			case "2":
				doctorChoice = doctor[1]; break;
			case "3":
				doctorChoice = doctor[2]; break;
			case "4":
				doctorChoice = doctor[3]; break;
			default: Console.WriteLine("You need to pick a doctor"); break;
		}
	} while(doctorChoice == null);
	return doctorChoice;
}