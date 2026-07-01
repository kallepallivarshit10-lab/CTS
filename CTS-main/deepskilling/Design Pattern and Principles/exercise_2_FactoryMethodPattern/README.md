# Exercise 2: Implementing the Factory Method Pattern

## Aim

To implement the Factory Method Design Pattern for creating different types of documents such as Word, PDF, and Excel documents.

---

## Scenario

A document management system needs to create various document types without exposing the object creation logic to the client. The Factory Method Pattern helps achieve this by delegating object creation to specialized factory classes.

---

## Classes Created

### Document Interface

- Document.java

Defines the common operation:

- open()

### Concrete Document Classes

- WordDocument.java
- PdfDocument.java
- ExcelDocument.java

These classes implement the Document interface and provide their own implementation of the `open()` method.

### Abstract Factory

- DocumentFactory.java

Contains the abstract method:

```java
createDocument()
```

### Concrete Factory Classes

- WordDocumentFactory.java
- PdfDocumentFactory.java
- ExcelDocumentFactory.java

These classes extend `DocumentFactory` and create their respective document objects.

### Test Class

- FactoryTest.java

Demonstrates the creation and usage of different document types through the Factory Method Pattern.

---

## Working

1. Create the appropriate factory object.
2. Call `createDocument()`.
3. The factory creates the required document object.
4. Invoke the `open()` method on the document.

---

## Expected Output

```
Opening Word Document
Opening PDF Document
Opening Excel Document
```

---

## Result

Successfully implemented the Factory Method Design Pattern to create different document types using separate factory classes.

---

## Design Pattern Used

Factory Method Pattern (Creational Design Pattern)

---

## Files Included

- Document.java
- WordDocument.java
- PdfDocument.java
- ExcelDocument.java
- DocumentFactory.java
- WordDocumentFactory.java
- PdfDocumentFactory.java
- ExcelDocumentFactory.java
- FactoryTest.java