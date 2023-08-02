using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace WebApi.Utilities.AutoMapper
{
    public class MappingProfilecs : Profile
    {
        public MappingProfilecs()
        {
            CreateMap<BookDtoForUpdate, Book>().ReverseMap();
            CreateMap<Book, BookDto>();
            CreateMap<BookDtoForInsertion, Book>();
        }
    }
}
