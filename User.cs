
namespace UserService
{
    public class User
    {
        public User(string Name, int age, string email, int id)
        {
            this.Name = Name;
            this.Age = age;
            this.Email = email;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
    }
}
