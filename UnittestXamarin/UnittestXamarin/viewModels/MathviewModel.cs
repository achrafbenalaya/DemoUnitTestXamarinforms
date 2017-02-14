using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace UnittestXamarin.viewModels
{
   public class MathviewModel :INotifyPropertyChanged
    {

        private int   _VA { get; set; }

        public int VA
        {
            get { return _VA; }
            set
            {
                _VA = value;
                
                OnPropertyChanged();
            }



        }

        private int _Vb { get; set; }

        public int Vb
        {
            get { return _Vb; }
            set
            {
                _Vb = value;

                OnPropertyChanged();
            }



        }


        private int _res { get; set; }

        public int res
        {

            get { return _res; }
            set
            {
                _res = value;

                OnPropertyChanged();
            }




        }








        public ICommand AddCommand

        {


            get
            {

                return new Command(() =>

                {
                    res = _VA + _Vb ;
                }

            );

        }
        }




        public ICommand Multiply

        {


            get
            {

                return new Command(() =>

                {
                    res = _VA * _Vb;
                }

            );

            }
        }




















        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
