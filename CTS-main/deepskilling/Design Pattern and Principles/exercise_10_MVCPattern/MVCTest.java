public class MVCTest {

    public static void main(String[] args) {

        // Create Model
        Student student =
                new Student(
                        "Jyothirmai",
                        101,
                        "A");

        // Create View
        StudentView view =
                new StudentView();

        // Create Controller
        StudentController controller =
                new StudentController(
                        student,
                        view);

        // Display initial details
        System.out.println("Initial Details:");

        controller.updateView();

        System.out.println();

        // Update details
        controller.setStudentName("Jyothi");
        controller.setStudentGrade("A+");

        System.out.println("Updated Details:");

        controller.updateView();

    }

}
