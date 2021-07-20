using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VnExpress.Application.Users;
using VnExpress.ViewModel.Users;

namespace VnExpress.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int idUser)
        {
            var user = await _userService.GetById(idUser);
            if (user == null)
                return BadRequest("Cannot find user");
            return Ok(user);
        }
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Create(UserCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var idUser = await _userService.Create(request);
            if (idUser == 0)
                return BadRequest();

            var user = await _userService.GetById(idUser);

            return CreatedAtAction(nameof(GetById), new { id = idUser }, user);
        }
        [HttpPut("{idUser}")]
        [Consumes("application/json")]
        public async Task<IActionResult> Update(int idUser, UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.IdUser = idUser;
            var affectedResult = await _userService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{idUser}")]
        public async Task<IActionResult> Delete(int idUser)
        {
            var affectedResult = await _userService.Delete(idUser);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        //[HttpPost("authenticate")]
        //[AllowAnonymous]
        //public async Task<IActionResult> Authenticate( LoginRequest request)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var result = await _userService.Authencate(request);

        //    if (string.IsNullOrEmpty(result.ResultObj))
        //    {
        //        return BadRequest(result);
        //    }
        //    return Ok(result);
        //}

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Register( RegisterRequest request)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var result = await _userService.Register(request);
        //    if (!result.IsSuccessed)
        //    {
        //        return BadRequest(result);
        //    }
        //    return Ok(result);
        //}
    }

}
