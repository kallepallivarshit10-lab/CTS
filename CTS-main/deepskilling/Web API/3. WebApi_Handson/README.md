# Lab 3 – ASP.NET Core Web API with Custom Model, Authorization Filter & Exception Filter

## Aim

To create an ASP.NET Core Web API that returns a list of custom Employee objects, accepts data using HTTP POST and PUT requests, validates authorization using a custom action filter, and handles exceptions using a custom exception filter.

---

# Software Used

- Visual Studio 2022
- .NET 10 ASP.NET Core Web API
- Swagger UI
- Postman
- C#

---

# What We Implemented

## Part 1 – Custom Employee Web API

### Models Created

Created the following model classes:

- Employee
- Department
- Skill

The `Employee` model contains:

- Id
- Name
- Salary
- Permanent
- Department
- Skills
- DateOfBirth

---

### Employee Controller

Created a new controller named:

```
EmployeeController
```

Configured the route as:

```csharp
[Route("Emp")]
```

Implemented the following HTTP methods:

- GET
- POST
- PUT

---

### GET Method

Created a private method:

```
GetStandardEmployeeList()
```

which returns a list of Employee objects.

The GET action returns this employee list.

Added:

```csharp
[ProducesResponseType(StatusCodes.Status200OK)]
```

to indicate successful execution.

Verified the GET method using Swagger.

---

### POST Method

Implemented the POST action using:

```csharp
[FromBody]
```

to receive an Employee object in JSON format.

Verified the request using Swagger and Postman.

---

### PUT Method

Implemented the PUT action using:

```csharp
[FromBody]
```

to update an Employee object.

Verified the request using Swagger and Postman.

---

# Part 2 – Custom Authorization Filter

Created a new folder:

```
Filters
```

Created a class:

```
CustomAuthFilter
```

Inherited:

```csharp
ActionFilterAttribute
```

Overrode:

```csharp
OnActionExecuting()
```

Implemented the following validations:

- Checked whether the request contains an **Authorization** header.
- If the Authorization header is missing, returned:

```
Invalid request - No Auth token
```

- If the Authorization header does not contain **Bearer**, returned:

```
Invalid request - Token present but Bearer unavailable
```

Applied the filter to the Employee controller using:

```csharp
[CustomAuthFilter]
```

Tested the API using Swagger and Postman.

Verified that unauthorized requests returned **400 Bad Request**.

---

# Part 3 – Custom Exception Filter

Created a class:

```
CustomExceptionFilter
```

Implemented:

```csharp
IExceptionFilter
```

Overrode:

```csharp
OnException()
```

Implemented the following functionality:

- Captured application exceptions.
- Stored exception details in:

```
ExceptionLog.txt
```

- Returned:

```
500 Internal Server Error
```

Registered the filter globally in **Program.cs**.

Modified the GET method to intentionally throw an exception for testing.

Verified the exception handling using Swagger.

Confirmed that:

- HTTP Status Code **500** was returned.
- Exception details were written to **ExceptionLog.txt**.

---

# Tools Used for Testing

- Swagger UI
- Postman

---

# Output

Successfully developed an ASP.NET Core Web API that:

- Returns Employee data using a custom model.
- Accepts POST and PUT requests using JSON.
- Validates Authorization headers using a custom action filter.
- Handles application exceptions using a custom exception filter.
- Logs exception details into a text file.
- Tested all APIs successfully using Swagger and Postman.

---

# Result

The objectives of the experiment were successfully completed. The Web API was created, tested, secured using a custom authorization filter, and enhanced with custom exception handling. All API endpoints were verified successfully using Swagger and Postman.
