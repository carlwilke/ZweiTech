using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZweiTwech.API.Controllers;
using System.Net;
using System.Net.Http;
using ZweiTwech.API.Models;


namespace ZweiTwech.API.Data
{
    public class SqLiteRepo : IPersonRepo
    {
        private readonly ZweiTechDbContext _db;

        public SqLiteRepo(ZweiTechDbContext db)
        {
            _db = db;
        }

        public Person AddPerson(Person person)
        {
            // Add Time stamp when added
            person.DateAdded = DateTime.Now;
            // Add the person to the database
            _db.Add(person);
            _db.SaveChangesAsync();
            return person;
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }
    }
}
