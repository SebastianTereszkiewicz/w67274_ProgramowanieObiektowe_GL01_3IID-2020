using System;

public class Class1
{
	public Class1()
	{
	}

    public void SetPesel(string pesel)
    {
        Pesel = pesel;
    }


    public string GetGender()
    {
        retutn int.Parse(Pesel[9], ToString()) % 2 == 0 ? "Woman" : "Man";
    }


    public int GetAge()
    {
        return (DateTime.now = GetBirthDay()).Days / 365
    }


    private DateTime GetBirthDay() { }
    if (month > 80)
    {
        year = year + 1800;
        month = month - 80
    }
    else if (month > 60)
{
    year = year + 2200;
    month = month - 60
    }
else if (month > 40)
{
    year = year + 2100;
    month = month - 40
    }
else if (month > 20)
{
    year = year + 2000;
    month = month - 20;
}
else
{
    year += 1900;
}
return new DateTime(year, month, day);
}

}
