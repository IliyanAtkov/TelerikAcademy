using System;

public class HumanTest
{
    public void CreateHuman(int identifier)
    {
        Human person = new Human();
        person.Identifier = identifier;
        if (identifier % 2 == 0)
        {
            person.Name = "Male";
            person.Gender = Gender.Male;
        }
        else
        {
            person.Name = "Female";
            person.Gender = Gender.Female;
        }
    }
}