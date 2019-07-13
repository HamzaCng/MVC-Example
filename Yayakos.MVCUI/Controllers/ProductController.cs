using CommonType.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yayakos.BLL.Abstracts;
using Yayakos.Entities;

namespace Yayakos.MVCUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _ps;
        public ProductController(IProductService ps)
        {
            _ps = ps;
        }
        // GET: Product
        public ActionResult GetProducts()
        {
            return View(_ps.GetProducts().Data);
        }

        public ActionResult AddProduct() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(Product product)
        {
            var result = _ps.Add(product);
            ViewBag.Sonuc = result.Message;
            ViewBag.SonucState = result.State;
            return View(product);
        }
    }
}