# Exercise 11: Implementing Dependency Injection

## Aim

To implement Dependency Injection using constructor injection in a customer management application.

---

## Scenario

A CustomerService class depends on a CustomerRepository. Dependency Injection is used to provide the repository object externally, reducing coupling between classes.

---

## Classes Created

### Repository Interface

- CustomerRepository.java

Defines:

```java
findCustomerById()
```

---

### Concrete Repository

- CustomerRepositoryImpl.java

Implements the repository interface and returns customer information.

---

### Service Class

- CustomerService.java

Depends on CustomerRepository and receives it through constructor injection.

---

### Main Class

- DependencyInjectionTest.java

Demonstrates injecting CustomerRepositoryImpl into CustomerService.

---

## Working

1. Create CustomerRepositoryImpl object.
2. Inject it into CustomerService using constructor injection.
3. Call getCustomer().
4. Retrieve and display customer details.

---

## Expected Output

```
Customer ID: 101, Name: varshitvarma
```

---

## Result

Successfully implemented Dependency Injection using constructor injection.

---

## Principle Used

Dependency Injection (Constructor Injection)

---
