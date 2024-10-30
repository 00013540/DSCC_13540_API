using AutoMapper;
using DSCC_13540_API.DTOs;
using DSCC_13540_API.Models;

namespace DSCC_13540_API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Author mappings
            CreateMap<Author, AuthorDto>();
            CreateMap<AuthorCreateDto, Author>();

            // Book mappings
            CreateMap<Book, BookDto>();
            CreateMap<BookCreateDto, Book>();
        }
    }
}
