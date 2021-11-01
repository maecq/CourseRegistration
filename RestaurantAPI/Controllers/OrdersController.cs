using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Data;
using RestaurantAPI.Models;
using RestaurantAPI.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContexxt _context;

        public OrdersController(AppDbContexxt context)
        {
            _context = context;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult Get()
        {
            var orders = _context.Orders
                .Select(o => new OrderReadDTO {
                    Id = o.Id,
                    Name = o.Name,
                    Date = o.Date,
                    Products = _context.OrderProducts
                        .Where(op => op.OrderId == o.Id)
                        .Select(c => new ProductReadDTO {
                            Id = c.ProductId,
                            Name = c.Product.Name,
                            Price = c.Product.Price
                        }).ToList()
                })
                .ToList();

            return Ok(orders);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var orders = _context.Orders
                .Where(o => o.Id == id)
                .Select(o => new OrderReadDTO
                {
                    Id = o.Id,
                    Name = o.Name,
                    Date = o.Date,
                    Products = _context.OrderProducts
                        .Where(op => op.OrderId == o.Id)
                        .Select(c => new ProductReadDTO
                        {
                            Id = c.ProductId,
                            Name = c.Product.Name,
                            Price = c.Product.Price
                        }).ToList()
                })
                .FirstOrDefault();

            if (orders == null) { return NotFound($"Order with Order Number#{id} doesn't exist"); };

            return Ok(orders);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post(OrderWriteDTO value)
        {
            Order orderToAdd = new Order
            {
                Name = value.Name,
                Date = value.Date
            };
            _context.Orders.Add(orderToAdd);
            _context.SaveChanges();

            foreach (var id in value.ProductIds)
            {
                OrderProducts op = new OrderProducts
                {
                    OrderId = orderToAdd.Id,
                    ProductId = id
                };
                _context.OrderProducts.Add(op);
            }
            _context.SaveChanges();
            return NoContent();
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put()
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
