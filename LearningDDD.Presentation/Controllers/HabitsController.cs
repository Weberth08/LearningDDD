using AutoMapper;
using LearningDDD.Application.Interfaces;
using LearningDDD.Domain.Entities;
using LearningDDD.Presentation.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LearningDDD.Presentation.Controllers
{
    public class HabitsController : Controller
    {
        private readonly IHabitAppService _habitAppService;

        public HabitsController(IHabitAppService habitAppService)
        {
            _habitAppService = habitAppService;
        }

        // GET: Habits
        public ActionResult Index()
        {
            var habitViewModel = Mapper.Map<IEnumerable<Habit>, IEnumerable<HabitViewModel>>(_habitAppService.GetAll());
            return View(habitViewModel);
        }

        // GET: Habits/Details/5
        public ActionResult Details(int id)
        {
            var habitViewModel = Mapper.Map<Habit, HabitViewModel>(_habitAppService.GetById(id));
            return View("Details", habitViewModel);

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
                _habitAppService.Add(habitDomain);

                return RedirectToAction("Index");
            }

            return View(habit);
        }

        // GET: Habits/Edit/5
        public ActionResult Edit(int id)
        {
            var habitViewModel = Mapper.Map<Habit, HabitViewModel>(_habitAppService.GetById(id));
            return View("Edit", habitViewModel);
        }

        // POST: Habits/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var habitToBeEdited = _habitAppService.GetById(id);
                _habitAppService.Update(habitToBeEdited);
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
            var habitViewModel = Mapper.Map<Habit, HabitViewModel>(_habitAppService.GetById(id));
            return View("Delete", habitViewModel);
        }

        // POST: Habits/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                var habitToBeDeleted = _habitAppService.GetById(id);
                _habitAppService.Remove(habitToBeDeleted);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
