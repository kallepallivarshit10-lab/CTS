# React Lab – Office Space Rental App using JSX

## Aim

To create a React application named **officespacerentalapp** that demonstrates the use of **JSX**, JavaScript expressions, inline CSS, objects, arrays, and rendering data to the DOM.

---

# Objectives

- Understand JSX in React.
- Learn the basics of ECMAScript (ES6).
- Understand `React.createElement()`.
- Create React elements using JSX.
- Render JSX elements to the DOM.
- Use JavaScript expressions inside JSX.
- Apply inline CSS in JSX.

---

# Software Requirements

- Node.js
- npm (Node Package Manager)
- Visual Studio Code
- React

---

# Project Name

**officespacerentalapp**

---

# Folder Structure

```
officespacerentalapp
│
├── public
├── src
│   ├── App.js
│   ├── index.js
│   ├── App.css
│   └── index.css
│
├── package.json
└── README.md
```

---

# Steps Performed

## Step 1: Create React Application

Created a new React application using Create React App.

```bash
npx create-react-app officespacerentalapp
```

---

## Step 2: Navigate to Project Folder

```bash
cd officespacerentalapp
```

---

## Step 3: Open Project

Opened the project in Visual Studio Code.

---

## Step 4: Modify App.js

Replaced the default code in **App.js** with JSX code to create the Office Space Rental application.

---

## Step 5: Create Heading

Created a heading using JSX.

```jsx
<h1>Office Space Rental App</h1>
```

---

## Step 6: Display Office Image

Added an image using the JSX `<img>` tag.

Used attributes such as:

- src
- alt
- width
- height

---

## Step 7: Create Office Object

Created a JavaScript object containing office details.

The object contains:

- Name
- Rent
- Address

Displayed the object properties using JSX expressions.

---

## Step 8: Create List of Office Objects

Created an array containing multiple office objects.

Each office object contains:

- Name
- Rent
- Address

---

## Step 9: Render Office List

Used the **map()** method to iterate through the array and display all office details dynamically.

---

## Step 10: Apply Inline CSS

Applied inline CSS to display the Rent amount.

Condition used:

- Rent below ₹60,000 → Red
- Rent ₹60,000 and above → Green

Used conditional operator:

```jsx
style={{
color: office.Rent < 60000 ? "red" : "green"
}}
```

---

## Step 11: Run the Application

Executed the application using:

```bash
npm start
```

---

## Step 12: View Output

Opened the browser.

```
http://localhost:3000
```

Observed the Office Space Rental application displaying office details.

---

# JSX Features Implemented

- JSX Elements
- JSX Attributes
- JavaScript Expressions
- Objects
- Arrays of Objects
- map() Function
- Conditional Rendering
- Inline CSS Styling
- Rendering Lists

---

# Output

The application displays:

- Office Space Rental App heading
- Office Image
- Single Office Details
  - Name
  - Rent
  - Address
- List of Office Spaces
- Rent displayed in:
  - **Red** if Rent is below ₹60,000
  - **Green** if Rent is ₹60,000 or above

---

# Concepts Covered

- JSX
- React.createElement()
- JavaScript Expressions in JSX
- Objects
- Arrays
- map()
- Inline CSS
- Conditional Styling
- Rendering JSX to DOM

---

# Result

Successfully created a React application named **officespacerentalapp** using **JSX**. The application displays office space details by rendering objects and arrays, applies conditional inline CSS based on the rent amount, and demonstrates JSX syntax, JavaScript expressions, and dynamic rendering in React.
