using System.Collections.ObjectModel;

namespace PickerSample
{
    public class MainViewModel
    {
        public ObservableCollection<Monkey> Items { get; set; } = new();
        public Monkey SelectedItem { get; set; }

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
        }
    }
}
