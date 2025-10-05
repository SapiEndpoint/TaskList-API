using AutoMapper;
using TaskList.Dto;
using TaskList.Models;

namespace TaskList.Mapper
{
    public class TaskPost : Profile
    {
        public TaskPost()
        {
            CreateMap<AddTaskDTO, TaskManagement>();
        }
    }
}