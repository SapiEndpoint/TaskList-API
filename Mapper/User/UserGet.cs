using AutoMapper;
using TaskList.Models;
using TaskList.Dto;

namespace TaskList.Mapper
{
    public class UserGet : Profile
    {
        public UserGet()
        {
            CreateMap<Users, User>();
        }
    }
}