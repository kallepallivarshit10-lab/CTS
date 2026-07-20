# React Lab 9 - ES6 Features in React

## Aim

To create a React application named **cricketapp** that demonstrates the use of various ES6 features such as **map(), filter(), arrow functions, destructuring, spread operator (merge), and conditional rendering** in React.

---

# Objectives

- Understand the features of ES6.
- Learn JavaScript `let` and `const`.
- Understand the difference between `var` and `let`.
- Learn ES6 arrow functions.
- Understand ES6 classes and inheritance.
- Learn the use of `map()` and `filter()`.
- Implement array destructuring.
- Merge arrays using the spread operator.

---

# Software Requirements

- Node.js
- npm (Node Package Manager)
- Visual Studio Code
- React

---

# Project Name

**cricketapp**

---

# Folder Structure

```
cricketapp
│
├── public
├── src
│   ├── Components
│   │   ├── ListofPlayers.js
│   │   └── IndianPlayers.js
│   │
│   ├── App.js
│   ├── index.js
│   └── App.css
│
├── package.json
└── README.md
```

---

# Steps Performed

## Step 1: Create React Application

Created a new React application using Create React App.

```bash
npx create-react-app cricketapp
```

---

## Step 2: Navigate to Project Folder

```bash
cd cricketapp
```

---

## Step 3: Open Project

Opened the project in Visual Studio Code.

---

## Step 4: Create Components

Created a folder named **Components** inside the **src** folder.

Created the following components:

- ListofPlayers.js
- IndianPlayers.js

---

## Step 5: Implement ListofPlayers Component

Created an array containing details of 11 cricket players.

Each player contains:

- Name
- Score

Used the **map()** function to display all players.

Used the **filter()** method along with **arrow functions** to display only players whose scores are below 70.

---

## Step 6: Implement IndianPlayers Component

Created an array of Indian team players.

Used **Array Destructuring** to separate players into:

- Odd Team Players
- Even Team Players

Created two separate arrays:

- T20 Players
- Ranji Trophy Players

Merged both arrays using the **Spread Operator (...)**.

Displayed the merged player list using the **map()** method.

---

## Step 7: Modify App.js

Imported both components into **App.js**.

Used a **flag variable** with an **if-else** statement for conditional rendering.

- When `flag = true`, the ListofPlayers component is displayed.
- When `flag = false`, the IndianPlayers component is displayed.

---

## Step 8: Run the Application

Executed the application using:

```bash
npm start
```

---

## Step 9: View Output

Opened the browser.

```
http://localhost:3000
```

Observed the output based on the value of the flag variable.

---

# ES6 Features Implemented

- let
- const
- map()
- filter()
- Arrow Functions
- Array Destructuring
- Spread Operator (...)
- Conditional Rendering
- Functional Components

---

# Output

### When `flag = true`

The application displays:

- List of all cricket players
- Players whose scores are below 70

---

### When `flag = false`

The application displays:

- Odd Team Players
- Even Team Players
- Merged list of T20 Players and Ranji Trophy Players

---

# Result

Successfully created a React application named **cricketapp** demonstrating various ES6 features such as **map(), filter(), arrow functions, destructuring, spread operator, and conditional rendering**. The application successfully displayed player details based on the specified conditions.
