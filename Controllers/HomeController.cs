using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstProject.Controllers
{
    // контроллер главной страницы
    public class Home : Controller
    {
        // основное действие (действие по умолчанию)
        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            // 1. вызов View без параметров вернет обработанное представление Views/Home/Index.cshtml,
            // где Home - имя каталога, определенное по имени класса контроллера,
            // Index - имя файла представления, определенное по имени действия (метода)
            // 2. вызов View с одним параметром 'MyView' вернет обработанное представление Views/Home/MyView.cshtml,
            // 3. + представлению будет передана модель с данными: строка,
            // при этом, чтобы воспользоваться моделью, представление должно быть типизировано
            return View("MyView", viewModel);
        }
    }
}
