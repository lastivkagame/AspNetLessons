using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersMVC.Filters
{
    public class CustomActionFilter : FilterAttribute, IActionFilter, IResultFilter
    {
        private Stopwatch watch = new Stopwatch();

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            watch.Stop();

            filterContext.HttpContext.Response.Write($"Action executed: " +
                $"{filterContext.ActionDescriptor.ActionName}," + $"Ticks: {watch.ElapsedMilliseconds} , ");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            watch.Start();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            watch.Stop();

            filterContext.HttpContext.Response.Write($"Resalt executed: {watch.ElapsedMilliseconds} ,\t ");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            watch.Start();
        }
    }
}