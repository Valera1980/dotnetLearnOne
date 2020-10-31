namespace Education
{
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
         public User()
        {
            this.name = "none";
            this.email = "none";
            this.age = 1;

        }
        public User(string name, string email, int age)
        {
            this.name = name;
            this.email = email;
            this.age = age;

        }
        public void print()
        {
            System.Console.WriteLine($" == user with name:{name}; email:{email} and age:{age} ==");
        }

    }
}
