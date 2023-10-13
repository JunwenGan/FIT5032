using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;

using MailBee;
using MailBee.DnsMX;
using MailBee.Mime;
using MailBee.SmtpMail;
using MailBee.Pop3Mail;
using MailBee.ImapMail;
using MailBee.Security;
using MailBee.AntiSpam;
using MailBee.AddressCheck;
using MailBee.Outlook;
using FIT5032_Week08A.Models;
namespace FIT5032_Week08B.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
        public ActionResult Send_Email(Email model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    String toEmail = model.ToEmail;
                    String subject = model.Subject;
                    String contents = model.Contents;
                    MailBee.Global.LicenseKey = "MN120-DB13137B139C13B2136FFDD2326A-DFF8";
                    MailBee.ImapMail.Imap imapComponent = new Imap("MN120-DB13137B139C13B2136FFDD2326A-DFF8");
                    Smtp.QuickSend("junonegan@gmail.com", toEmail, subject, contents);

                    ViewBag.Result = "Email has been send.";

                    ModelState.Clear();

                    return View();
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }
        public ActionResult Email()
        {
            return View();
        }

    }
}