using IDPServer.DTO;
using IDPServer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDPServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _user;
        public UsersController(IUser user)
        {
            _user = user;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Registration(AddUserDto addUserDto)
        {
            try
            {
                await _user.Registration(addUserDto);
                return Ok($"Registrasi user {addUserDto.Username} berhasil");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddRole")]
        public async Task<ActionResult> AddRole(CreateRoleDto roleDto)
        {
            try
            {
                await _user.AddRole(roleDto.RoleName);
                return Ok($"Add Role {roleDto.RoleName} success");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddUserToRole")]
        public async Task<ActionResult> AddUserToRole(string username,string rolename)
        {
            try
            {
                await _user.AddUserToRole(username, rolename);
                return Ok($"Berhasil menambahkan user {username} ke role {rolename}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles ="admin")]
        [HttpGet]
        public IEnumerable<UserReadDto> GetAll()
        {
            return _user.GetAll();
        }


        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult> Authenticate(AddUserDto userDto)
        {
            try
            {
                var user = await _user.Authenticate(userDto);
                if (user == null)
                {
                    return BadRequest("Username / password not match");
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
