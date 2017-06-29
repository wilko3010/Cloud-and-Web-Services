using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICATask4.Models;
using HebbraCo_Lib;
using ICATask4.SkillService;

namespace ICATask4.Controllers
{
    public class SkillsController : Controller
    {
        //this will instantiate the model for the skills database
        private SkillService.SkillServiceClient WCFClient = new SkillService.SkillServiceClient();
        //this will instantiate the model for the WCF Client
        private HebbraCo_Lib.task4Model skilldb = new task4Model();


        public ActionResult WcfResult()
        {
            //this method will retreive all of the skills from the WCF client
            //and will return the skills in a formatted list
            var skills = WCFClient.GetAllSkills();
            return View(skills);

        }

        public ActionResult Skills(string staffCode)
        {
            //this method will allow display all skills of a certain staff member using the staff code
            var thisStaffSkills = skilldb.skillStaffs.Where(s => s.staffName == staffCode);
            var vm = thisStaffSkills.Select(
                c => new skillDTO
                {
                    skillCode = c.skillCode,
                    staffName = c.staffName
                });
            return View(vm);
        }

    }
}
