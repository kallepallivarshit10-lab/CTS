# React Lab 2
# React Components – Student Management Portal

## Aim

To create a React application named **StudentApp** and implement multiple React components (Home, About, and Contact) to display different messages in a Student Management Portal.

---

# Objectives

- Understand React Components.
- Learn the difference between React Components and JavaScript Functions.
- Learn the types of React Components.
- Understand Class Components.
- Understand Function Components.
- Learn about Component Constructor.
- Understand the purpose of the render() function.
- Create multiple React components.
- Render multiple components in a React application.

---

# Software Requirements

- Node.js
- npm (Node Package Manager)
- Visual Studio Code
- Google Chrome / Microsoft Edge

---

# Prerequisites

The following software must be installed before performing this experiment:

- Node.js
- npm
- Visual Studio Code

Verify installation using:

```bash
node -v
npm -v
```

---

# React Components

A React Component is an independent and reusable piece of UI that returns JSX to display content on the webpage.

Components help divide the user interface into small reusable parts.

---

# Types of Components

## 1. Function Component

- Created using JavaScript functions.
- Simpler and easier to write.
- Uses Hooks for state management.

Example:

```jsx
function Home() {
    return <h1>Home Component</h1>;
}
```

---

## 2. Class Component

- Created using ES6 classes.
- Extends React.Component.
- Uses constructor() and render() methods.
- Supports lifecycle methods.

Example:

```jsx
class Home extends React.Component
{
    render()
    {
        return <h1>Home Component</h1>;
    }
}
```

---

# Difference Between Components and JavaScript Functions

| React Component | JavaScript Function |
|-----------------|---------------------|
| Returns JSX | Returns any JavaScript value |
| Used to create UI | Used for calculations and logic |
| Can maintain state | Cannot maintain React state directly |
| Rendered inside React | Executed normally |

---

# Constructor

The constructor is a special method in a class component.

Purpose:

- Initializes component state.
- Executes before rendering.
- Calls super(props).

Example:

```jsx
constructor(props)
{
    super(props);
}
```

---

# render() Function

The render() method returns the JSX that should be displayed on the browser.

Every class component must contain a render() method.

Example:

```jsx
render()
{
    return(
        <h1>Hello React</h1>
    );
}
```

---

# Procedure

## Step 1

Create a new React project.

```bash
npx create-react-app StudentApp
```

---

## Step 2

Navigate into the project.

```bash
cd StudentApp
```

---

## Step 3

Open the project in Visual Studio Code.

```bash
code .
```

---

## Step 4

Inside the **src** folder, create a new folder named:

```
Components
```

---

## Step 5

Create the following component files inside the Components folder.

```
Home.js
About.js
Contact.js
```

---

## Step 6

Create **Home.js**

Displays the message:

```
Welcome to the Home page of Student Management Portal
```

---

## Step 7

Create **About.js**

Displays the message:

```
Welcome to the About page of Student Management Portal
```

---

## Step 8

Create **Contact.js**

Displays the message:

```
Welcome to the Contact page of Student Management Portal
```

---

## Step 9

Modify **App.js** to import and render all three components.

---

## Step 10

Run the application.

```bash
npm start
```

---

## Step 11

Open the browser.

```
http://localhost:3000
```

---

# Components Created

## Home Component

Displays:

```
Welcome to the Home page of Student Management Portal
```

---

## About Component

Displays:

```
Welcome to the About page of Student Management Portal
```

---

## Contact Component

Displays:

```
Welcome to the Contact page of Student Management Portal
```

---

# Project Structure

```
StudentApp

│── node_modules
│── public
│── src
│     │── Components
│     │      ├── Home.js
│     │      ├── About.js
│     │      └── Contact.js
│     │
│     ├── App.js
│     ├── index.js
│     ├── App.css
│     └── ...
│
│── package.json
│── package-lock.json
│── README.md
```

---

# Commands Used

```bash
npx create-react-app StudentApp

cd StudentApp

code .

npm start
```

---

# Files Created

```
src/
    Components/
        Home.js
        About.js
        Contact.js

App.js
```

---

# Output

The browser displays the following messages:

```
Welcome to the Home page of Student Management Portal

Welcome to the About page of Student Management Portal

Welcome to the Contact page of Student Management Portal
```

---

# Advantages of React Components

- Reusable
- Easy to Maintain
- Modular Design
- Better Code Organization
- Faster Development
- Improves Readability

---

# Applications

- Student Management Systems
- Hospital Management Systems
- E-Commerce Websites
- Banking Applications
- Employee Management Systems
- Social Media Applications

---

# Result

Successfully created a React application named **StudentApp** and implemented multiple React components (**Home**, **About**, and **Contact**). The components were rendered through **App.js**, displaying the respective messages in the browser. This experiment demonstrated the creation and rendering of React components and introduced the concepts of function components, class components, constructors, and the render() method.
