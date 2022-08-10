namespace Develope_REST_API.Domain
{
    public static class SomeCompany
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<Customer> customers = new List<Customer>();
        public static List<Contract> contracts = new List<Contract>();
        public static List<Invoice> invoices = new List<Invoice>();

        internal static List<Customer>? GetAllCustomers()
        {
            if(customers.Count == 0)
            {
                return null;
            }
            return customers;
        }
        internal static Customer? GetCustomers(int id)
        {
            var customer = customers.FirstOrDefault(x => x.Id == id);
            if(customer == null)
            {
                return null;
            }
            return customer;
        }
        internal static Customer? CreateCustomer()
        {
            var customer = new Customer();
            customers.Add(customer);
            return customer;
        }

        internal static Customer? UpdateCustomer(int id, int newId)
        {
            var customer = customers.FirstOrDefault(x => x.Id == id);
            if(customer != null)
            {
                customers.Remove(customer);
                customer.Id = newId;
                customers.Add(customer);
                return customer;
            }
            return null;
        }

        #region OperationWithInvoices
        internal static List<Invoice>? GetAllInvoices()
        {
            if (invoices.Count == 0)
            {
                return null;
            }
            return invoices;
        }
        internal static Invoice? GetInvoice(int id)
        {
            var invoice = invoices.FirstOrDefault(x => x.Id == id);
            if (invoice == null)
            {
                return null;
            }
            return invoice;
        }
        internal static Invoice? UpdateInvoice(int id, int newId)
        {
            var invoice = invoices.FirstOrDefault(x => x.Id == id);
            if (invoice != null)
            {
                invoices.Remove(invoice);
                invoice.Id = newId;
                invoices.Add(invoice);
                return invoice;
            }
            return null;
        }
        internal static Invoice? CreateInvoice()
        {
            var invoice = new Invoice();
            invoices.Add(invoice);
            return invoice;
        }
        internal static bool DeleteInvoice(int id)
        {
            var invoice = invoices.FirstOrDefault(x => x.Id == id);
            if (invoice != null)
            {
                invoices.Remove(invoice);
            }
            return false;
        }
        #endregion
        #region OperationsWithEmployees
        internal static Employee? UpdateEmployee(int id, int newId)
        {
            foreach (var employee in employees)
            {
                if (employee.Id == id)
                {
                    employee.Id = newId;
                    return employee;
                }
            }
            return null;
        }


        public static List<Employee> CreateEmployee()
        {
            employees.Add(new Employee());
            return employees;
        }
        internal static List<Employee>? GetAllEmployee()
        {
            if (employees.Count == 0)
            {
                return null;
            }
            return employees;
        }
        internal static Employee? GetEmployee(int id)
        {
            foreach (var employee in employees)
            {
                if (id == employee.Id)
                {
                    return employee;
                }
            }
            return null;
        }
        internal static void DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
        #endregion
        #region OperationsWithContracts
        internal static List<Contract>? GetAllContract()
        {
            if (contracts.Count == 0) 
            {
                return null;
            }
            return contracts;
        }
        internal static Contract? GetContract(int id)
        {
            if(contracts.Count == 0)
            {
                return null;
            }
            return contracts.FirstOrDefault(x => x.Id == id);
        }
        internal static Contract? CreateContract()
        {
            var contract = new Contract();
            contracts.Add(contract);
            return contract;
        }
        internal static Contract? UpdateContract(int id, int newId)
        {
            var contract = contracts.FirstOrDefault(x => x.Id == id);
            if (contract != null) 
            {
                contracts.Remove(contract);
                contract.Id = newId;
                contracts.Add(contract);
            }
            return contract;
        }
        internal static bool DeleteContract(int id)
        {
            var contract = contracts.FirstOrDefault(x => x.Id == id);
            if (contract != null)
            {
                contracts.Remove(contract);
            }
            return false;
        }

        #endregion

    }
}
