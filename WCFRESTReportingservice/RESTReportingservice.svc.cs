using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRESTReportingservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RESTReportingservice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RESTReportingservice.svc or RESTReportingservice.svc.cs at the Solution Explorer and start debugging.
    public class RESTReportingservice : IWCFRESTEmployeeservice
    {
        //public void DoWork()
        //{
        //}
        public WCFEmployee GetWCFRESTEmployee(int Id)
        {
            //int IDint = int.Parse(Id);
            WCFEmployee_CFEXDB wcfctxt = new WCFEmployee_CFEXDB();

            //WCFEmployee singleemp = from s in wcfctxt.WCFEmployees.AsQueryable()                                    .Where(s => s.Id == Id)
            //                        select new WCFEmployee
            //                        {
            //                            Id = s.Id,
            //                            Name = s.Name,
            //                            Gender = s.Gender,
            //                            DateOfBirth = s.DateOfBirth,
            //                            EmployeeType = s.EmployeeType,
            //                            AnnualSalary = s.AnnualSalary,
            //                            HourlyPay = s.HourlyPay,
            //                            HoursWorked = s.HoursWorked
            //                        }; 
            //WCFEmployee singleemp = wcfctxt.WCFEmployees.Find(IDint);

            WCFEmployee singleemp = wcfctxt.WCFEmployees.Find(Id);
            return singleemp;

            //throw new NotImplementedException();
        }

        //public void SaveWCFERESTmployee(WCFEmployee Employee)
        //{
        //    WCFEmployee_CFEXDB wcfctxt = new WCFEmployee_CFEXDB();

        //    wcfctxt.WCFEmployees.Add(Employee);
        //    wcfctxt.SaveChanges();

        //    //throw new NotImplementedException();
        //}

        //public string UpdateWCFRESTEmployee(WCFEmployee Employee)
        //{
        //    WCFEmployee_CFEXDB wcfctxt = new WCFEmployee_CFEXDB();
        //    WCFEmployee toupdt = wcfctxt.WCFEmployees.Find(Employee.Id);
        //    toupdt.Name = Employee.Name;
        //    toupdt.Gender = Employee.Gender;
        //    toupdt.DateOfBirth = Employee.DateOfBirth;
        //    toupdt.EmployeeType = Employee.EmployeeType;
        //    toupdt.AnnualSalary = Employee.AnnualSalary;
        //    toupdt.HourlyPay = Employee.HourlyPay;
        //    toupdt.HoursWorked = Employee.HoursWorked;
        //    wcfctxt.SaveChanges();

        //    return toupdt.Name + " details Updated successfully";
        //    //throw new NotImplementedException();
        //}

        public List<WCFEmployee> ALLWCFRESTEmployee()
        {
            WCFEmployee_CFEXDB wcfctxt = new WCFEmployee_CFEXDB();
            List<WCFEmployee> empset = wcfctxt.WCFEmployees.ToList();
            //IEnumerable<WCFEmployee> empset=from es in wcfctxt.WCFEmployees.AsEnumerable()
            //                                orderby es.Id
            //                                select new WCFEmployee
            //                                {
            //                                    Id = es.Id,
            //                                    Name = es.Name,
            //                                    Gender = es.Gender,
            //                                    DateOfBirth = es.DateOfBirth,
            //                                    EmployeeType = es.EmployeeType,
            //                                    AnnualSalary = es.AnnualSalary,
            //                                    HourlyPay = es.HourlyPay,
            //                                    HoursWorked = es.HoursWorked
            //                                };
            return empset;
            //throw new NotImplementedException();
        }

    }
}
