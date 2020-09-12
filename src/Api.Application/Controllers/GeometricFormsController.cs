using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Directory;
using Api.Domain.Interfaces.Services.GeometricForm;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GeometricFormsController : ControllerBase
    {
        private IGeometricFormService _service;
        private IDirectoryService _directoryService;
        public GeometricFormsController(IGeometricFormService service, IDirectoryService directoryService)
        {
            this._service = service;
            this._directoryService = directoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetGeometricFormWithId")]
        public async Task<ActionResult> Get(Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Get(Id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost] //[FromBody] Json, que vai conter um userEntity
        public async Task<ActionResult> Post([FromBody] GeometricFormEntity entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                //falta implementar Directory exist
                /*var directory = _directoryService.Exist(entity.Directory.Id);
                if(directory == null)
                {
                    return BadRequest();
                }*/

                //esta inserindo um registro de forma geométtica com Guid nulo de diretório, também esta inserindo 
                //um novo registro de diretório, pois esta usando um baseRepository, implementar um GeometricFormRepository

                var result = await _service.Post(entity);
                if (result != null)
                    return Created(new Uri(Url.Link("GetGeometricFormWithId", new { id = result.Id })), result);
                else
                    return BadRequest();
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut] //[FromBody] Json, que vai conter um userEntity
        public async Task<ActionResult> Put([FromBody] GeometricFormEntity entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                //falta implementar Directory exist
                /*var directory = _directoryService.Exist(entity.Directory.Id);
                if(directory == null)
                {
                    return BadRequest();
                }*/

                //esta inserindo um registro de forma geométtica com Guid nulo de diretório, também esta inserindo 
                //um novo registro de diretório, pois esta usando um baseRepository, implementar um GeometricFormRepository

                var result = await _service.Put(entity);
                if (result != null)
                    return Ok(result);
                else
                    return BadRequest();
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpDelete("{id}")] //[FromBody] Json, que vai conter um userEntity
        public async Task<ActionResult> Delete(Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Delete(Id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
