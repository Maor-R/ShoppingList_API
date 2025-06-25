
using EFCoreExample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoppingListAPI.Migrations;
using System.Collections.Generic;

namespace ShoppingListAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingListController : ControllerBase
    {
        private readonly AppDbContext _context;
        //static int num = 0;


        public ShoppingListController(AppDbContext context)
        {
             _context = context;
            //num = _context.ProductInShoppingList.Max(x => x.ShoppingListId as int ?)??0;
 
        }

        [HttpGet]
        public    IEnumerable<Category> GetShoppingList()
        {
            return _context.Categories.ToList();   
        }

        [HttpGet("{CategoryId}")]
        public IEnumerable<Product> GetProductsFromCategory(int CategoryId)
        {
            return  _context.Products.Where(s => s.CategoryId == CategoryId).ToList();
        }

        //[HttpPut("AddProduct")]  // Matches PUT 'ShoppingList/AddProduct'
        //[HttpPost("EditAmountProduct")]  // Matches POST 'ShoppingList/EditAmountProduct'
        //public void AddOrEditProduct(int ShoppingListId, int ProductId, int Amount)
        //{
        //    var sl = _context.ProductInShoppingList.FirstOrDefault(s => s.ProductID == ProductId);

        //    if (sl != null)
        //    {
        //        sl.Amount = Amount;
        //    }
        //    else
        //    {
        //        int ms =  DateTime.Now.Millisecond;
        //         var psl = new ProductInShoppingList { ShoppingListId = GetUniqueNumberAsPerDate(num), ProductID = ProductId, Amount = Amount };
        //        _context.ProductInShoppingList.Add(psl);
        //    }

        //        _context.SaveChanges();
        // }


        //public static int GetUniqueNumberAsPerDate(int ms)
        //{

        //    num += 1;
        //    return num;
        // }

    }
}
