namespace Develope_REST_API.Domain
{
    public class Customer
    {
        private static int id = 1;
        private int _id;
        private List<Invoice> _invoices;
        public Customer()
        {
            _invoices = new List<Invoice>();
            _id = id++;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public List<Invoice> Invoices { get { return _invoices; } }
    }
}
