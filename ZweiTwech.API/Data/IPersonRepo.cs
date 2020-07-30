using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZweiTwech.API.Controllers;
using ZweiTwech.API.Models;

namespace ZweiTwech.API.Data
{
    public interface IPersonRepo
    {
        Person AddPerson(Person person);
        int Commit();
    }
}
