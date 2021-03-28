using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace edzotermecske
{
    class Employee : ObservableObject
    {

        public Employee()
        {
            this.PropertyChanged += Employee_PropertyChanged;
        }

        private void Employee_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "BirthDate":
                    if(BirthDate.HasValue)
                    {
                        Age = DateTime.Now.Year - BirthDate.Value.Year;
                       
                    }
                    else
                    {
                        Age = null;
                    }
                    break;
                default:
                    break;
            }
        }

        private string firstName, lastName;
        private DateTime? birthDate;
        private int? age;


        public string FirstName { get => firstName; set => Set(ref firstName, value); }
        public string LastName { get => lastName; set => Set(ref lastName, value); }
        public DateTime? BirthDate { get => birthDate; set => Set(ref birthDate, value); }
        public int? Age { get => age; private set => Set(ref age, value); }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
