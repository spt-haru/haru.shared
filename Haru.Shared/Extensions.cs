namespace Haru.Shared
{
    public static class Extensions
    {
        public static string ReplaceFirst(this string s, string search, string replace)
        {
            var position = s.IndexOf(search);

            if (position < 0)
            {
                return s;
            }

            return s.Substring(0, position) + replace + s.Substring(position + search.Length);
        }
    }
}