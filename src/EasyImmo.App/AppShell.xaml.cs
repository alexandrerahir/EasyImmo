using EasyImmo.App.Views.Folders;
using EasyImmo.App.Views.People;
using EasyImmo.App.Views.Properties;

namespace EasyImmo.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Enregistrement des routes

            // People
            Routing.RegisterRoute(nameof(PersonDetailPage), typeof(PersonDetailPage));
            Routing.RegisterRoute(nameof(AddPersonPage), typeof(AddPersonPage));
            Routing.RegisterRoute(nameof(EditPersonPage), typeof(EditPersonPage));

            // Properties
            Routing.RegisterRoute(nameof(AddPropertyPage), typeof(AddPropertyPage));
            Routing.RegisterRoute(nameof(EditPropertyPage), typeof(EditPropertyPage));
            Routing.RegisterRoute(nameof(DetailsPropertyPage), typeof(DetailsPropertyPage));

            // Folder
            Routing.RegisterRoute(nameof(DetailsFolderPage), typeof(DetailsFolderPage));
            Routing.RegisterRoute(nameof(EditStatusFolderPage), typeof(EditStatusFolderPage));
            Routing.RegisterRoute(nameof(AddStepFolderPage), typeof(AddStepFolderPage));
            Routing.RegisterRoute(nameof(AddListingPage), typeof(AddListingPage));
        }
    }
}
