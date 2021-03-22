namespace System
{
    public static class ExtensionMethod
    {
        public static string Cut(this string obj, int number)
        {
            if (obj.Length <= number)
            {
                return obj;
            }
            return obj.Substring(0, number) + "...";
        }
    }
}
