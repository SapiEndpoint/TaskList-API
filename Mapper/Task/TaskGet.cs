using AutoMapper;
using TaskList.Dto;
using TaskList.Models;

namespace TaskList.Mapper
{
    public class TaskGet : Profile
    {
        public TaskGet()
        {
            CreateMap<TaskManagement, TaskNoId>();
        }
    }
}