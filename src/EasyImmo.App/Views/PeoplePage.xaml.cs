namespace EasyImmo.App.Views;

public partial class PeoplePage : ContentPage
{
	public PeoplePage()
	{
		InitializeComponent();

        PeopleCollection.ItemsSource = new List<object>
        {
            new {
                FirstNamePerson = "Alexandre",
                LastNamePerson = "Rahir",
                EmailPerson = "alexandrerahir@gmail.com",
                PhonePerson = "+32 468 12 34 56"
            },
            new {
                FirstNamePerson = "Dymitri",
                LastNamePerson = "Bourgeaux",
                EmailPerson = "dymitri@gmail.com",
                PhonePerson = "+32 468 12 34 56"
            },
            new {
                FirstNamePerson = "Guillaume",
                LastNamePerson = "Dichou",
                EmailPerson = "dichou@outlook.be",
                PhonePerson = "+32 468 12 34 56"
            }
        };
    }
}