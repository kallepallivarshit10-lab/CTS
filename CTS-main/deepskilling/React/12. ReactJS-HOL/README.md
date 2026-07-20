# Ticket Booking App - React

##  Project Overview

**Ticket Booking App** is a React-based web application developed as part of a hands-on lab experiment.

The main purpose of this experiment is to understand and implement **Conditional Rendering in React applications**.

In this application:

- A guest user can browse available flight details.
- A logged-in user can access the ticket booking page.
- Login and Logout buttons dynamically change the displayed page.
- Components are rendered based on the user's login status.

---

#  Objectives

The objectives of this experiment are:

- To understand conditional rendering in React.
- To learn about element variables.
- To understand how to prevent unnecessary component rendering.
- To implement dynamic UI changes using React state.
- To create an interactive React application.

---

# 🛠️ Technologies Used

- React JS
- JavaScript (ES6)
- HTML5
- CSS3
- Node.js
- NPM
- Visual Studio Code

---

#  Project Structure

```
ticketbookingapp
│
├── public
│
├── src
│   │
│   ├── App.js
│   ├── App.css
│   └── index.js
│
├── package.json
│
└── README.md
```

---

#  Application Description

The application contains two different views:

## 1. Guest User Page

When the application starts, the user is considered as a guest.

Features:

- Displays available flight details.
- Allows users to view flight information.
- Shows a message asking users to login for booking.

Example:

```
Welcome Guest User

Available Flights

Flight       From          To          Price

AI101        Hyderabad     Delhi       ₹5000

6E202       Bangalore      Mumbai      ₹4500

Please login to book tickets.
```

---

## 2. Logged In User Page

After clicking the Login button, the user is redirected to the booking page.

Features:

- Displays welcome message.
- Allows users to enter passenger details.
- Allows flight selection.
- Provides ticket booking option.

Example:

```
Welcome Logged In User

Book Your Flight Ticket

Passenger Name: ________

Select Flight: ________

[Book Ticket]
```

---

#  Login and Logout Functionality

The application provides login and logout functionality.

### Login:

- Initially, the application displays the Guest Page.
- When the user clicks the Login button:
  - The login state changes.
  - The User Page is displayed.

### Logout:

- When the user clicks Logout:
  - The login state becomes false.
  - The Guest Page is displayed again.

---

#  Concepts Learned

## 1. Conditional Rendering in React

Conditional rendering is a technique used to display different UI elements based on certain conditions.

In this project, the page displayed depends on whether the user is logged in or not.

Example:

```javascript
if(isLoggedIn)
{
    page = <UserPage />;
}
else
{
    page = <GuestPage />;
}
```

If the condition is true:

```
User Page is displayed
```

If the condition is false:

```
Guest Page is displayed
```

---

# 2. Element Variables

Element variables are used to store React elements inside variables.

They help in controlling which component should be rendered.

Example:

```javascript
let page;

page = <UserPage />;
```

The stored element is displayed using:

```javascript
{page}
```

In this project, the `page` variable stores either:

- UserPage component
- GuestPage component

depending on the login status.

---

# 3. Preventing Components from Rendering

React allows developers to prevent components from rendering when they are not required.

In this application:

- UserPage is displayed only for logged-in users.
- GuestPage is displayed only for guest users.

This improves application performance by rendering only the required component.

---

#  React Hook Used

## useState()

The `useState()` hook is used to store and update the login status.

Example:

```javascript
const [isLoggedIn, setIsLoggedIn] = useState(false);
```

### isLoggedIn

Stores the current login status.

Values:

```
true  → User is logged in

false → User is a guest
```

### setIsLoggedIn()

Used to update the login status.

Example:

```javascript
setIsLoggedIn(true);
```

Changes the user to logged-in state.

```javascript
setIsLoggedIn(false);
```

Changes the user back to guest state.

---

#  Application Flow

```
              Application Starts
                     |
                     |
              Guest User Page
                     |
                     |
             Click Login Button
                     |
                     |
          Login State Changes
                     |
                     |
             User Booking Page
                     |
                     |
             Click Logout Button
                     |
                     |
              Guest Page Again
```

---

#  Installation and Execution

## Step 1: Clone Repository

```bash
git clone <repository-url>
```

---

## Step 2: Navigate to Project Folder

```bash
cd ticketbookingapp
```

---

## Step 3: Install Dependencies

```bash
npm install
```

---

## Step 4: Start React Application

```bash
npm start
```

The application will run at:

```
http://localhost:3000
```

---

#  Output Screens

## Guest Page

Displays:

- Flight details
- Login button
- Guest message


## User Page

Displays:

- Booking form
- Logout button
- Ticket booking option

---

#  Learning Outcomes

After completing this experiment, I learned:

✅ How to implement conditional rendering in React.

✅ How React changes UI dynamically using state.

✅ How to use element variables for rendering components.

✅ How to control component visibility.

✅ How login/logout functionality can be implemented using React hooks.

✅ How to create interactive web applications using React.

---

#  Future Enhancements

The application can be improved by adding:

- User authentication system.
- Database integration.
- Payment gateway.
- Flight search functionality.
- Booking history.
- User profile management.

---

#  Conclusion

This hands-on lab helped me understand the concept of **Conditional Rendering in React**.

By creating the Ticket Booking Application, I learned how React manages dynamic user interfaces using:

- State management
- Conditional rendering
- Element variables
- Component control

This experiment provided practical knowledge of building interactive React applications.

---


