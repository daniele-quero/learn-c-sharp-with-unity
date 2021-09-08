
[System.Serializable]
public class Customer
{
    public string firstName;
    public string lastName;
    public string gender;
    public string occupation;
    public int age;

    public Customer(string firstName, string lastName, string gender, string occupation, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.occupation = occupation;
        this.age = age;
    }
}
