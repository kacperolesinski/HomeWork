using HomeWork.Core.ApiClient;
using HomeWork.Core.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace HomeWork.Core.ViewModels
{
    public class CDViewModel
    {
        private readonly IView _view;
        private readonly ICDService _cdService;

        public IEnumerable<CD> CDs { get; set; }

        public ICommand DownloadCDsCommand { get; set; }
        
        public CDViewModel(IView view, ICDService cdService)
        {
            _view = view;
            _cdService = cdService;
            DownloadCDsCommand = new RelayCommand(LoadCDs);
        }

        private void LoadCDs()
        {
            CDs = _cdService.GetCDs();
            _view.Update();
        }
    }
}
