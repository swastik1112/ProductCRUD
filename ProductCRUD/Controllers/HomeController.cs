using Microsoft.AspNetCore.Mvc;
using ProductCRUD.Models; // Import the namespace where Product class is defined

public class HomeController : Controller
{
    private readonly ProductRepository _productRepository;

    public HomeController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        // Retrieve data from the repository
        var products = _productRepository.GetAllProducts();

        // Pass the retrieved data to the view
        return View(products);
    }
    [HttpGet]
    public IActionResult AddProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            _productRepository.AddProduct(product);
            return RedirectToAction("Index");
        }
        return View(product);
    }

    // Other controller actions...
}
