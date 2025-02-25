using System;
using Newtonsoft.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Deserialize JSON to Person object
        string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Serialize Person object to JSON
        Person newPerson = new Person { Name = "pingpong", Age = 200 };
        string newJson = JsonConvert.SerializeObject(newPerson);
        System.Console.WriteLine($"Serialized JSON: {newJson}");
    }
}