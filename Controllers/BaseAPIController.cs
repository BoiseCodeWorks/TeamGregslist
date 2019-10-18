using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregslist.Services;


namespace gregslist.Controllers
{
    [ApiController]
    public abstract class BaseApiController<T, Tid> : ControllerBase
    {
        public readonly BaseApiService<T, Tid> _service;
        public BaseApiController(BaseApiService<T, Tid> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<T>> Get()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public virtual ActionResult<T> Get(Tid id)
        {
            try
            {
                return Ok(_service.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}