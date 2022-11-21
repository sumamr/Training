namespace APIAssignment.Models
{
    public class user
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string  email { get; set; }

        public Int16 mobile { get; set; }

        public string password { get; set; }

        internal static Task Search(string emailid, string password)
        {
            throw new NotImplementedException();
        }
    }
}
