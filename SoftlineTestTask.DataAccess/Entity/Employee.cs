using System;
using System.Collections.Generic;
using System.Text;

namespace SoftlineTestTask.DataAccess.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }       
        public string Position { get; set; }        
        public DateTime DateOfBirth { get; set; }      
        public string Text { get; set; }
        public bool Decree { get; set; }
    }
}
