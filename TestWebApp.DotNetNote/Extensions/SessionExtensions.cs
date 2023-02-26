using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

public static class SessionExtensions
{ 
    public static void Set<T>(this ISession session, string key, T value)
    {
        session.SetString(key, JsonConvert.SerializeObject(value));
    }

    public static T Get<T>(this ISession session, string key)
    {
        var value = session.GetString(key) ;
        //default(T) 라는 것은 value type 인것은 0을 reference Type 인것을 null을 리턴 
        return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);


    }
}
