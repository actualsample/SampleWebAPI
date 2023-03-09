using IDPServer.DTO;

namespace IDPServer.Services
{
    public interface IUser
    {
        Task Registration(AddUserDto addUserDto);
        IEnumerable<UserReadDto> GetAll();
        Task<UserReadDto> Authenticate(AddUserDto addUserDto);
    }
}
