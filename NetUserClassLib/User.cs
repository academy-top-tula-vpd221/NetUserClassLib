namespace NetUserClassLib
{
    public class User
    {
        public string Name { set; get; } = "";

        int age = 0;

        public int Age
        {
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    age = 0;
            }
            get
            {
                return age;
            }
        }

        public User() { }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}