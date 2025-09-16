internal class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client();
        client.FirstName = "Jorge";
        client.LastName = "Mendoza";
        client.Age = 25;
        client.Id = 1;

        Console.WriteLine(client.GetFulName());
    }
}
class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string GetFulName()
    {
        return FirstName + " " + LastName;
    }
}