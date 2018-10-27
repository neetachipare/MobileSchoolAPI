﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MobileSchoolAPI.Models;
using MobileSchoolAPI.BusinessLayer;

namespace MobileSchoolAPI.Controllers
{

    public class HomeWorkConController : ApiController
    {


        [HttpPost]
        public object Homew([FromBody]homeworkparameters hobj)
        {

            Homeworkbussinesslayer bhobj = new Homeworkbussinesslayer();


            bhobj.Savehomework(hobj);
          //  bhobj.StudentsMethod(hobj);


            return "Homework assign successfully";


        }

        public object AttendanceSave([FromBody]AttendanceParameterscs atteobj)
        {

            Homeworkbussinesslayer bhobj = new Homeworkbussinesslayer();


            bhobj.SaveAttendance(atteobj);
            //  bhobj.StudentsMethod(hobj);


            return "Attendance Save Successfully";


        }
    }
}

//public object Sms([FromBody]Smsparameters hobj)
//{
//    Homeworkbussinesslayer bhobj = new Homeworkbussinesslayer();
    

//    return "sms send successfully";
//}

