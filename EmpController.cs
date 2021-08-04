using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class EmpController : ApiController
    {
        static List<Empl> emps = new List<Empl>();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<Empl> GetEmployees()
        {
            emps.Add(new Empl {Empid=1,Ename="Ajit",Sal=10000 });
            emps.Add(new Empl { Empid = 2, Ename = "Sujit", Sal = 20000 });

            return emps;
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Empl GetEmployeeById(int id)
        {
            Empl empfound=emps.Find(e => e.Empid == id);
            return empfound;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void PostEmployee([FromBody]Empl emp)
        {
            emps.Add(emp);
            
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void PutEmployee(int id,[FromBody] Empl emp)
        {
            Empl found=emps.Find(e => e.Empid == id);
            emps.Remove(found);
            emps.Insert(id, emp);
        }

        public void Delete(int id)
        {
            Empl f=emps.Find(e => e.Empid == id);
            emps.Remove(f);
        }

    }
}
