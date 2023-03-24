using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NguyenHungCuong2011060110.Models;

namespace NguyenHungCuong2011060110.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}