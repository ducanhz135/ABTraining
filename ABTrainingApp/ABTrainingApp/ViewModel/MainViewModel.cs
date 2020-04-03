using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ABTrainingApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string _Name;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }

        private string _Age;
        public string Age { get => _Age; set { _Age = value; OnPropertyChanged(); } }

        private ComboBoxItem _Nation;
        public ComboBoxItem Nation { get => _Nation; set { _Nation = value; OnPropertyChanged(); } }

        private bool _IsMarried;
        public bool IsMarried { get => _IsMarried; set { _IsMarried = value; OnPropertyChanged(); } }

        public string gender { get; set; }

        public ICommand ShowCommand { get; set; }
        public ICommand RadioButtonCommand { get; set; }

        public MainViewModel()
        {
            ShowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MessageBox.Show("My name is " + Name 
                    + "\nI am " + Age 
                    + "years old \nI am " + gender + "\nI am from " + Nation.Content.ToString() 
                    + "\nI am " + (IsMarried ? string.Empty : "not") + " Married");


            });

            RadioButtonCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                gender = p.ToString();
            });
        }
    }
}
