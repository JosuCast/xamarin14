using Lab14C.Model;
using Lab14C.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab14C.ViewModels
{
    public class ViewModelCourses : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Course> courses;
        public List<Course> Courses
        {
            get { return this.courses; }
            set { SetValue(ref this.courses, value); }
        }

        public ICommand SearchCommand { get; set; }

        public ViewModelCourses()
        {

            SearchCommand = new Command(() =>
            {
                CourseService service = new CourseService();
                Courses = service.GetByText(Filter);
                if (Courses.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });


        }
    }
}
