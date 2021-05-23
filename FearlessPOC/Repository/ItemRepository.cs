using FearlessPOC.Context;
using FearlessPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FearlessPOC.Repository
{
    public class ItemRepository
    {
        private readonly ApiContext _context;

        public ItemRepository(ApiContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets all of the items from the database
        /// </summary>
        /// <returns></returns>
        public List<Item> GetAllItems()
        {
            var items = _context.Items.ToList();
            return items;
        }

        /// <summary>
        /// Gets the item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Item GetItem(int id)
        {
            var item = _context.Items.Where(x => x.Id == id).First();
            return item;
        }

        /// <summary>
        /// Updates an item in the database by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void UpdateItem(int id, String name)
        {
            var item = _context.Items.Where(x => x.Id == id).First();
            item.Name = name;
            _context.Update(item);
            _context.SaveChanges();
        }

        /// <summary>
        /// Adds a list of items to the database
        /// </summary>
        /// <param name="items"></param>
        public void AddItems(List<Item> items)
        {
            foreach(var item in items)
            {
                _context.Add(item);
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes all items from the database
        /// </summary>
        public void DeleteItems()
        {
            var items = _context.Items.ToList();
            foreach (var item in items)
            {
                _context.Remove(item);
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a item from the database by the id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteItem(int id)
        {
            var item = _context.Items.Where(x => x.Id == id).First();
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}
