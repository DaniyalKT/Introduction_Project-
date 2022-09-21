using System.Collections.Generic;
using Introduction_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Introduction_Project.ViewComponents
{
    public class ProjectsViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Projects>
            {
                new Projects(1, "سایت فروشگاهی پوتین", "این وب سایت جهت ارائه ناب ترین کفش ها، کتونی ها . پوتین های زمستانی و تابستانی خدمت شما عزیزان ارائه شده است","portfolio-2.jpg"),
                new Projects(2, "سایت عکاسی کنان", "این وب سایت فروشگاهی جهت ارائه بهترین و با کیفیت ترین عکس های طبیعت و مراسمات شما عزیزان ارائه شده است","portfolio-7.jpg"),
                new Projects(3, "سایت فروشگاهی ساعت های هوشمند", "برای خرید ساعت های هوشمند با بهترین قیمت و بهترین کیفیت با برند های معروف و همچنین گارانتی بلند مدت برای شما عزیزان ارائه شده است","portfolio-9.jpg"),
            };
            return View("_Projects", projects);
        }
    }
}
