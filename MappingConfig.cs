using AutoMapper;
using BookListingMicroService.Models;
using BookListingMicroService.Models.Dto;

namespace BookListingMicroService
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<BookDto, Book>();
                config.CreateMap<Book, BookDto>();
            });
            return mappingConfig;
        }
    }
}