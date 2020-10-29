using partialview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace partialview.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            List<emp> lobj = new List<emp>();
            List<dept> ld = new List<dept>();
            emp obj = new emp();
            obj.empid = 1;
            obj.empname = "sai";
            obj.sal = 4000;

            emp obj1 = new emp();
            obj1.empid = 2;
            obj1.empname = "sam";
            obj1.sal = 3000;

            lobj.Add(obj);
            lobj.Add(obj1);
             
        
            dept dobj = new dept();
            dobj.deptid = 1;
            dobj.deptname = "sales";

            dept dobj1 = new dept();
            dobj1.deptid = 1;
            dobj1.deptname = "accounts";

            ld.Add(dobj);
            ld.Add(dobj1);

            empdept eobj = new empdept();
            eobj.employee = lobj;
            eobj.depart = ld;



            return View(eobj);
        }
    }
}