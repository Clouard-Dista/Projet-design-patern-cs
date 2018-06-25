namespace RestaurantAsiatique.User
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string address;

        public User(string lastname, string firstname, string addresse)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = addresse;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
    }
}