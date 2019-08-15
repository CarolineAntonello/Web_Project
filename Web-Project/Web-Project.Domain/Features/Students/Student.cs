using System;
using Web_Project.Domain.Base;
using Web_Project.Domain.Features.Teachers;

namespace Web_Project.Domain.Features.Students
{
    public class Student : Entity
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Teacher Teacher { get; set; }
    }
}
