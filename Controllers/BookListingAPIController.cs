using AutoMapper;
using BookListingMicroService.Data;
using BookListingMicroService.Models;
using BookListingMicroService.Models.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookListingMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookListingAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public BookListingAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        // GET: api/<BookListingAPIController>
        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Book> objList = _db.Books.ToList();
                _response.Result = _mapper.Map<IEnumerable<BookDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // GET api/<BookListingAPIController>/5
        [HttpGet("{id}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Book obj = _db.Books.First(u => u.bookId==id);
                _response.Result = _mapper.Map<BookDto>(obj);                
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet("GetByTitle/{title}")]
        public ResponseDto GetByTitle(string title)
        {
            try
            {
                IEnumerable<Book> objList = _db.Books.Where(u => u.title.ToLower().Contains(title.ToLower())).ToList();                
                _response.Result = _mapper.Map<IEnumerable<BookDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet("GetByGenre/{genre}")]
        public ResponseDto GetByGenre(string genre)
        {
            try
            {
                IEnumerable<Book> objList = _db.Books.Where(u => u.genre.ToLower().Contains(genre.ToLower())).ToList();
                _response.Result = _mapper.Map<IEnumerable<BookDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet("GetByAuthor/{author}")]
        public ResponseDto GetByAuthor(string author)
        {
            try
            {
                IEnumerable<Book> objList = _db.Books.Where(u => u.author.ToLower().Contains(author.ToLower())).ToList();
                _response.Result = _mapper.Map<IEnumerable<BookDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet("GetByAvailability/{availability}")]
        public ResponseDto GetByAvailability(string availability)
        {
            try
            {
                IEnumerable<Book> objList = _db.Books.Where(u => u.availability.ToLower().Contains(availability.ToLower())).ToList();
                _response.Result = _mapper.Map<IEnumerable<BookDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // POST api/<BookListingAPIController>
        [HttpPost]
        public ResponseDto Post([FromBody] BookDto bookDto)
        {
            try
            {
                Book obj = _mapper.Map<Book>(bookDto);
                _db.Books.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<BookDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // PUT api/<BookListingAPIController>/5
        [HttpPut]
        public ResponseDto Put([FromBody] BookDto bookDto)
        {
            try
            {
                Book obj = _mapper.Map<Book>(bookDto);
                _db.Books.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<BookDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // DELETE api/<BookListingAPIController>/5
        [HttpDelete("{id}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                Book obj = _db.Books.First(u => u.bookId == id);
                _db.Books.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
