# Exercise 10: Implementing the MVC Pattern

## Aim

To implement the Model-View-Controller (MVC) design pattern for managing student records.

---

## Scenario

A student management system needs to separate data, presentation, and business logic. The MVC pattern provides this separation through Model, View, and Controller components.

---

## Classes Created

### Model

- Student.java

Contains:

- name
- id
- grade

---

### View

- StudentView.java

Contains:

```java
displayStudentDetails()
```

Responsible for displaying student information.

---

### Controller

- StudentController.java

Acts as an intermediary between the model and the view.

Provides:

- setStudentName()
- setStudentId()
- setStudentGrade()
- updateView()

---

### Main Class

- MVCTest.java

Demonstrates creating a student, modifying details, and displaying them.

---

## Working

1. Create Student object.
2. Create StudentView object.
3. Create StudentController object.
4. Update student details through controller.
5. Display details using view.

---

## Expected Output

```
Initial Details:
Student Details
----------------
Name : Jyothirmai
ID : 101
Grade : A

Updated Details:
Student Details
----------------
Name : Jyothi
ID : 101
Grade : A+
```

---

## Result

Successfully implemented the Model-View-Controller (MVC) design pattern for a student management system.

---

## Design Pattern Used

MVC Pattern (Architectural Pattern)

---
