using System;

namespace SimpleRESTApi.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public string InstructorEmail { get; set; }
        public string InstructorPhone { get; set; }
        public string InstructorAddress { get; set; }
        public string InstructorCity { get; set; }
    }
}