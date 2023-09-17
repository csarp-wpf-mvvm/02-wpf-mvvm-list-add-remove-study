using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentProject.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student;

        [ObservableProperty]
        private ObservableCollection<string> _educationLevels = new ObservableCollection<string>(new EducationLevels().AllEducationLevels);

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        [ObservableProperty]
        private Student _selectedStudent;

        public StudentViewModel()
        {
            _student = new Student();
            Students.Add(new Student("Elek", "Teszt", System.DateTime.Now, 9, SchoolClassType.ClassA, ""));
        }

        [RelayCommand]
        public void DoSave(Student newStudent)
        {
            Students.Add(newStudent);
            OnPropertyChanged(nameof(Students));
        }
    }
}
