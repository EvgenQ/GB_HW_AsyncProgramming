namespace Develope_REST_API.Domain
{
    public class Employee
    {
        private static int id = 1;
        private int _id;
        private List<Contract> _contracts;
        public Employee()
        {
            _contracts = new List<Contract>();
            _id = id++;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public List<Contract> Contracts { get { return _contracts; } }

        public List<Contract> AddContract() 
        {
            _contracts.Add(new Contract());
            return _contracts;
        }
    }
}
