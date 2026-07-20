# React Lab 4 - React Component Lifecycle Methods

## Aim

To create a React application named **blogapp** that demonstrates the React Component Lifecycle methods by fetching blog posts from an online API using **componentDidMount()** and handling errors using **componentDidCatch()**.

---

## Objectives

- Understand the need for Component Lifecycle methods.
- Learn the benefits of React Lifecycle methods.
- Understand the rendering sequence of React Components.
- Implement `componentDidMount()`.
- Implement `componentDidCatch()`.
- Fetch data using the Fetch API.
- Display fetched data in a React application.

---

## Software Requirements

- Node.js
- npm (Node Package Manager)
- Visual Studio Code
- React

---

## Project Name

**blogapp**

---

## Folder Structure

```
blogapp
│
├── public
├── src
│   ├── App.js
│   ├── Posts.js
│   ├── Post.js
│   ├── index.js
│   ├── App.css
│   └── index.css
│
├── package.json
└── README.md
```

---

## Steps Performed

### Step 1: Create the React Application

Created a new React project using Create React App.

```bash
npx create-react-app blogapp
```

---

### Step 2: Navigate to the Project Folder

```bash
cd blogapp
```

---

### Step 3: Open the Project

Opened the project in Visual Studio Code.

---

### Step 4: Create Post Class

Created a file named **Post.js** inside the **src** folder.

Defined a `Post` class containing:

- Id
- Title
- Body

---

### Step 5: Create Posts Component

Created a class component named **Posts** inside **Posts.js**.

Initialized the component state using the constructor.

```javascript
this.state = {
    posts: []
};
```

---

### Step 6: Create loadPosts() Method

Created a method named `loadPosts()`.

Used the Fetch API to retrieve posts from:

```
https://jsonplaceholder.typicode.com/posts
```

Stored the fetched posts into the component state.

---

### Step 7: Implement componentDidMount()

Implemented the `componentDidMount()` lifecycle method.

Called the `loadPosts()` method after the component was mounted.

This automatically loads all blog posts when the application starts.

---

### Step 8: Implement render()

Displayed all fetched posts using:

- Heading (`<h3>`)
- Paragraph (`<p>`)

Used the `map()` function to display each post.

---

### Step 9: Implement componentDidCatch()

Implemented `componentDidCatch()` to handle runtime errors.

Displayed the error using an alert message and logged the error information in the browser console.

---

### Step 10: Modify App.js

Imported the **Posts** component into **App.js**.

Rendered the component.

---

### Step 11: Run the Application

Executed the application using:

```bash
npm start
```

---

### Step 12: View Output

Opened the browser.

```
http://localhost:3000
```

The application displayed all blog posts fetched from the online API.

---

## Features Implemented

- React Class Component
- Constructor
- State Management
- Fetch API
- componentDidMount()
- componentDidCatch()
- Render Method
- List Rendering using map()
- Error Handling
- API Integration

---

## Output

The application displays:

- Blog Posts heading
- Blog Title
- Blog Content (Body)

The posts are fetched dynamically from:

```
https://jsonplaceholder.typicode.com/posts
```

If any runtime error occurs, an alert message is displayed using `componentDidCatch()`.

---

## Result

Successfully created a React application named **blogapp** that demonstrates React Component Lifecycle methods. The application fetches blog posts using the Fetch API in `componentDidMount()`, displays them dynamically, and handles runtime errors using `componentDidCatch()`.
