using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc2019.Models;

namespace SalesWebMvc2019.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            //Criando uma lista de departamentos para entender a estrutura
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "teste" });
            list.Add(new Department { Id = 2, Name = "teste2" });

            //retornando a lista de departamentos para a View
            return View(list);
        }
    }
}
