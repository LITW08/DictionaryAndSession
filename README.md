# DictionaryAndSession

You need to add the following lines of code to enable Session:

https://github.com/LITW08/DictionaryAndSession/blob/master/DictionaryAndSession/Startup.cs#L24

https://github.com/LITW08/DictionaryAndSession/blob/master/DictionaryAndSession/Startup.cs#L44

Also, to add any arbitrary C# object to session, use the following extension method (you'll first need to install the NewtonSoft.Json library via Nuget):

    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            string value = session.GetString(key);

            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);
        }
    }
