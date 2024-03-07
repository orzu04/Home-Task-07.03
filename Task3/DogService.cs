namespace Task3;

public class DogService : Dog
{
  
  List<Dog> _dogs = new List<Dog>();

    public DogService(string name, string breed , int age) : base(name, breed, age)
    {
    }

    public List<Dog> GetDogs()
    {

        return   _dogs;
    }

public void AddDog(Dog dog)
{

     _dogs.Add(dog);
}


public void GetByName(string dog1)
{

    foreach (var item in _dogs)
    {
        if(item.Breed==dog1)
        {
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine(item.Breed);
            System.Console.WriteLine(item.Age);
        }
    }
}

}
