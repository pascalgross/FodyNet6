using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using FodyNet6.Models;

namespace PartsAndMore.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IUIVisualizerService _uiVisualizerService;
        public override string Title => "FodyNet6";

        [Model]
        [Expose("Name")]
        public Person Person { get; set; }

        public MainWindowViewModel(IUIVisualizerService uiVisualizerService)
        {
            Argument.IsNotNull(() => uiVisualizerService);
            _uiVisualizerService = uiVisualizerService;
        }
        
        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
        }

        protected override async Task CloseAsync()
        {
            await base.CloseAsync();
        }
    }
}