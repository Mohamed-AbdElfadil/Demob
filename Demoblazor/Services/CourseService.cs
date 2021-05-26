using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demoblazor.Models;

namespace Demoblazor.Services
{
    public class CourseService
    {
        public readonly List<Course> _Courses;
        public CourseService()
        {
            _Courses = new List<Course> {
            new Course{CourseID=1,Name="C#",Price=100,Desc="Advanced C#",Imgurl="https://www.avenga.com/wp-content/uploads/2020/11/C-Sharp.png"},
            new Course{CourseID=2,Name="java Script",Price=200,Desc="Advanced js",Imgurl="https://t4.ftcdn.net/jpg/02/66/76/83/360_F_266768305_jxxjP3ivAYLHxbOejYQ4095SvaGfTjc3.jpg"},
            new Course{CourseID=3,Name="python",Price=100,Desc="Advanced python",Imgurl="https://pluralsight.imgix.net/paths/python-7be70baaac.png"},
            new Course{CourseID=4,Name="Blazor",Price=200,Desc="Advanced blazor",Imgurl="https://upload.wikimedia.org/wikipedia/commons/d/d0/Blazor.png"}

            };
        }

      public  List<Course> GetCourses() => _Courses;
      public  Course GetCourseById(int id) => _Courses.SingleOrDefault(c => c.CourseID == id);
    }
}
