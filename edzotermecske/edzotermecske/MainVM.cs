using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;

namespace edzotermecske
{
    class MainVM : ViewModelBase

    {
        public MainVM()
        {
            CMD_Add = new RelayCommand(Add, AddCanExecute);
            CMD_New = new RelayCommand(New, NewCanExecute);
            CMD_Del = new RelayCommand(Del, DelCanExecute);
            
            Employees = new ObservableCollection<Employee>();
            this.PropertyChanged += MainVM_PropertyChanged; 
            
            
            
        }

        

        private void MainVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SearchWord":
                    Length_SearchWord = SearchWord.Length;
                    break;
                case "Selected":
                    SelectedNotNull = Selected != null;
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

        private Employee selected;
        private bool selectedNotNull;



        public int Length_SearchWord { get => length_SearchWord; set => Set(ref length_SearchWord, value); }
        public int Length_Elements { get => length_Elements; set => Set(ref length_Elements, value); }

        public bool SelectedNotNull { get => selectedNotNull; set => Set(ref selectedNotNull, value); }


        public ObservableCollection<string> Elements { get; private set; }


        public ObservableCollection<Employee> Employees { get; private set; }
        public Employee Selected { get => selected; set => Set(ref selected, value); }

        public ICommand CMD_Add { get; private set; }
        public ICommand CMD_New { get; private set; }
        public ICommand CMD_Del { get; private set; }
      

        private void Add()
        {
            Employees.Add(Selected);
        }
        private bool AddCanExecute()
        {
            return SelectedNotNull && !string.IsNullOrWhiteSpace(Selected.FirstName) && !string.IsNullOrWhiteSpace(Selected.LastName) && !Employees.Contains(Selected);
        }
        private void Del()
        {
            Employees.Remove(Selected);
            
            
        }
        private bool DelCanExecute()
        {
            return SelectedNotNull && Employees.Contains(Selected);
        }
        private void New()
        {
            Selected = new Employee();
        }
        private bool NewCanExecute()
        {
            return true;
        }
    }
}
