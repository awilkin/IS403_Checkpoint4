using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string Index()
        {
            return "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
        }

        // GET: Email
        public string Email(string Name, string email)
        {
            string sReturn = "";
            
            if (String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(email)) {
                sReturn = "Please call Tech Support at <strong><u>801-555-1212</u></strong>. Thank you!";
            }
            else if(String.IsNullOrEmpty(Name)){
                sReturn = "Thank you. We will send an email to " + email;
            }
            else{
                sReturn = "Thank you " + Name + ". We will send an email to " + email;
            }
            return sReturn;
        }
    
    }
}