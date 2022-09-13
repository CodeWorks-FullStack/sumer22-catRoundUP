using System;
using System.Collections.Generic;
using catRoundUp.Models;
using catRoundUp.Services;
using Microsoft.AspNetCore.Mvc;

namespace catRoundUp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CatsController : ControllerBase
  {

    private readonly CatsService _catService;

    public CatsController(CatsService catService)
    {
      _catService = catService;
    }

    [HttpGet]
    public ActionResult<List<Cat>> GetCats()
    {
      try
      {
        List<Cat> cats = _catService.GetCats();
        return Ok(cats);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // NOTE {id} creates a route parameter
    [HttpGet("{id}")]
    public ActionResult<Cat> GetCatById(int id)
    {
      try
      {
        Cat cat = _catService.GetCatById(id);
        return Ok(cat);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Cat> CreateCat([FromBody] Cat body)
    {
      try
      {
        Cat cat = _catService.CreateCat(body);
        return Ok(cat);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Cat> UpdateCat([FromBody] Cat body, int id)
    {
      try
      {
        body.Id = id;
        Cat cat = _catService.UpdateCat(body);
        return Ok(cat);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> DeleteCat(int id)
    {
      try
      {
        string message = _catService.DeleteCat(id);
        return Ok(message);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}