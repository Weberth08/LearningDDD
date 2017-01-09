using AutoMapper;
using LearningDDD.Application.Interfaces;
using LearningDDD.Domain.Entities;
using LearningDDD.Presentation.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LearningDDD.Presentation.Controllers
{
    public class HabitActivityController : Controller
    {
        private readonly IHabitActivityAppService _habitAcivityAppService;

        public HabitActivityController(IHabitActivityAppService habitAcivityAppService)
        {
            _habitAcivityAppService = habitAcivityAppService;
        }
        // GET: HabitAcivity
        public ActionResult Index(int habitId)
        {
            var habitActivitiesViewModel = Mapper.Map<IEnumerable<HabitActivity>, IEnumerable<HabitActivityViewModel>>(_habitAcivityAppService.GetByHabitId(habitId));
            return View("Index", habitActivitiesViewModel);
        }

        // GET: HabitAcivity/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HabitAcivity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HabitAcivity/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HabitAcivity/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HabitAcivity/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HabitAcivity/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HabitAcivity/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
