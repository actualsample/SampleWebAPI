using IDPServer.DTO;
using IDPServer.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IDPServer.Services
{
    public class UserServices : IUser
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppSettings _appSettings;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserServices(UserManager<IdentityUser> userManager,
            IOptions<AppSettings> appSettings,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _appSettings = appSettings.Value;
            _roleManager = roleManager;
        }

        public async Task AddRole(string rolename)
        {
            IdentityResult roleResult;
            try
            {
                var roleName = new IdentityRole(rolename);
                var roleIsExist = await _roleManager.RoleExistsAsync(rolename);
                if (!roleIsExist)
                    roleResult = await _roleManager.CreateAsync(roleName);
                else
                    throw new Exception($"Role {rolename} sudah ada");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task AddUserToRole(string username, string role)
        {
            var user = await _userManager.FindByNameAsync(username);
            try
            {
                await _userManager.AddToRoleAsync(user, role);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<UserReadDto> Authenticate(AddUserDto addUserDto)
        {
            var currUser = await _userManager.FindByNameAsync(addUserDto.Username);
            var userResult = await _userManager.CheckPasswordAsync(currUser, addUserDto.Password);
            if (!userResult)
                throw new Exception($"Authentication failed");
            UserReadDto userWithToken = new UserReadDto
            {
                Username = addUserDto.Username,
            };
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, addUserDto.Username));
            var roles = await GetRolesFromUser(addUserDto.Username);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            userWithToken.Token = tokenHandler.WriteToken(token);
            return userWithToken;
        }

        
        
        public IEnumerable<UserReadDto> GetAll()
        {
            return new List<UserReadDto>()
            {
                new UserReadDto{Username="erick"},
                new UserReadDto{Username="budi"}
            };
        }

        public IEnumerable<CreateRoleDto> GetRoles()
        {
            List<CreateRoleDto> lstRole = new List<CreateRoleDto>();
            var results = _roleManager.Roles;
            foreach (var role in results)
            {
                lstRole.Add(new CreateRoleDto { RoleName = role.Name });
            }
            return lstRole;
        }

        public async Task<IEnumerable<string>> GetRolesFromUser(string username)
        {
            List<string> lstRole = new List<string>();
            var user = await _userManager.FindByNameAsync(username);
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                lstRole.Add(role);
            }
            return lstRole;
        }

        public async Task Registration(AddUserDto addUserDto)
        {
            try
            {
                var newUser = new IdentityUser
                {
                    UserName = addUserDto.Username,
                    Email = addUserDto.Username
                };
                var result = await _userManager.CreateAsync(newUser,
                    addUserDto.Password);
                if(!result.Succeeded)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach(var error in result.Errors)
                    {
                        sb.Append($"{error.Code} - {error.Description} \n");
                    }
                    throw new Exception(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
