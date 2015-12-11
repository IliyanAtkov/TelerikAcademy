using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FirstTask.Helpers;

namespace FirstTask.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Person> people;

        public MainViewModel()
        {
            this.people = new ObservableCollection<Person>();
            this.Adds();
        }


        public IEnumerable<Person> People
        {
            get
            {
                return this.people;
            }
            set
            {
                if (this.people == null)
                {
                    this.people = new ObservableCollection<Person>();
                }

                this.people.Clear();
                this.people.AddRange(value);
            }
        }

        private void Adds()
        {
            var peoples1 = new Person("Gosho", "http://cdn1.matadornetwork.com/blogs/1/2015/04/lion-photo.jpg");

            var peoples2 = new Person("Pesho", "http://cdn1.matadornetwork.com/blogs/1/2015/04/lion-photo.jpg");

            var peoples3 = new Person("Traicho", "http://cdn1.matadornetwork.com/blogs/1/2015/04/lion-photo.jpg");

            people.Add(peoples1);
            people.Add(peoples2);
            people.Add(peoples3);
        }

        public void AddPerson(Person person)
        {
            this.people.Add(person);
        }
    }
}
