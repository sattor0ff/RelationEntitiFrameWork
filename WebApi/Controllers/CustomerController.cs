using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController:ControllerBase
{
   
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
                _customerService = customerService;
        }

        [HttpGet("GetCustomers")]
        public List<CustomerDto> GetCustomers()
        {
                return _customerService.GetCustomers();
        }
        
        
        [HttpGet("GetCustomerByName")]
        public List<CustomerDto> GetCustomers([FromQuery] string name)
        {
                return _customerService.GetCustomerByName(name);
        }

        [HttpGet("GetCustomerById")]
        public Customer GetCustomerByID([FromQuery] int id)
        {
                return _customerService.GetCustomerById(id);
        }


        [HttpPost("AddCustomer")]
        public bool AddCustomer(CustomerDto customer)
        {
                _customerService.AddCustomer(customer);
                return true;
        }

        [HttpPut("UpdateCustomer")]
        public bool UpdateCustomer(CustomerDto customer)
        {
                _customerService.UpdateCustomer(customer);
                return true;
        }

        [HttpDelete("DeleteCustomer")]
        public void DeleteCustomer(int id)
        {
                _customerService.DeleteCustomer(id);
        }   
}