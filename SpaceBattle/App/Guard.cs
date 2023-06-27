using System;

namespace SpaceBattle
{
    public static class Guard
    {
        public static void NotNull(object value, string message)
        {
            if (value == null)
                throw new NullReferenceException(message);
        }
        public static void NotNull(string value, string message)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NullReferenceException(message);
        }
    }
}