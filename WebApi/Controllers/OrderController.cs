using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController:ControllerBase
{
   
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
                _orderService = orderService;
        }

        [HttpGet("GetAllDatas")]
        public List<AllDto> GetOrders()
        {
            return _orderService.GetOrders();
        }
        
        
        [HttpGet("GetOrdersByDate")]
        public List<AllDto> GetOrdersByDate(DateTime date)
        {
            return _orderService.GetOrdersByDate(date);
        }

        [HttpGet("GetOrderById")]
        public List<AllDto> GetProductByID([FromQuery] int id)
        {
                return _orderService.GetOrderById(id);
        }

        [HttpPost("AddOrder")]
        public bool AddOrder(OrderDto order)
        {
                _orderService.AddOrder(order);
                return true;
        }  
        
        [HttpPut("UpdateOrder")]
        public bool UpdateOrder(OrderDto order)
        {
                _orderService.UpdateOrder(order);
                return true;
        }

        [HttpDelete("DeleteOrder")]
        public void DeleteOrder(int id)
        {
                _orderService.DeleteOrder(id);
        }    
}