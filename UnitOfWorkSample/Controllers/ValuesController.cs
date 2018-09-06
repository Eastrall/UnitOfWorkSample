using Microsoft.AspNetCore.Mvc;
using UnitOfWorkSample.Data;

namespace UnitOfWorkSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<object> Get()
        {
            var author = this._unitOfWork.AuthorRepository.Add(new AuthorEntity
            {
                FirstName = "Filipe",
                LastName = "GP",
            });
            var book = this._unitOfWork.BookRepository.Add(new BookEntity
            {
                Author = author,
                Title = "The tales of Hello world"
            });
            this._unitOfWork.Complete();
            
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
