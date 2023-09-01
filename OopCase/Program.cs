// See https://aka.ms/new-console-template for more information


using OopCase.Classes;

Doctor Peter = new("Peter", "Hansen", "Øjenlæge", "11111111");
Doctor Martin = new("Martin", "Jensen", "Radiologi", "22222222");
Doctor Thomas = new("Thomas", "Olsen", "Kirurgi", "33333333");
Doctor Ole = new("Ole", "Nilsen", "Oncologi", "44444444");

List<Doctor> doctor = new() { Peter, Martin, Thomas, Ole };
List<Assign> assings = new List<Assign>();

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

		Doctor? doctorChoice = AssignDoctor(doctor);


		Assign a = new Assign(patient, doctorChoice);

		assings.Add(a);
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