using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Books.Data;
using Books.Web.ViewModels;

namespace Books.Web
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Domain to Dto
            CreateMap<BookViewModel, Book>();
            
            // Dto to Domain
            CreateMap<Book, BookViewModel>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
