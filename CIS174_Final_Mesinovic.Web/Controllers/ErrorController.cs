using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Web.Mvc;

namespace CIS174_Final_Mesinovic.Web.Controllers
{
    public class ErrorController : Controller
    {
        [HandleError]
        // GET: Error
        /*    public ViewResult Index()
            {
                return View("Error");
            }*/
        public ViewResult NotFound()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }
        public ViewResult ErrorPage()
        {
            return View("ErrorGenerator");
        }
        public ViewResult ErrorAction_2()
        {
            //   return View("ErrorGenerator");

            try
            {
                throw new OutOfMemoryException("Error button clicked");
            }
            catch (OutOfMemoryException ome)
            {
                ErrorOrchestrator errorOrchestrator = new ErrorOrchestrator(ome);
                ErrorViewModel errorview = new ErrorViewModel();
                errorview.ErrorMessage = ome.Message;
                //  errorview.InnerExceptions = ome.InnerException.ToString();
                errorview.StackTrace = ome.StackTrace;
                return View("~Shared/Error");
            }
        }
        [HandleError]
        public ActionResult ErrorAction()
        {
            try
            {
                throw new OutOfMemoryException("Error button clicked");
            }
            catch (OutOfMemoryException ome)
            {
                ErrorOrchestrator errorOrchestrator = new ErrorOrchestrator(ome);
                ErrorViewModel errorview = new ErrorViewModel();
                //errorview.ErrorId = Guid.NewGuid();

                errorview.ErrorMessage = ome.Message;
                //    errorview.InnerExceptions = ome.InnerException;
                errorview.StackTrace = ome.StackTrace;

                /*
                 errorview.ErrorId = errorOrchestrator.ErrorId;
                errorview.ErrorMessage = el.ErrorMessage;
                errorview.ErrorDateTime = el.ErrorDateTime;
                errorview.InnerExceptions = el.InnerExceptions;
                errorview.StackTrace = el.StackTrace;
                */
                return View("Error", errorview);
            }
        }
    }
}