using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO 1
            
            PictureProvider p1 = new PictureProvider();
            IPicture picture = p1.GetPicture(@"C:\Users\Usuario\Desktop\P&F\PII_Pipes_Filters_Start\src\Program\beer.jpg");
           
            PipeNull pipe3 = new PipeNull();
            FilterNegative fneg = new FilterNegative();
            PipeSerial pipe2 = new PipeSerial(fneg, pipe3);
            FilterGreyscale fgrey = new FilterGreyscale();
            PipeSerial pipe1 = new PipeSerial(fgrey, pipe2);
            IPicture picmodificada = pipe1.Send(picture);

            PictureProvider provider = new PictureProvider();
            provider.SavePicture(picmodificada, @"C:\Users\Usuario\Desktop\P&F\PII_Pipes_Filters_Start\src\Program\EJ1\ResultadoEJ1.jpg");


            //EJERCICIO 2
            
            PictureProvider p2 = new PictureProvider();
            IPicture picture2 = p2.GetPicture(@"C:\Users\Usuario\Desktop\P&F\PII_Pipes_Filters_Start\src\Program\luke.jpg");
           
            PipeNull pipe6 = new PipeNull();
            PipeSerial Step2_2 = new PipeSerial(new CopyFilter(), pipe6);
            PipeSerial pipe5 = new PipeSerial(new FilterNegative(), Step2_2);
            PipeSerial Step1_2 = new PipeSerial(new CopyFilter(), pipe5);
            PipeSerial pipe4 = new PipeSerial(new FilterGreyscale(), Step1_2);
            IPicture pic2modif = pipe4.Send(picture2);

            PictureProvider provider2 = new PictureProvider();
            provider.SavePicture(pic2modif, @"C:\Users\Usuario\Desktop\P&F\PII_Pipes_Filters_Start\src\Program\EJ2\ResultadoEJ2.jpg");

            //EJERCICIO 3

            PictureProvider p3 = new PictureProvider();
            IPicture picture3 = p3.GetPicture(@"C:\Users\Usuario\Desktop\P&F\PII_TwitterApi\src\Program\bill2.jpg");
           
            PipeNull pipe9 = new PipeNull();
            PipeSerial Twitt2 = new PipeSerial(new TwittFilter(), pipe9);
            PipeSerial Step2_3 =new PipeSerial(new CopyFilterForTwitt(), Twitt2);
            PipeSerial pipe8 = new PipeSerial(new FilterNegative(), Step2_3);
            PipeSerial Twitt1 = new PipeSerial(new TwittFilter(), pipe8);
            PipeSerial Step1_3 = new PipeSerial(new CopyFilterForTwitt(), pipe8);
            PipeSerial pipe7 = new PipeSerial(new FilterGreyscale(), Step1_3);
            IPicture pic3modif = pipe7.Send(picture3);

            PictureProvider provider3 = new PictureProvider();
            provider.SavePicture(pic3modif, @"C:\Users\Usuario\Desktop\P&F\PII_Pipes_Filters_Start\src\Program\EJ3\ResultadoEJ3.jpg");
       }

    }
}
