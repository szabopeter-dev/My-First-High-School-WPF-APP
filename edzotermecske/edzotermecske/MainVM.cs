using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edzotermecske
{
    class MainVM : ViewModelBase
    {

        public MainVM()
        {
            this.PropertyChanged += MainVM_PropertyChanged;
        }

        private void MainVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "SearchWord":
                    CharNum = SearchWord.Length;
                    break;
                default:
                    break;
            }
        }

        private string searchWord;
        private int charNum;

        public string SearchWord { get => searchWord; set => Set(ref searchWord, value); }
        public int CharNum { get => charNum; set => Set(ref charNum, value); }

    }
}
