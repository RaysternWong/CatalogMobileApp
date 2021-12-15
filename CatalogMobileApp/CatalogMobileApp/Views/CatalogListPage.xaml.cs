using CatalogMobileApp.API;
using CatalogMobileApp.DataService;
using CatalogMobileApp.Models;
using CatalogMobileApp.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CatalogMobileApp.Views
{
    /// <summary>
    /// Page to show the catalog list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogListPage
    {
        public ICommand GetCatalogCommand { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogListPage" /> class.
        /// </summary>
        public CatalogListPage()
        {
            this.InitializeComponent();
            this.BindingContext = CatalogDataService.Instance.CatalogPageViewModel;

            GetCatalogCommand = new Command(async () => DoCatalogCommand());
        }

        private async Task DoCatalogCommand()
        {
            GetCatalog getCatalog = new GetCatalog();
            var catalogs = await getCatalog.GetAllCatalogsAsync();

            CatalogPageViewModel catalogPageViewModel = new CatalogPageViewModel();
            catalogPageViewModel.Catalogs = new ObservableCollection<Catalog>(catalogs); ;

            this.BindingContext = catalogPageViewModel;
        }
    }
}