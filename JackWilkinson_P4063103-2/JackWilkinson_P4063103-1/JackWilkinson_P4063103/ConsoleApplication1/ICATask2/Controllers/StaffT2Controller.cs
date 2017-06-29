using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HebbraCo_Lib;

namespace ICATask2.Controllers
{
    [RoutePrefix(("api/Staff"))]
    public class StaffT2Controller : ApiController
    {
        //instantiate a new model
        private HebbraCo_Lib.HebbCo_Model d = new HebbCo_Model();
        //the route to find the staff by business unit
        [Route("StaffBBU/{buCode}")]
        public IEnumerable<Models.SDTO> GetbyBU(String buCode)
        {
            //this method will return the staff by business unit in JSON format
            return d.Staffs.Where(s => s.Active && s.BusinessUnit.businessUnitCode.Trim() == buCode.Trim()).Select(st => new Models.SDTO()
            {
                staffId = st.staffId,
                businessUnitId = st.businessUnitId,
                staffCode = st.staffCode,
                firstName = st.firstName,
                middleName = st.middleName,
                lastName = st.lastName,
                dob = st.dob,
                emailAddress = st.emailAddress,
                profile = st.profile
            });
        }
        //the route to find a specific staff 
        [Route("StaffInfo/{staffCode}")]
        public Models.SDTO GetStaffID(String staffCode)
        {
            //this method will return a specific staff member and display it in JSON format
            var sI = d.Staffs.Where(s => s.Active && s.staffCode.Trim() == staffCode.Trim()).Select(st => new Models.SDTO()
            {
                staffId = st.staffId,
                businessUnitId = st.businessUnitId,
                staffCode = st.staffCode,
                firstName = st.firstName,
                middleName = st.middleName,
                lastName = st.lastName,
                dob = st.dob,
                emailAddress = st.emailAddress,
                profile = st.profile
            }).FirstOrDefault();
            return sI;
        }
    }
}
