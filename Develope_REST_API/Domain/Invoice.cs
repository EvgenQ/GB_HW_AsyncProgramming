namespace Develope_REST_API.Domain
{
    public class Invoice
    {
        private static int id = 1;
        private int _id;
        public Invoice()
        {
            _id = id++;
        }

        public int Id { get { return _id; } set { _id = value; } }

    }
}
