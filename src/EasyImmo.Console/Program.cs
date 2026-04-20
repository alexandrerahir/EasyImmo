using EasyImmo.Business.Services;

var people = PersonService.GetPeople();

foreach (var person in people)
{
    Console.WriteLine($"ID: {person.PersonId}, Name: {person.FirstNamePerson} {person.LastNamePerson}");
}
