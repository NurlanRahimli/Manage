using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contexts
{
    static class DbContext
    {
        public static List<Student> Students { get; set; }

        public static List<Group> Groups { get; set; }
    }
}
