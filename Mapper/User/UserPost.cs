using AutoMapper;
using TaskList.Models;
using TaskList.Dto;

namespace TaskList.Mapper
{
    public class UserPost : Profile
    {
        public UserPost()
        {
            CreateMap<AddUserDTO, Users>();
        }
    }
}