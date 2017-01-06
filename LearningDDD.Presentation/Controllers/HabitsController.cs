using AutoMapper;
using LearningDDD.Domain.Entities;
using LearningDDD.Infrastructure.Data.Repository;
using LearningDDD.Presentation.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LearningDDD.Presentation.Controllers
{
    public class HabitsController : Controller
    {
        private readonly HabitRepository _habitRepository = new HabitRepository();

        // GET: Habits
        public ActionResult Index()
        {
            var habitViewModel = Mapper.Map<IEnumerable<Habit>, IEnumerable<HabitViewModel>>(_habitRepository.GetAll());
            return View(habitViewModel);
        }

        // GET: Habits/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Habits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Habits/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HabitViewModel habit)
        {
            if (ModelState.IsValid)
            {
                var habitDomain = Mapper.Map<HabitViewModel, Habit>(habit);
                _habitRepository.Add(habitDomain);

                return RedirectToAction("Index");
            }

            return View(habit);
        }

        // GET: Habits/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Habits/Edit/5
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

        // GET: Habits/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Habits/Delete/5
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
