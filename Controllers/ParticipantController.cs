using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADB_Fishing_Tournament.Controllers
{
    public class ParticipantController : Controller
    {
       // GET: /<controller>/
       public string CheckRegistration()
        {
            return "REGISTRATION SUCCESS";
        }
    }
}
