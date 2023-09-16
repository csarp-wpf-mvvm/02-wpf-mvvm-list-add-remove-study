using CommunityToolkit.Mvvm.ComponentModel;
using StudentProject.Models;

namespace StudentProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student;

        public StudentViewModel()
        {
            _student = new Student();
        }
    }
}
