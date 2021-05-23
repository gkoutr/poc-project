using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FearlessPOC.Models;
using FearlessPOC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FearlessPOC.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemRepository _itemRepository;

        public ItemsController(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        
        // GET api/items
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            return _itemRepository.GetAllItems();
        }

        // GET api/items/5
        [HttpGet("{id}")]
        public ActionResult<Item> GetById(int id)
        {
            return _itemRepository.GetItem(id);
        }

        // POST api/items
        [HttpPost]
        public void Post([FromBody] List<Item> items)
        {
            _itemRepository.AddItems(items);
        }

        // PUT api/items/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name)
        {
            _itemRepository.UpdateItem(id, name);
        }

        // DELETE api/items
        [HttpDelete]
        public void Delete()
        {
            _itemRepository.DeleteItems();
        }

        // DELETE api/items/5
        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            _itemRepository.DeleteItem(id);
        }
    }
}
