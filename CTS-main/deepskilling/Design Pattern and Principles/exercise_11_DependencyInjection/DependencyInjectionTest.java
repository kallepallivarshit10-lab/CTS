public class DependencyInjectionTest {

    public static void main(String[] args) {

        // Create Repository object
        CustomerRepository repository =
                new CustomerRepositoryImpl();

        // Inject repository into service
        CustomerService service =
                new CustomerService(repository);

        // Find customer
        service.getCustomer(101);

    }

}
