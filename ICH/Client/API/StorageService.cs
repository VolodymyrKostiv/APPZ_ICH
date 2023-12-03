using Blazored.LocalStorage;

namespace ICH.Client.API
{
    public class StorageService
    {
        private ILocalStorageService _storage;

        public StorageService(ILocalStorageService storage)
        {
            _storage = storage;
        }

        protected async Task AddItem<T>(string itemName, T item)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);
            if (itemExists)
            {
                await _storage.RemoveItemAsync(itemName);
            }

            await _storage.SetItemAsync<T>(itemName, item);
        }

        protected async Task<bool> ItemExists(string itemName)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);
            
            return itemExists;
        }

        protected async Task<T> GetItem<T>(string itemName)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);
            if (itemExists)
            {
                var item = await _storage.GetItemAsync<T>(itemName);
                return item;
            }

            return default(T);
        }

        protected async Task RemoveItem(string itemName)
        {
            bool itemExists = await _storage.ContainKeyAsync(itemName);
            if (itemExists)
            {
                await _storage.RemoveItemAsync(itemName);
            }
        }
    }
}
