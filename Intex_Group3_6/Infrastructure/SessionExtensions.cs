﻿using System.Text.Json;

namespace Intex_Group3_6.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson<T> (this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
