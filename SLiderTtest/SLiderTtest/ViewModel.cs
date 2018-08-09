using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace SLiderTtest
{
    public class ViewModel : INotifyPropertyChanged
    {
        ICommand theCommand;
        public ICommand DoCommand => theCommand ?? (theCommand = new Command(() => Val = Val2));
        int min = 10;
        public int Min
        {
            get => min;
            set
            {
                min = value;
                NPC();
            }
        }
        int max = 100;
        public int Max
        {
            get => max;
            set
            {
                max = value;
                NPC();
            }
        }
        int val = 50;
        public int Val
        {
            get => val;
            set
            {
                val = value;
                NPC();
            }
        }
        int val2 = 50;
        public int Val2
        {
            get => val2;
            set
            {
                val2 = value;
                NPC();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NPC([CallerMemberName] String propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}