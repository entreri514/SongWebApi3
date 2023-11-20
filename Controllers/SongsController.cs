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
            var song = _context.Songs.ToList();
            return StatusCode(200,song);
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var songs = _context.Songs.Find(id);
            if (songs==null)
            {
                return NotFound();
            }

            return StatusCode(200,songs);
        }

        // POST api/<SongsController>
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201,song);
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song updatedSong)
        {
            var currentSong = _context.Songs.Find(id);
            if (currentSong==null)
            {
                return NotFound();
            }
            currentSong.Title = updatedSong.Title;
            currentSong.Artist = updatedSong.Artist;
            currentSong.Album = updatedSong.Album;
            currentSong.ReleaseDate = updatedSong.ReleaseDate;
            currentSong.Genre = updatedSong.Genre;
            _context.Update(currentSong);
            _context.SaveChanges();
            return StatusCode(200, currentSong);
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var songs = _context.Songs.Find(id);
            if (songs==null)
            {
                return NotFound();
            }
            _context.Songs.Remove(songs);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
