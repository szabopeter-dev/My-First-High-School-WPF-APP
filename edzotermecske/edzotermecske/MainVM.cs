using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;

namespace edzotermecske
{
    class MainVM : ViewModelBase

    {
        public MainVM()
        {
            CMD_Clear = new RelayCommand(Clear);
        }
        //textblock databinding
        private int length_SearchWord;
        //textbox db
        private string searchWord;
        public string SearchWord
        { 
            get => searchWord;
            set
            {

                Set(ref searchWord, value);
                Length_SearchWord = searchWord.Length;
            }
        }
        public int Length_SearchWord { get => length_SearchWord; set => Set(ref length_SearchWord, value); }

        public ICommand CMD_Clear { get; set; }
        private void Clear()
        {
            SearchWord = "";
        }

    }
}
