using System.Windows.Input;

namespace FacadeTest
{
    public class MainWindowViewModel : ViewModelBase
    {
        private DataViewModel m_data;
        private FacadeViewModel m_facade;

        public MainWindowViewModel()
        {
            m_data = new DataViewModel("Thing");
            m_facade = new FacadeViewModel(m_data);
        }

        public DataViewModel Original => m_data;

        public FacadeViewModel Facade => m_facade;

        public ICommand RenameCommand
        {
            get
            {
                return new DelegateCommand(o => 
                {
                    m_data.Thing = "Renamed";
                });
            }
        }
    }
}
