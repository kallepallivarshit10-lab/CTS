# Blogger App - React

##  Project Overview

**Blogger App** is a React-based web application developed as part of a hands-on lab experiment.

The main objective of this experiment is to understand different ways of **Conditional Rendering in React**, rendering multiple components, list components, keys, and the use of the React `map()` function.

The application consists of three major components:

1. Book Details
2. Blog Details
3. Course Details

Each component displays information dynamically using React concepts.

---

#  Objectives

The objectives of this experiment are:

- To understand various ways of conditional rendering in React.
- To learn how to render multiple components.
- To understand list components in React applications.
- To understand the importance of keys in React.
- To learn how to extract components with keys.
- To understand React Map and the `map()` function.
- To implement conditional rendering in React applications.

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

# 📂 Project Structure

```
bloggerapp
│
├── public
│
├── src
│   │
│   ├── App.js
│   ├── App.css
│   ├── BookDetails.js
│   ├── BlogDetails.js
│   ├── CourseDetails.js
│   └── index.js
│
├── package.json
│
└── README.md
```

---

# 📖 Application Description

The Blogger App contains three different components:

## 1. Book Details Component

This component displays information about different books.

Features:

- Displays multiple books.
- Uses React list rendering.
- Uses `map()` function to display book data.
- Uses keys for identifying list items.

Example:

```
Book Details

Artificial Intelligence
Author: Russell Norvig

Clean Code
Author: Robert Martin

Java Programming
Author: Herbert Schildt
```

---

## 2. Blog Details Component

This component demonstrates conditional rendering.

Features:

- Checks whether blogs are available.
- Displays different messages based on conditions.

Example:

```
Latest blogs are available.
```

or

```
No blogs available.
```

---

## 3. Course Details Component

This component displays available courses.

Features:

- Uses list components.
- Uses array data.
- Uses `map()` function.
- Uses unique keys for every item.

Example:

```
Course Details

React JS - 2 Months

Python Programming - 3 Months

Data Science - 6 Months
```

---

# ⚛️ Concepts Learned

## 1. Conditional Rendering in React

Conditional rendering allows React applications to display different UI elements based on conditions.

React provides multiple ways to implement conditional rendering.

---

## Method 1: If-Else Rendering

Using normal JavaScript conditions.

Example:

```javascript
if(condition)
{
    component
}
else
{
    anotherComponent
}
```

Based on the condition, React decides which component should be displayed.

---

## Method 2: Ternary Operator

The ternary operator is used for simple conditional rendering.

Syntax:

```javascript
condition ? trueExpression : falseExpression
```

Example:

```javascript
isAvailable ?

<p>Blogs Available</p>

:

<p>No Blogs Available</p>
```

---

## Method 3: Logical AND Operator

The `&&` operator renders a component only when the condition is true.

Example:

```javascript
showBook && <BookDetails/>
```

If `showBook` is true, the Book Details component is displayed.

---

#  Rendering Multiple Components

React allows multiple components to be displayed together.

In this application:

```javascript
<BookDetails/>

<BlogDetails/>

<CourseDetails/>
```

Three independent components are rendered inside the main App component.

---

# 📋 List Components in React

A list component displays multiple similar items.

Example:

Book list:

```
Artificial Intelligence
Clean Code
Java Programming
```

Course list:

```
React JS
Python Programming
Data Science
```

Lists are created using arrays and rendered using the `map()` function.

---
#  Keys in React

Keys are special attributes used by React to identify elements in a list.

Example:

```javascript
<div key={book.id}>
```

## Importance of Keys:

- Helps React identify list items uniquely.
- Improves rendering performance.
- Helps React update only required elements.
- Prevents duplicate rendering issues.

---

#  Extracting Components with Keys

Instead of writing all code in one file, components are separated into individual files.

Example:

```
BookDetails.js

BlogDetails.js

CourseDetails.js
```

Benefits:

- Improves code organization.
- Makes components reusable.
- Makes debugging easier.

---

#  React map() Function

The JavaScript `map()` function is used in React to iterate through arrays and create UI elements.

Example:

```javascript
books.map((book)=>(
    <h3>{book.name}</h3>
))
```

The `map()` function converts array data into React components.

---

#  Application Flow

```
             Application Starts
                    |
                    |
              App Component
                    |
        -------------------------
        |           |           |
        |           |           |
     Books       Blogs      Courses
        |           |           |
        |           |           |
 Conditional   Conditional   List Rendering
 Rendering     Rendering      using map()
```

---

#  How to Run the Application

## Step 1: Clone Repository

```bash
git clone <repository-url>
```

---

## Step 2: Navigate to Project Folder

```bash
cd bloggerapp
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

#  Output

The application displays:

### Book Details

- List of books with authors.

### Blog Details

- Blog availability message based on condition.

### Course Details

- List of available courses with duration.

---

# 📝 Learning Outcomes

After completing this experiment, I learned:

 Different methods of conditional rendering in React.

 How to render multiple components.

 How to create list components.

 How keys improve React list rendering.

 How to extract reusable components.

 How to use JavaScript `map()` function in React.

 How React dynamically updates the user interface.

---

#  Future Enhancements

The application can be improved by adding:

- User login authentication.
- Database connectivity.
- Search functionality.
- Blog creation and editing features.
- Course enrollment system.
- Backend API integration.

---

#  Conclusion

This hands-on lab helped me understand important React concepts such as:

- Conditional Rendering
- Multiple Component Rendering
- List Components
- Keys
- Component Extraction
- React `map()` Function

By developing the Blogger App, I gained practical experience in building dynamic and reusable React applications.

---
