namespace CatWorx.BadgeMaker
{
    class Employee
    {
        private string FirstName;
        private readonly string LastName;
        private readonly int Id;
        private readonly string PhotoUrl;

        public Employee(string firstName, string lastName, int id, string photoUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }
        public int GetId()
        {
            return Id;
        }
        public string GetPhotoUrl()
        {
            return PhotoUrl;
        }
    }
}