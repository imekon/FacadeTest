namespace FacadeTest
{
    public class DataViewModel : ViewModelBase
    {
        private string m_thing;

        public DataViewModel(string thing)
        {
            m_thing = thing;
        }

        public string Thing
        {
            get => m_thing;
            set
            {
                m_thing = value;
                OnPropertyChanged();
            }
        }
    }
}
