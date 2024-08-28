using MVCTestProject.Services;
using MVCTestProject.Models;
using Microsoft.AspNetCore.Mvc;
using MVCTestProject.Models.View;

namespace MVCTestProject.Controllers
{
    public class TestController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        public TestController(IProductService productService, ICustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService;
        }
        public IActionResult Index()
        {
  

            CustProViewModel vm = new CustProViewModel();
            vm.CustomerList = _customerService.GetCustomers();
            vm.ProductList = _productService.GetProducts();
            return View(vm);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult ProductDetails(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.AddCustomer(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public IActionResult CustomerDetails(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            return View(customer);
        }
    }
}
