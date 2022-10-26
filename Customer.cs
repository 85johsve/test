public class Customer
{
    private int customerID { get; set; }
    private string customer_name { get; set; }
    private string customer_address { get; set; }
    private int tel_nr { get; set; }
    private List<Customer> customers;

    public Customer()
    {
        
    }
    public Customer(int customerId, string customerName, string customerAdress, int customerPhone)
    {
        customerID = customerId;
        customer_name = customerName;
        customer_address = customerAdress;
        tel_nr = customerPhone;
    }
    public Customer  AddCustomer()
    {
        Customer customer = new();
        return customer;
    }
        public void AddCustomer(Customer customer)
    {

        customers.Add(customer);
        
    }
}