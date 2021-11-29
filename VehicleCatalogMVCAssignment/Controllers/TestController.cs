using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace VehicleCatalogMVCAssignment.Controllers
{
    public class TestController : Controller
    {
        public ViewResult ShowTestText1()
        {

            //return new ContentResult
            //{
            //    ContentType = "text/html",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Content = "<html><body" +
            //    " Show text 1 test </body></html>"
            //};
            return View();
        }        
        
        public ViewResult ShowTestText2()
        {

            //return new ContentResult
            //{
            //    ContentType = "text/html",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Content = "<html><body" +
            //    " Show text 1 test </body></html>"
            //};
            return View();
        }
        public ViewResult ShowTestTextById(string id )
        {
            //if (id == "1")
            //{
            //    return new ContentResult
            //    {
            //        ContentType = "text/html",
            //        StatusCode = (int)HttpStatusCode.OK,
            //        Content = "<html><body" +
            //            " Show text by ID 1 test </body></html>"
            //    };
            //}
            //else if (id == "2")
            //{
            //    return new ContentResult
            //    {
            //        ContentType = "text/html",
            //        StatusCode = (int)HttpStatusCode.OK,
            //        Content = "<html><body" +
            //            " Show text  by ID 2 test </body></html>"
            //    };
            //}
            //else
            //{
            //    return new ContentResult
            //    {
            //        ContentType = "text/html",
            //        StatusCode = (int)HttpStatusCode.OK,
            //        Content = "<html><body" +
            //            " Show text  by ID default message in else  </body></html>"
            //    };
            //}
            if (id == "1")
                return View("ShowTextTestById1");
            else if (id == "2")
                return View();
            else
                return View();

        }
    }
}
