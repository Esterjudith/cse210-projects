using System.Collections.Concurrent;

public class Address 
{
    private int _streetNum;
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUSA;

    public Address(int streetNum, string streetName, string city, string state, string country) 
    {
        _streetNum = streetNum;
        _streetName = streetName;
        _city = city;
        _state = state;
        _country = country;

        _inUSA = _country.ToUpper() == "USA";
        
    }
    

    public bool IsInUSA()
    {
        
      return _inUSA;
    }

    public string GetAddressString()
    {  if (_inUSA)
      {
         return $"{_streetNum} {_streetName}\n{_city}, {_state} {_country}";
        
      }
      else
      {
        return $"{_streetName} {_streetNum}\n{_city}, {_country}";
        
      }
       
    }

}