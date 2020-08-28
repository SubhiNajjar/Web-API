using EXAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EXAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my People.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Subhi", LastName = "Najjar", Id = 1 , Age = 23});
            people.Add(new Person { FirstName = "Nour", LastName = "Halak", Id = 2 ,Age = 32});
            people.Add(new Person { FirstName = "Sara", LastName = "Lönnberg", Id = 3 ,Age = 19});
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <param name="userId">The unique identifier for this person</param>
        /// <param name="age">We want to konw how old they are.</param>
        /// <returns>List of first Names....</returns>
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
