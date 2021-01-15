using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppData.Util;

namespace WebAppData.Tasks
{
    public class NotifyData
    {
        private readonly RedisHelper _redisHelper;
        public NotifyData(RedisHelper redisHelper)
        {
            _redisHelper = redisHelper;
        }
        public async Task Subscribe()
        {
            var subscriber = _redisHelper.ConnectRedis().GetSubscriber();

            //var tt = await subscriber.SubscribeAsync("__keyevent@1__:hset");
            //var tt = await subscriber.SubscribeAsync("__keyspace@1__:Pro*");
            var tt = await subscriber.SubscribeAsync("__keyspace@1__:message");

            tt.OnMessage(channel =>
            {
                Console.WriteLine(channel.Message.ToString());
            });
        }
    }
}
