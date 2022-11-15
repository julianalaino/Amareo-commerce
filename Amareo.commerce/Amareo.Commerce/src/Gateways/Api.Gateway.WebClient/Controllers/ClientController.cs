using Api.Gateway.Models;
using Api.Gateway.Models.Customer.DTOs;
using Api.Gateway.Proxies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Gateway.WebClient.Controllers
{
    [Route("clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ICustomerProxy _customerProxy;


        public ClientController(ICustomerProxy customerProxy)
        {
            _customerProxy = customerProxy;
        }

        [HttpGet]
        public async Task<DataCollection<ClientDto>> GetAll(int page, int take)
        {
            return await _customerProxy.GetAllAsync(page, take);
        }

        [HttpGet("{id}")]
        public async Task<ClientDto> Get(int id)
        {
            return await _customerProxy.GetAsync(id);
        }
    }
}
