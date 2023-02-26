using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace INPC
{
    public class PersonModel : ObservableObject
    {
        private string _name;

        public PersonModel()
        {
            Task.Run(() => {
                while (true)
                {
                    Random r = new Random();
                    Name = r.Next(1, 1000).ToString();
                    Debug.WriteLine($"Name : {Name}");
                    Thread.Sleep(500);
                }
            });
        }
        public string Name
        {
            get { return _name; }
            set { 
                _name = value;
                OnPropertyChanged();
            }
        }

    }
}
