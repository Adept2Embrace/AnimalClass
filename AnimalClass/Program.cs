global using global::System;
namespace AnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Dogs dogs1 = new Dogs(0, "White");
            Dogs dogs2 = new Dogs(0, "Grey");
            Dogs dogs3 = new Dogs(1, "Black");
            Dogs dogs4 = new Dogs(2, "Brown");
            Dogs dogs5 = new Dogs(3, "Dark Grey");

                     
            //creating list of Dogs
            List<Dogs> dogList = new List<Dogs>();
            dogList.Add(dogs1);
            dogList.Add(dogs2);
            dogList.Add(dogs3);
            dogList.Add(dogs4);
            dogList.Add(dogs5);


            //code to filter puppies by calling overiden function
            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList[i].isBaby())
                {
                    Console.WriteLine("{0} dog is a puppy with age {1}", dogList[i].Color, dogList[i].Age);
                }

            }          

        }
    }
}