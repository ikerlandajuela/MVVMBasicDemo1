using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVVMBasicDemo1.Model; 
using System.Collections.ObjectModel;

namespace MVVMBasicDemo1.ViewModel
{
    class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });
            students.Add(new Student { FirstName = "Iker", LastName = "Landajuela" });

            Students = students;
        } 
    }
}