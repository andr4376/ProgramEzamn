using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DogsController : ApiController
    {

        // GET: api/Dogs
        public List<Dog> Get()
        {
            return Database.Dogs;
        }

        // GET: api/Dogs/5
        public Dog Get(int id)
        {
            return Database.Dogs.Where(dog => dog.ID == id).FirstOrDefault(); //returns the appropriate dog
        }


        //Costumize route
        [Route("api/dogs/names")]
        [HttpGet] //the type that is allowed to use it
        // GET: api/Dogs/names
        public List<string> GetAllNames()
        {
            List<string> names = new List<string>();

            foreach (Dog dog in Database.Dogs)
            {
                names.Add(dog.Name);
            }

            return names;
        }

        //Costumize route
        [Route("api/dogs/names/{Name}")]
        [HttpGet] //the type that is allowed to use it
        // GET: api/Dogs/names
        public Dog GetDogWithName(string name)
        {
            return Database.Dogs.Where(dog => dog.Name.ToLower() == name.ToLower()).FirstOrDefault();

        }
        // POST: api/Dogs
        //When using post, write in Postman (or rested plugin) in the body section
        //== new Dog()
        //{
        //ID: 1
        //Name: 'Charlie'
        //Race: 'Collie'
        //}
        //the {} and the content is a "BODY", and with JSON, you can make new objects using that
        public void Post(Dog dog)
        {
            //evaluate element... then
            Database.Dogs.Add(dog);
        }

        // PUT: api/Dogs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dogs/5
        public void Delete(int id)
        {
            Database.Dogs.Remove(Database.Dogs.Where(x => x.ID == id).FirstOrDefault()); //returns the appropriate dog

        }
    }
}
