using StackExchange.Redis;
using System.Text.Json;

namespace Utils
{

    public interface IRedisCacheHelper
    {
        Task<T?> GetAsync<T>(string key);
        Task SetAsync<T>(string key, T value, TimeSpan? expiry = null);
    }

    public class RedisCacheHelper : IRedisCacheHelper
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;
        private readonly ILogger<RedisCacheHelper> _logger;

        public RedisCacheHelper(IConnectionMultiplexer connectionMultiplexer,
                                 ILogger<RedisCacheHelper> logger)
        {
            _connectionMultiplexer = connectionMultiplexer;
            _logger = logger;
        }

        private IDatabase Db => _connectionMultiplexer.GetDatabase();

        public async Task<T?> GetAsync<T>(string key)
        {
            try
            {
                var value = await Db.StringGetAsync(key);
                if (value.IsNullOrEmpty)
                    return default;
                return JsonSerializer.Deserialize<T>(value!);
            }
            catch (Exception ex) // จะจับละเอียดเป็น RedisException/Timeout ก็ได้
            {
                _logger.LogError(ex, "Redis GET failed for key {Key}", key);
                return default;
            }
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        {
            try
            {
                var json = JsonSerializer.Serialize(value);
                await Db.StringSetAsync(key, json, expiry);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Redis SET failed for key {Key}", key);

            }
        }
    }


    public class NoOpCacheHelper : IRedisCacheHelper
    {
        public Task<T?> GetAsync<T>(string key)
        {

            return Task.FromResult<T?>(default);
        }

        public Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        {

            return Task.CompletedTask;
        }
    }

}
