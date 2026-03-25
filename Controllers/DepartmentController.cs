using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TarsusObs.Models;

namespace TarsusObs.Controllers;

public class DepartmentController : Controller
{

    public IActionResult Index()
    {

        return View(FakeDatabase.GetDepartments());
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Department dep)
    {
        FakeDatabase.AddDepartment(dep);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var dep = FakeDatabase.GetDepartments().Find(x=>x.Id==id);
    if (dep != null)
    {
        FakeDatabase.GetDepartments().Remove(dep);
       
    }
    return RedirectToAction("Index"); // Silme sonrası listeye dön
    }
[HttpGet]
    public IActionResult Update(int id)
    {
         var dep = FakeDatabase.GetDepartments().Find(x=>x.Id==id);
        return View(dep);
    }
    [HttpPost]
    public IActionResult Update(Department dep)
    {
        var newdep = FakeDatabase.GetDepartments().Find(x=>x.Id==dep.Id);
        newdep.DepCode=dep.DepCode;
        newdep.DepName=dep.DepName;
        
        return RedirectToAction("Index");
    }


}
