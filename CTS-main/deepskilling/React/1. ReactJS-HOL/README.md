# React Lab 1
# Creating Your First React Application

## Aim

To create a React application named **myfirstreact** and display the heading **"Welcome to the first session of React"** in the browser.

---

# Objectives

- Understand the concept of Single Page Application (SPA).
- Learn about React and its working.
- Understand the differences between SPA and MPA.
- Learn the advantages and disadvantages of SPA.
- Understand the concept of Virtual DOM.
- Learn the features of React.
- Set up the React development environment.
- Create and run the first React application using Create React App.

---

# Software Requirements

- Node.js
- npm (Node Package Manager)
- Visual Studio Code
- Google Chrome / Microsoft Edge

---

# Prerequisites

Before starting the experiment, install the following:

- Node.js
- npm
- Visual Studio Code

Verify installation using:

```bash
node -v
npm -v
```

---

# React Concepts

## What is React?

React is an open-source JavaScript library developed by Meta (Facebook) for building fast and interactive user interfaces using reusable components.

---

## What is SPA?

A Single Page Application (SPA) loads only one HTML page and dynamically updates the content without refreshing the entire page.

Examples:

- Gmail
- Facebook
- Instagram
- Netflix

---

## SPA vs MPA

| SPA | MPA |
|------|------|
| Loads one page | Loads multiple pages |
| No page refresh | Entire page refreshes |
| Faster | Comparatively slower |
| Better user experience | Traditional navigation |
| Uses React, Angular | Uses ASP.NET, PHP, JSP |

---

## Advantages of SPA

- Faster page loading
- Better user experience
- Less server communication
- Smooth navigation
- Dynamic content updates

---

## Disadvantages of SPA

- Initial loading time is higher
- SEO is comparatively difficult
- JavaScript must be enabled
- Large applications require optimization

---

## Virtual DOM

Virtual DOM is a lightweight copy of the Real DOM.

Instead of updating the entire webpage, React compares the old Virtual DOM with the new Virtual DOM and updates only the modified elements, resulting in faster rendering.

---

## Features of React

- Component-Based Architecture
- Virtual DOM
- JSX
- One-way Data Binding
- High Performance
- Reusable Components
- Easy to Learn
- Fast Rendering

---

# Procedure

## Step 1

Install Node.js and npm from the official website.

https://nodejs.org/

---

## Step 2

Install Create React App.

```bash
npm install -g create-react-app
```

---

## Step 3

Create a React application.

```bash
npx create-react-app myfirstreact
```

---

## Step 4

Navigate to the project folder.

```bash
cd myfirstreact
```

---

## Step 5

Open the project in Visual Studio Code.

```bash
code .
```

---

## Step 6

Open the following file.

```
src/App.js
```

Delete the existing code.

---

## Step 7

Replace it with the following code.

```jsx
function App() {
  return (
    <div>
      <h1>Welcome to the first session of React</h1>
    </div>
  );
}

export default App;
```

---

## Step 8

Run the React application.

```bash
npm start
```

---

## Step 9

Open the browser.

```
http://localhost:3000
```

---

# Output

The browser displays the following heading:

```
Welcome to the first session of React
```

---

# Project Structure

```
myfirstreact

│── node_modules
│── public
│── src
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
npm install -g create-react-app

npx create-react-app myfirstreact

cd myfirstreact

code .

npm start
```

---

# Files Modified

## App.js

Updated the default React component to display the heading:

```
Welcome to the first session of React
```

---

# Result

Successfully created a React application named **myfirstreact**, configured the React environment, executed the application, and displayed the heading **"Welcome to the first session of React"** in the browser. The experiment also demonstrated the basic concepts of React, Single Page Applications (SPA), Virtual DOM, and the process of creating and running a React application using Create React App.
