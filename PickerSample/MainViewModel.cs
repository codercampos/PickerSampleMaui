using System.Collections.ObjectModel;

namespace PickerSample
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Monkey> Items { get; set; } = new();

        private Monkey _selectedItem;
        public Monkey SelectedItem 
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public MainViewModel()
        {
            GenerateMonkeys();
        }

        private void GenerateMonkeys()
        {
            Items.Add(new Monkey("Baboon"));
            Items.Add(new Monkey("Cappucin Monkey"));
            Items.Add(new Monkey("Blue Monkey"));
            Items.Add(new Monkey("Squirrel Monkey"));

            SelectedItem = Items.FirstOrDefault();
        }
    }
}
