namespace Task5;

public class Counter
{

int _value;

public Counter(int value)
{
    _value= value;
}

public int Decriment(int decriment)
{
 
return _value-decriment;

}

public void  Reset()
{

  
     _value=0;
}

public int PrintValue()
{
    return _value;
}


}
