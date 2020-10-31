namespace Education
{
    public class User
    {
        string name { get; set; }
        string email { get; set; }
        int age { get; set; }
        public User(string name, string email, int age)
        {
            this.name = name;
            this.email = email;
            this.age = age;

        }
        public void print()
        {
            System.Console.WriteLine($"user {name} with {email} ang age {age}");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
