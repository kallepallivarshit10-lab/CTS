# Exercise 3: Implementing the Builder Pattern

## Aim

To implement the Builder Design Pattern for constructing complex Computer objects with multiple optional attributes.

---

## Scenario

A system needs to create different configurations of Computer objects with attributes such as CPU, RAM, Storage, Graphics Card, and Operating System. The Builder Pattern helps simplify the object construction process.

---

## Classes Created

### Product Class

- Computer.java

Contains:

- CPU
- RAM
- Storage
- Graphics Card
- Operating System

The constructor is private and receives a Builder object.

---

### Static Nested Builder Class

Inside Computer.java

Provides methods:

- setCPU()
- setRAM()
- setStorage()
- setGraphicsCard()
- setOperatingSystem()

and

```java
build()
```

which returns a Computer object.

---

### Test Class

- BuilderTest.java

Creates different computer configurations using the Builder Pattern.

---

## Working

1. Create a Builder object.
2. Set required attributes.
3. Call build().
4. A Computer object is created.

---

## Expected Output

```
Computer Configuration
----------------------
CPU: Intel i9
RAM: 32GB
Storage: 1TB SSD
Graphics Card: RTX 4090
Operating System: Windows 11

Computer Configuration
----------------------
CPU: Intel i5
RAM: 8GB
Storage: 512GB SSD
Graphics Card: Integrated
Operating System: Windows 10
```

---

## Result

Successfully implemented the Builder Design Pattern to construct different configurations of Computer objects.

---

## Design Pattern Used

Builder Pattern (Creational Design Pattern)

---

## Files Included

- Computer.java
- BuilderTest.java
