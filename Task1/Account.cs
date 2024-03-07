namespace Task1;

public class Account
{

  decimal _balancce;
  

public Account(decimal balancce)
{

    _balancce= balancce;
}

public decimal PriblBalansa(decimal pribl)
{

    return _balancce+pribl;
}

}
