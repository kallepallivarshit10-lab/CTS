public class BuilderTest {

    public static void main(String[] args) {

        // Gaming Computer
        Computer gamingComputer =
                new Computer.Builder()
                        .setCPU("Intel i9")
                        .setRAM("32GB")
                        .setStorage("1TB SSD")
                        .setGraphicsCard("RTX 4090")
                        .setOperatingSystem("Windows 11")
                        .build();

        // Office Computer
        Computer officeComputer =
                new Computer.Builder()
                        .setCPU("Intel i5")
                        .setRAM("8GB")
                        .setStorage("512GB SSD")
                        .setGraphicsCard("Integrated")
                        .setOperatingSystem("Windows 10")
                        .build();

        gamingComputer.display();

        officeComputer.display();
    }
}
