using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using System.Diagnostics;

namespace edzotermecske
{
    class MainVM : ViewModelBase

    {
        public MainVM()
        {

            CMD_Clear = new RelayCommand(Clear);
            CMD_Add = new RelayCommand(Add, AddCanExecute);
            Elements = new ObservableCollection<string>();
            Elements.CollectionChanged += Elements_CollectionChanged;
            this.PropertyChanged += MainVM_PropertyChanged;
        }

        private void MainVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SearchWord":
                    Length_SearchWord = SearchWord.Length;
                    break;
                default:
                    break;
            }
        }

        private void Elements_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            
            Length_Elements = Elements.Count;
        }

        //textblock list 
        private int length_Elements;
        //textblock 
        private int length_SearchWord;
        //textbox 
        private string searchWord;
        public string SearchWord
        {
            get => searchWord;
            set => Set(ref searchWord, value);
              
        }
        public int Length_SearchWord { get => length_SearchWord; set => Set(ref length_SearchWord, value); }
        public int Length_Elements { get => length_Elements; set => Set(ref length_Elements, value); }

        public ICommand CMD_Clear { get; set; }
        public ICommand CMD_Add { get; set; }
        private void Clear()
        {
            SearchWord = "";
        }

        private void Add()
        {

            Elements.Add(SearchWord);
            SearchWord = "";


        }

        private bool AddCanExecute()
        {
            return !string.IsNullOrWhiteSpace(SearchWord);
        }

        public ObservableCollection<string> Elements { get; private set; }

    }
}
