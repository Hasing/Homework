using System.Collections;

namespace OnlineRadio
{
    public static class Extension
    {
        public static bool IsNullOrEmpty(this ICollection source)
        {
            return source == null || source.Count == 0;
        }
    }
}
