using AutoMapper;
using Clor.Services.Catalog.Dtos;
using Clor.Services.Catalog.Models;

namespace Clor.Services.Catalog.Mapping;

public class GeneralMapping:Profile
{
    public GeneralMapping()
    {
        CreateMap<Course, CourseDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Feature, FeatureDto>().ReverseMap();
        
        CreateMap<Course, CourseCreateDto>().ReverseMap();
        CreateMap<Course, CourseUpdateDto>().ReverseMap();
    }
}