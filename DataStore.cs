using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Contact_Service.CommonModels;

namespace Contact_Service
{
    public interface IContactDataStore
    {
        Task<string> GetContacts();
        Task<string> GetContact(int id);
    }
    public class ContactDataStore: IContactDataStore
    {
        private readonly HttpClient _client;

        public ContactDataStore(HttpClient client)
        {
           _client = client;
        }
        public async Task<string> GetContacts()
        {
            return await _client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
        }

        public async Task<string> GetContact(int id)
        {
            return await _client.GetStringAsync($"https://jsonplaceholder.typicode.com/users/{id}");
        }
    }
}