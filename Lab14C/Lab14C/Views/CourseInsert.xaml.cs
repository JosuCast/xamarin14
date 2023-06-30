using Lab14C.Model;
using Lab14C.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab14C.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseInsert : ContentPage
    {
        public CourseInsert()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CourseService service = new CourseService();
            List<Course> courses = new List<Course>();

            for(int i = 0; i < 3; i++)
            {
                courses.Add(new Course { });

                service.CreateRange(courses);
            }

        }
    }
}