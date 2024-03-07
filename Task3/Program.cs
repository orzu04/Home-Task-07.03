
using Task3;

var dog1 = new DogService("Rex","Avcharka",2);

var dog2 = new DogService("Jeck","BoolDog",3);
var dog3= new DogService("Palvon","Alabay",3);

dog1.GetDogs();

dog1.AddDog(dog1);
dog1.AddDog(dog2);
dog1.AddDog(dog3);


while (true)
{

     System.Console.WriteLine($"Kokoy parode bi wi hateli: avcharka");
     System.Console.WriteLine($"Kokoy parode bi wi hateli: booldog");
      System.Console.WriteLine($"Kokoy parode bi wi hateli: alabay");

   string command = Console.ReadLine();
   if(command=="avcharka")
   {

     dog1.GetByName("Avcharka");

   }

    else if(command=="booldog")
   {
    
     dog1.GetByName("Booldog");


   }

 
    else if(command=="alabay")
   {
    
     dog1.GetByName("Alabay");
     

   }

   break;

}

foreach (var item in dog1.GetDogs())
{
    
  System.Console.WriteLine(item);

}