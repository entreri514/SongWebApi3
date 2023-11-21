using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.CRUD;
using SongWebApi.Data;
using SongWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SongWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<SongsController>
        [HttpGet]
        public IActionResult Get()
        {
            var getSong = _context.Songs.ToList();
            return StatusCode(200,getSong);
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getSong = _context.Songs.Find(id);
            if (getSong==null)
            {
                return NotFound();
            }

            return StatusCode(200,getSong);
        }

        // POST api/<SongsController>
        [HttpPost]
        public IActionResult Post([FromBody] Song addSong)
        {
            _context.Songs.Add(addSong);
            _context.SaveChanges();
            return StatusCode(201,addSong);
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song updatedSong)
        {
            var updateSong = _context.Songs.Find(id);
            if (updateSong==null)
            {
                return NotFound();
            }
            updateSong.Title = updatedSong.Title;
            updateSong.Artist = updatedSong.Artist;
            updateSong.Album = updatedSong.Album;
            updateSong.ReleaseDate = updatedSong.ReleaseDate;
            updateSong.Genre = updatedSong.Genre;
            _context.Update(updateSong);
            _context.SaveChanges();
            return StatusCode(200, updateSong);
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleteSong = _context.Songs.Find(id);
            if (deleteSong==null)
            {
                return NotFound();
            }
            _context.Songs.Remove(deleteSong);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
