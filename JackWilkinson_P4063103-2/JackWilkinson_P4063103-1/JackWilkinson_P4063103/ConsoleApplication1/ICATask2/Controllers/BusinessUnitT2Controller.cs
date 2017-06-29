using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using HebbraCo_Lib;
using ICATask2.Models;

namespace ICATask2.Controllers
{
    public class BusinessUnitT2Controller : ApiController
    {
        private HebbraCo_Lib.HebbCo_Model db = new HebbCo_Model();

        public IQueryable<Models.BDTO> Get()
        {
            //this method will find all active business units and will then display them and all of their attributes in JSON format
            return db.BusinessUnits.Where(bUnit => bUnit.Active == true).Select((bu => new Models.BDTO
            {
                businessUnitId = bu.businessUnitId,
                businessUnitCode = bu.businessUnitCode,
                title = bu.title,
                officeAddress1 = bu.officeAddress1,
                officeAdresss2 = bu.officeAdresss2,
                officeAddress3 = bu.officeAddress3,
                officePostCode = bu.officePostCode,
                officeContact = bu.officeContact,
                officePhone = bu.officePhone,
                officeEmail = bu.officeEmail,
                description = bu.description

            }));
        }

        public Models.BDTO Get(int id)
        {
            //this method will return a specific business unit by the business unit ID and display it in JSON format
            var buit = db.BusinessUnits.Where(b => b.Active == true && b.businessUnitId == id).Select(bu => new Models.BDTO
                {
                    businessUnitId = bu.businessUnitId,
                    businessUnitCode = bu.businessUnitCode,
                    title = bu.title,
                    officeAddress1 = bu.officeAddress1,
                    officeAdresss2 = bu.officeAdresss2,
                    officeAddress3 = bu.officeAddress3,
                    officePostCode = bu.officePostCode,
                    officeContact = bu.officeContact,
                    officePhone = bu.officePhone,
                    officeEmail = bu.officeEmail,
                    description = bu.description
                }).FirstOrDefault();
            return buit;
        }


        public Models.BDTO Get(String buCode)
        {
            //this method will return a specific business unit by the business unit code and will return it in JSON format
            var buit = db.BusinessUnits.Where(b => b.Active == true && b.businessUnitCode.Trim() == buCode.Trim()).Select(bu => new Models.BDTO
            {
                businessUnitId = bu.businessUnitId,
                businessUnitCode = bu.businessUnitCode,
                title = bu.title,
                officeAddress1 = bu.officeAddress1,
                officeAdresss2 = bu.officeAdresss2,
                officeAddress3 = bu.officeAddress3,
                officePostCode = bu.officePostCode,
                officeContact = bu.officeContact,
                officePhone = bu.officePhone,
                officeEmail = bu.officeEmail,
                description = bu.description
            }).FirstOrDefault();
            return buit;
        }


    }
}
