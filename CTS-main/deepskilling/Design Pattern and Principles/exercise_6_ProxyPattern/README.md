# Exercise 6: Implementing the Proxy Pattern

## Aim

To implement the Proxy Design Pattern for image loading with lazy initialization and caching.

---

## Scenario

An image viewer application loads images from a remote server. Since loading images is expensive, the Proxy Pattern is used to delay object creation until required and reuse the loaded image.

---

## Classes Created

### Subject Interface

- Image.java

Defines:

```java
display()
```

---

### Real Subject

- RealImage.java

Represents the actual image object and loads the image from the remote server.

---

### Proxy Class

- ProxyImage.java

Implements lazy initialization and caching by maintaining a reference to RealImage.

---

### Test Class

- ProxyTest.java

Demonstrates image loading and displaying through ProxyImage.

---

## Working

1. Create a ProxyImage object.
2. No image is loaded initially.
3. When display() is called for the first time, RealImage is created.
4. Image is loaded from the remote server.
5. Subsequent calls reuse the existing image.

---

## Expected Output

```
Image object created.

First display:
Loading nature.jpg from remote server...
Displaying nature.jpg

Second display:
Displaying nature.jpg
```

---

## Result

Successfully implemented the Proxy Design Pattern with lazy initialization and caching.

---

## Design Pattern Used

Proxy Pattern (Structural Design Pattern)

---
