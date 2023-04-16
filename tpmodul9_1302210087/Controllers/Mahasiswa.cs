using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;


namespace tpmodul9_1302210087.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : ControllerBase
    {
        public static List<Mahasiswa2> _data = new List<Mahasiswa2>
        {
            new Mahasiswa2("Gifari Juliandri", "1302210087"),
            new Mahasiswa2("Surya Aulia", "1302210084"),
            new Mahasiswa2("Risjad Shidqi", "1302213045"),
            new Mahasiswa2("Ashar Syahbudi", "1302210070"),
            new Mahasiswa2("Zhafran Hafiz", "1302210036"),
        };
        // GET: api/<Mahasiswa>
        [HttpGet]
        public IEnumerable<Mahasiswa2> Get()
        {
            return _data;
        }

        // GET api/<Mahasiswa>/5
        [HttpGet("{id}")]
        public Mahasiswa2 Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Mahasiswa>
        [HttpPost]
        public void Post([FromBody] Mahasiswa2 value)
        {
            _data.Add(value);
        }
        // DELETE api/<Mahasiswa>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}
