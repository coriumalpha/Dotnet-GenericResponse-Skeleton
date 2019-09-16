using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helpers.GenericResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJew.Service;
using URF.Core.Abstractions;

namespace SJew.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(
            IUserService userService,
            IUnitOfWork unitOfWork
        )
        {
            _userService = userService;
            _unitOfWork = unitOfWork;
        }

        // GET: api/User
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var users = await _userService.FindAsync(id);
                return Ok(new SuccessResponse(users));
            }
            catch (Exception exception)
            {
                return Ok(new ErrorResponse(ResponseCode.RecordNotFound, exception));
            }

        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
