using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using VMWeb.Data;
using VMWeb.Models;

namespace VMWeb.Controllers
{
    public class ContactController
    {
        private readonly Data.Data _data;
        private Contact CurrentContact;
        public ContactController(Data.Data data)
        {
            _data = data;
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            return await _data.Contacts.ToListAsync();
        }

        public async Task<Contact> GetContactById(int id)
        {
            return await _data.Contacts.FindAsync(id);
        }

        public async Task AddContactAsync(Contact contact)
        {
            _data.Contacts.Add(contact);
            await _data.SaveChangesAsync();
        }
    }
}
