using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcProject_Raihan.CustomValidation
{
    public class CustomHireDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now;
        }
    }
}