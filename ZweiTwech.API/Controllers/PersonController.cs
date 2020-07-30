using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZweiTwech.API.Data;
using ZweiTwech.API.Dto;
using ZweiTwech.API.Models;

namespace ZweiTwech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepo _repository;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<Person> Post(CreatePersonDto person)
        {
            var newPerson = _mapper.Map<Person>(person);
            return _repository.AddPerson(newPerson);
        }
    }
}
