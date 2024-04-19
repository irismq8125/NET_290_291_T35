using Microsoft.AspNetCore.Mvc;
using NET_290_291_T35.Models.ToDoTask;

namespace NET_290_291_T35.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<ToDoTask> toDoTasks = new List<ToDoTask>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var items = toDoTasks.ToList();
            return View(items);
        }

        [HttpPost]
        public async Task<IActionResult> LoadData(string trangthai)
        {
            var items = trangthai == "0" ? toDoTasks.ToList() : toDoTasks.Where(x => x.Status == trangthai).ToList();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> AddToDoTask(string ten, string batdau, string ketthuc, string trangthai, string mota)
        {
            ToDoTask task = new ToDoTask
            {
                Id = Guid.NewGuid(),
                TaskName = ten,
                StartDay = batdau,
                EndDay = ketthuc,
                Status = trangthai,
                Discription = mota
            };

            toDoTasks.Add(task);
            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateToDoTask(string id, string ten, string batdau, string ketthuc, string trangthai, string mota)
        {
            var item = toDoTasks.FindIndex(x => x.Id.ToString() == id);
            toDoTasks[item].TaskName = ten;
            toDoTasks[item].StartDay = batdau;
            toDoTasks[item].EndDay = ketthuc;
            toDoTasks[item].Status = trangthai;
            toDoTasks[item].Discription = mota;

            return Ok(toDoTasks[item]);
        }

        public async Task<IActionResult> DetailToDoTask(string id)
        {
            var item = toDoTasks.FirstOrDefault(x => x.Id.ToString() == id);
            return Ok(item);
        }

        //khai báo hàm xóa dữ liệu với đầu vào id
        [HttpPost]
        public async Task<IActionResult> DeleteToDoTask(string id)
        {
            var item = toDoTasks.FirstOrDefault(x => x.Id.ToString() == id);
            toDoTasks.Remove(item);
            return Ok(item);
        }
    }
}
