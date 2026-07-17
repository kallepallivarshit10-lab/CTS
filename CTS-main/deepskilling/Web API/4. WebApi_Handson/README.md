# Lab 4 – ASP.NET Core Web API CRUD Operations

## Aim

To implement CRUD (Create, Read, Update, and Delete) operations using ASP.NET Core Web API and test the APIs using Swagger and Postman.

---

# Overview

In this experiment, the existing ASP.NET Core Web API project was extended to support CRUD operations on Employee data. A hardcoded list of employees was used instead of a database to demonstrate the functionality of the Web API.

The API accepts employee data in JSON format using the **FromBody** attribute and performs Create, Read, Update, and Delete operations.

All API endpoints were tested successfully using Swagger.

---

# What We Implemented

## Employee Data

A hardcoded list of Employee objects was maintained inside the `EmployeeController`. Each employee contains:

- Employee Id
- Employee Name
- Salary
- Permanent Status
- Department
- Skills
- Date of Birth

This list acts as the data source for all CRUD operations.

---

## GET Operation

Implemented a GET action method to retrieve the complete list of employees.

The API returns all employee records in JSON format with **HTTP Status Code 200 (OK)**.

---

## POST Operation

Implemented a POST action method to add a new employee.

The employee details are received from the request body using the **[FromBody]** attribute.

After receiving the request, the employee is added to the hardcoded employee list and returned in the response.

---

## PUT Operation

Implemented a PUT action method to update an existing employee.

The employee object is received through the request body using the **[FromBody]** attribute.

Before updating the record, the following validations were performed:

- Checked whether the employee ID is less than or equal to zero.
- Checked whether the employee ID exists in the hardcoded employee list.

If the employee ID is invalid, the API returns:

```
Invalid employee id
```

with **HTTP Status Code 400 (Bad Request)**.

If the employee ID is valid, the employee details are updated, and the updated employee object is returned in the response.

---

## DELETE Operation

Implemented a DELETE action method to remove an employee from the hardcoded employee list.

The employee is searched using the provided employee ID.

If the employee exists, the record is removed and a success message is returned.

If the employee ID is invalid, the API returns:

```
Invalid employee id
```

with **HTTP Status Code 400 (Bad Request)**.

---

# Validation Performed

The following validations were implemented during the update and delete operations:

- Employee ID must be greater than zero.
- Employee ID must exist in the employee list.
- Invalid employee IDs return **Bad Request (400)** with an appropriate error message.

---

# Testing

The implemented APIs were tested using:

- Swagger UI
- Postman

The following operations were verified successfully:

- Retrieve all employees (GET)
- Add a new employee (POST)
- Update an existing employee (PUT)
- Delete an employee (DELETE)

Both successful and invalid request scenarios were tested.

---

# Output

The Web API successfully performed CRUD operations on the Employee data.

- GET returned the employee list.
- POST added a new employee.
- PUT updated an existing employee after validating the employee ID.
- DELETE removed an employee from the list.
- Invalid employee IDs returned **400 Bad Request** with the message:

```
Invalid employee id
```

---

# Result

Successfully implemented CRUD operations in an ASP.NET Core Web API using a hardcoded Employee list. Employee data was created, retrieved, updated, and deleted through HTTP requests. Input validation was performed for update and delete operations, and all endpoints were tested successfully using Swagger and Postman.
