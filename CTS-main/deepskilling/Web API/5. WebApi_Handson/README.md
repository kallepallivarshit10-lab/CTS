# LAB 5 – JWT Authentication and Authorization in ASP.NET Core Web API

## Aim

To implement **JWT (JSON Web Token) Authentication** in an ASP.NET Core Web API application and secure API endpoints using the **Authorize** attribute. The lab also demonstrates **role-based authorization** and **token expiration** using Swagger and Postman.

---

# Objective

- Understand the concept of JWT Authentication.
- Generate a JWT token using an Auth Controller.
- Secure Web API endpoints using the Authorize attribute.
- Test authorized and unauthorized requests.
- Verify JWT token expiration.
- Implement Role-Based Authorization.

---

# Theory

### What is JWT?

JWT (JSON Web Token) is a secure token used to authenticate users in Web APIs.

A JWT consists of three parts:

- Header
- Payload (Claims)
- Signature

Whenever a client logs in successfully, the server generates a JWT token.

The client sends this token in every request using the Authorization header.

```
Authorization: Bearer <JWT Token>
```

The server validates the token before allowing access to protected APIs.

---

# What We Implemented

## Part 1 – Configure JWT Authentication

Configured JWT Authentication inside **Program.cs**.

Added:

- Authentication Service
- Authorization Service
- Security Key
- Issuer
- Audience
- JWT Validation Parameters

Registered middleware:

```csharp
app.UseAuthentication();
app.UseAuthorization();
```

This enables the application to authenticate JWT tokens before processing requests.

---

## Part 2 – Created AuthController

Created a new controller:

```
AuthController
```

Added:

```csharp
[AllowAnonymous]
```

so anyone can request a token.

Created the method:

```csharp
GenerateJSONWebToken()
```

This method:

- Creates Security Key
- Creates Signing Credentials
- Adds User Claims
- Creates JWT Token
- Returns Token as a string

The GET method of AuthController generates and returns the JWT token.

Example:

```
GET /Auth
```

Output:

```
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9......
```

---

## Part 3 – Secured EmployeeController

Removed the Custom Authorization Filter used in the previous lab.

Applied:

```csharp
[Authorize]
```

to the EmployeeController.

Now every request requires a valid JWT token.

Without the token:

```
HTTP Status : 401 Unauthorized
```

With a valid token:

```
HTTP Status : 200 OK
```

---

## Part 4 – Tested Authentication Using Postman

Generated the JWT token using:

```
GET /Auth
```

Copied the generated token.

Added the token in Postman.

Authorization Tab

```
Type : Bearer Token
```

Pasted the generated JWT token.

Sent request to

```
GET /Emp
```

Received

```
Status : 200 OK
```

Employee details were successfully returned.

---

## Part 5 – Tested Unauthorized Request

Removed the JWT token.

Sent the request again.

Received

```
401 Unauthorized
```

This verifies that protected APIs cannot be accessed without authentication.

---

## Part 6 – Tested Invalid Token

Modified a few characters of the generated JWT token.

Sent the request.

Received

```
401 Unauthorized
```

This confirms that invalid tokens are rejected.

---

## Part 7 – Tested Token Expiration

Changed the expiration time in AuthController.

Original:

```csharp
expires: DateTime.Now.AddMinutes(10)
```

Modified to:

```csharp
expires: DateTime.Now.AddMinutes(2)
```

Generated a new JWT token.

Waited for more than two minutes.

Sent the request again.

Received

```
401 Unauthorized
```

This verifies that expired JWT tokens cannot be used.

---

## Part 8 – Implemented Role-Based Authorization

Initially changed the EmployeeController to

```csharp
[Authorize(Roles = "POC")]
```

Generated a JWT token containing

```
Role = Admin
```

Sent the request.

Received

```
401 Unauthorized
```

because the role did not match.

Later modified the controller to

```csharp
[Authorize(Roles = "Admin,POC")]
```

Generated the JWT token again.

Sent the request.

Received

```
200 OK
```

This confirms successful Role-Based Authorization.

---

# Concepts Learned

## JWT Authentication

Authenticates users using encrypted JSON Web Tokens instead of session-based authentication.

---

## Authentication

Authentication verifies the identity of the user requesting access.

---

## Authorization

Authorization determines whether the authenticated user has permission to access a resource.

---

## Claims

Claims store user-related information inside the JWT.

Examples:

- User ID
- Role
- Email

---

## Bearer Token

A JWT is sent through the Authorization header.

```
Authorization: Bearer <Token>
```

---

## AllowAnonymous

Allows API access without authentication.

Used for:

```
AuthController
```

to generate JWT tokens.

---

## Authorize Attribute

Restricts API access to authenticated users.

Example:

```csharp
[Authorize]
```

---

## Role-Based Authorization

Restricts API access based on user roles.

Example:

```csharp
[Authorize(Roles="Admin")]
```

or

```csharp
[Authorize(Roles="Admin,POC")]
```

---

## Token Expiration

JWT contains an expiry time.

After expiration:

- Token becomes invalid.
- API returns **401 Unauthorized**.

---

# Testing Performed

### Test 1

Generated JWT token using

```
GET /Auth
```

Result:

```
Token Generated Successfully
```

---

### Test 2

Accessed Employee API without JWT.

Result:

```
401 Unauthorized
```

---

### Test 3

Accessed Employee API using valid JWT.

Result:

```
200 OK
```

Employee list returned successfully.

---

### Test 4

Modified JWT token.

Result:

```
401 Unauthorized
```

---

### Test 5

Waited until token expired.

Result:

```
401 Unauthorized
```

---

### Test 6

Applied only POC role.

Generated token with Admin role.

Result:

```
401 Unauthorized
```

---

### Test 7

Allowed both Admin and POC roles.

Generated Admin token.

Result:

```
200 OK
```

---

# Result

Successfully implemented JWT Authentication and Authorization in an ASP.NET Core Web API.

The application was able to:

- Generate JWT tokens.
- Authenticate requests using Bearer Tokens.
- Restrict API access using the Authorize attribute.
- Validate token expiration.
- Implement Role-Based Authorization.
- Test authenticated and unauthorized API requests using Swagger and Postman.

The objectives of the experiment were successfully achieved.
