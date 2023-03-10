using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using silvaadriano2.Models;
using Newtonsoft.Json;


namespace silvaadriano2.Controllers
{
    public class AQASuppliersController : Controller
    {
        private readonly HttpClient _aqaclient;
        private const string AQAAPI_URL = "https://localhost:7104/api/AQASuppliers/";

        public AQASuppliersController(HttpClient aqaclient)
        {
            _aqaclient = aqaclient;
        }

        // GET: AQASuppliers
        public async Task<IActionResult> Index()
        {
            var aqaresponse = await _aqaclient.GetAsync(AQAAPI_URL);
            if (aqaresponse.IsSuccessStatusCode)
            {
                var aqajson = await aqaresponse.Content.ReadAsStringAsync();
                var aqasuppliers = JsonConvert.DeserializeObject<List<AQASupplier>>(aqajson);
                return View(aqasuppliers);
            }
            return View("Error");
        }

        // GET: AQASuppliers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var aqaresponse = await _aqaclient.GetAsync(AQAAPI_URL + id);
            if (aqaresponse.IsSuccessStatusCode)
            {
                var aqajson = await aqaresponse.Content.ReadAsStringAsync();
                var aqasupplier = JsonConvert.DeserializeObject<AQASupplier>(aqajson);
                return View(aqasupplier);
            }
            return View("Error");
        }

        // GET: AQASuppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AQASuppliers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AQASupplier aqasupplier)
        {
            var aqacontent = new StringContent(JsonConvert.SerializeObject(aqasupplier), Encoding.UTF8, "application/json");
            var aqaresponse = await _aqaclient.PostAsync(AQAAPI_URL, aqacontent);
            if (aqaresponse.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Error");
        }

        // GET: AQASuppliers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var aqaresponse = await _aqaclient.GetAsync(AQAAPI_URL + id);
            if (aqaresponse.IsSuccessStatusCode)
            {
                var aqajson = await aqaresponse.Content.ReadAsStringAsync();
                var aqasupplier = JsonConvert.DeserializeObject<AQASupplier>(aqajson);
                return View(aqasupplier);
            }
            return View("Error");
        }

        // POST: AQASuppliers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AQASupplier aqasupplier)
        {
            var aqacontent = new StringContent(JsonConvert.SerializeObject(aqasupplier), Encoding.UTF8, "application/json");
            var aqaresponse = await _aqaclient.PutAsync(AQAAPI_URL + id, aqacontent);
            if (aqaresponse.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Error");
        }

        // GET: AQASuppliers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var aqaresponse = await _aqaclient.GetAsync(AQAAPI_URL + id);
            if (aqaresponse.IsSuccessStatusCode)
            {
                var aqajson = await aqaresponse.Content.ReadAsStringAsync();
                var aqasupplier = JsonConvert.DeserializeObject<AQASupplier>(aqajson);
                return View(aqasupplier);
            }
            return View("Error");
        }

        // POST: AQASuppliers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, AQASupplier aqasupplier)
        {
            var aqaresponse = await _aqaclient.DeleteAsync(AQAAPI_URL + id);
            if (aqaresponse.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Error");
        }
    }
}
