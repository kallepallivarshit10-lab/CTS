public class ProxyTest {

    public static void main(String[] args) {

        Image image = new ProxyImage("nature.jpg");

        System.out.println("Image object created.");

        System.out.println();

        System.out.println("First display:");

        image.display();

        System.out.println();

        System.out.println("Second display:");

        image.display();

    }

}
