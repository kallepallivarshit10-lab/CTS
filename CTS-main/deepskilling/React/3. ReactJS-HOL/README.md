# React Lab 3 - Function Component with Styling

## Aim

To create a React application named **scorecalculatorapp** that uses a **Function Component** to calculate and display the average score of a student. The application also demonstrates how to apply CSS styling to React components.

---

## Objectives

- Understand React Function Components.
- Learn the difference between Components and JavaScript Functions.
- Understand different types of React Components.
- Learn Function Components.
- Apply CSS styling to React Components.
- Render components in React.

---

## Software Requirements

- Node.js
- npm (Node Package Manager)
- Visual Studio Code
- React

---

## Project Name

**scorecalculatorapp**

---

## Folder Structure

```
scorecalculatorapp
│
├── public
├── src
│   ├── Components
│   │   └── CalculateScore.js
│   │
│   ├── Stylesheets
│   │   └── mystyle.css
│   │
│   ├── App.js
│   ├── index.js
│   └── App.css
│
├── package.json
└── README.md
```

---

## Steps Performed

### Step 1: Create the React Application

Created a new React application using Create React App.

```bash
npx create-react-app scorecalculatorapp
```

---

### Step 2: Navigate to the Project Folder

```bash
cd scorecalculatorapp
```

---

### Step 3: Create Components Folder

Created a folder named **Components** inside the **src** directory.

Added the file:

```
CalculateScore.js
```

---

### Step 4: Create Stylesheets Folder

Created a folder named **Stylesheets**.

Added the CSS file:

```
mystyle.css
```

---

### Step 5: Develop Function Component

Created a Function Component named **CalculateScore**.

The component:

- Accepts the following properties:
  - Name
  - School
  - Total
  - Goal
- Calculates the average score.
- Displays all student details.

---

### Step 6: Apply CSS Styling

Imported **mystyle.css** inside the component to improve the appearance of the application.

---

### Step 7: Modify App.js

Imported the **CalculateScore** component into **App.js**.

Passed the required values using props.

Rendered the component.

---

### Step 8: Run the Application

Started the React development server.

```bash
npm start
```

---

### Step 9: Open the Browser

Opened

```
http://localhost:3000
```

to view the application.

---

## Features Implemented

- React Function Component
- Props
- JSX
- CSS Styling
- Average Score Calculation
- Component Rendering

---

## Output

The application displays:

- Student Name
- School Name
- Total Marks
- Number of Subjects (Goal)
- Average Score

All details are displayed with CSS styling.

---

## Result

Successfully created a React application named **scorecalculatorapp** using a **Function Component**. The application accepts student details through props, calculates the average score, applies CSS styling, and displays the result successfully.
