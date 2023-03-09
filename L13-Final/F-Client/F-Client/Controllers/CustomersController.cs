using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using F_Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace F_Client.Controllers
{
    public class CustomersController : Controller
    {
        private readonly HttpClient _client;
        private const string API_URL = "https://localhost:7117/api/Customers/";

        public CustomersController(HttpClient client)
        {
            _client = client;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync(API_URL);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<List<Customer>>(json);
                return View(customers);
            }
            return View("Error");
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var response = await _client.GetAsync(API_URL + id);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<Customer>(json);
                return View(customer);
            }
            return View("Error");
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
            var content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(API_URL, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Error");
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var response = await _client.GetAsync(API_URL + id);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<Customer>(json);
                return View(customer);
            }
            return View("Error");
        }

        // POST: Customers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Customer customer)
        {
            var content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync(API_URL + id, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Error");
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _client.GetAsync(API_URL + id);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<Customer>(json);
                return View(customer);
            }
            return View("Error");
        }

        // POST: Customers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id, Customer customer)
        {
            var response = await _client.DeleteAsync(API_URL + id);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Error");
        }
    }
}
