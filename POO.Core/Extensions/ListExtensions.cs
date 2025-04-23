namespace POO.Core.Extensions
{
    public static class ListExtensions
    {
        public static void AddIfNotNull(this List<string> list, List<string?> items)
        {
            if (items == null) return;

            foreach(var item in items)
                if(!string.IsNullOrEmpty(item))
                    list.Add(item);
        }
    }
}