namespace Xanthe;

public static class Program
{
    public static void Main()
    {
        using (var db = new Context())
        {
            db.Database.EnsureCreated();
            db.Add(new EPerson{ Name = "Bianca", Age = 22});
            db.SaveChanges();
        }
    }
}