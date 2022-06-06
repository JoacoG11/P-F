using TwitterUCU;

namespace CompAndDel.Filters
{
    public class TwittFilter : IFilter
    {
        private static int i = 0;

        public static int Counter 
        {
            get {
                return i;
            }
        }

        public IPicture Filter(IPicture pic)
        {
            i++;
            var twitt = new TwitterImage();
            twitt.PublishToTwitter("Hello world", $@"C:\Users\Usuario\Desktop\P&F\PII_Pipes_Filters_Start\src\Program\EJ3\step{i}.jpg");
            return pic;

        }
    }
}