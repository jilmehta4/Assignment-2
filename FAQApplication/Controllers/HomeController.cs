using FAQApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FAQApplication.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context;

        public HomeController(FAQContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeCat = "all", string activeTop = "all")
        {
            // store selected conference and division IDs in view bag
            ViewBag.ActiveCat = activeCat;
            ViewBag.ActiveTop = activeTop;

            // get list of conferences and divisions from database
            List<Category> categories = context.Categories.ToList();
            List<Topic> topics = context.Topics.ToList();

            // insert default "All" value at front of each list
            categories.Insert(0, new Category { CategoryID = "all", CategoryName = "All" });
            topics.Insert(0, new Topic { TopicID = "all", TopicName = "All" });

            // store lists in view bag
            ViewBag.Categories = categories;
            ViewBag.Topics = topics;

            // get teams - filter by conference and division
            IQueryable<FAQ> query = context.FAQs;
            if (activeCat != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCat.ToLower());
            if (activeTop != "all")
                query = query.Where(
                    t => t.Topic.TopicID.ToLower() == activeTop.ToLower());

            // pass teams to view as model
            var faqs = query.ToList();
            return View(faqs);
        }
    }
}