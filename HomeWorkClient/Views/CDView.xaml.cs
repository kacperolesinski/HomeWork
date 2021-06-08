using HomeWork.Core;
using HomeWork.Core.ApiClient;
using HomeWork.Core.ViewModels;
using System.Windows.Controls;

namespace HomeWorkClient.Views
{
    /// <summary>
    /// Logika interakcji dla klasy CDView.xaml
    /// </summary>
    public partial class CDView : Page, IView
    {
        private CDViewModel cdViewModel;
        public CDView()
        {
            InitializeComponent();

            cdViewModel = new CDViewModel(this, new CDService());
            DataContext = cdViewModel;
        }

        public void Update()
        {
            this.DG1.ItemsSource = null;
            this.DG1.ItemsSource = cdViewModel.CDs;
        }
    }
}
