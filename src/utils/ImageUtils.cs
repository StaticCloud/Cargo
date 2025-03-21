namespace Cargo.src.utils
{
    internal class ImageUtils
    {
        public static string TrimID(string id)
        {
            return id.Split(':')[1].Substring(0, 6);
        }

        public static string TrimName(string name) 
        {
            return name.Split(':')[0];
        }
    }
}
