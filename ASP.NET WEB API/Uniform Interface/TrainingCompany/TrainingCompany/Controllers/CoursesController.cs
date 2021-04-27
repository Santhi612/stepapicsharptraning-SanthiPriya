using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TrainingCompany.Controllers
{
    public class CoursesController : ApiController
    {
        public IEnumerable<course> Get()
        {
            return courses; 
        }
        /*public course Get(int id)
        {
            var ret = (from c in courses
                       where c.id == id
                       select c).FirstOrDefault();
            return ret;
        }*/
        static List<course> courses = InitCourses();
        private static List<course> InitCourses()
        {
            var ret = new List<course>();
            ret.Add(new course { id = 0, title = "WebAPI" });
            ret.Add(new course { id = 1, title = "MobileAppliaction" });
            return ret;
        } 
    }
    public class course
    {
        public int id;
        public string title;
    }

}
