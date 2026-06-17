public class Logger {

    // Single instance of Logger
    private static Logger instance;

    // Private constructor
    private Logger() {
        System.out.println("Logger object created");
    }

    // Method to get the single object
    public static Logger getInstance() {

        if (instance == null) {
            instance = new Logger();
        }

        return instance;
    }

    // Method for logging messages
    public void log(String message) {
        System.out.println("Log: " + message);
    }
}