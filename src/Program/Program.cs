using System;

namespace Ucu.Poo.Cognitive
{
    class Program
    {
        static void Main(string[] args)
        {
            CognitiveFace cog = new CognitiveFace(false);
            string image = @"../../../jane.jpg";
            Console.WriteLine("Image: " + image);
            cog.Recognize(image);
            FoundFace(cog);

            Console.WriteLine("=======================");

            image = @"../../../bill2.jpg";
            Console.WriteLine("Image: " + image);
            cog.Recognize(image);
            FoundFace(cog);

            Console.WriteLine("=======================");

            image = @"../../../yacht.jpg";
            Console.WriteLine("Image: " + image);
            cog.Recognize(image);
            FoundFace(cog);

        }

        static void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.GlassesFound)
                {
                    Console.WriteLine("Has glasses 🤓");
                }
                else
                {
                    Console.WriteLine("No glasses");
                }

                if (cog.SmileFound)
                {
                    Console.WriteLine("Is smiling :)");
                }
                else
                {
                    Console.WriteLine("Is not smiling :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }
    }
}
