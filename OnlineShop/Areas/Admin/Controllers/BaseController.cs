﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
       protected void SetAlert(string message, string type)
        {
            // cũng giống ViewBag nhưng temdata có thể lấy được thông tin trên server
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }

            if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }

            if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
    }
}