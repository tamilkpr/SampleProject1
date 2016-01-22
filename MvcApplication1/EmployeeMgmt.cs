using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MvcApplication1
{
    public class EmployeeDetails
    {
        public int EmpId;
        public string EmployeeName;
        public string Mobile;
        public DateTime JoinedDate{get;set;}
        public string Address;
        public string Position;
    }

    public class EmployeeMgmt
    {
        public static List<EmployeeDetails> GetAllEmployees()
        {
            List<EmployeeDetails> employees = new List<EmployeeDetails>();
            string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.xml");
            if (File.Exists(xmlFilePath))
            {
                XElement xElt = XElement.Load(xmlFilePath);
            }

            return employees;
        }
    }
}