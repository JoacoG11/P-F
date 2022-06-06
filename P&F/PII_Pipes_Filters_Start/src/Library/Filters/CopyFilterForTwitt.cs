using System.Drawing;

namespace CompAndDel.Filters
{
    public class CopyFilterForTwitt : IFilter 
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
           PictureProvider prov = new PictureProvider();
           prov.SavePicture(pic, $@"C:\Users\Usuario\Desktop\P&F\PII_Pipes_Filters_Start\src\Program\EJ3\step{i}.jpg");
           return pic;
        }
    }
}
