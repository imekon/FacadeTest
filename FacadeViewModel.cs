namespace FacadeTest
{
    public class FacadeViewModel : ViewModelBase
    {
        //private string m_thing;
        private DataViewModel m_data;

        public FacadeViewModel(DataViewModel data)
        {
            m_data = data;
            //m_thing = data.Thing;

            m_data.PropertyChanged += (o, n) =>
            {
                if (n.PropertyName == "Thing")
                {
                    //m_thing = data.Thing;
                    OnPropertyChanged(nameof(Thing));
                }
            };
        }

        public string Thing
        {
            get => "The thing is: " + m_data.Thing; //m_thing;
        }
    }
}
