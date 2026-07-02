# Exercise 7: Implementing the Observer Pattern

## Aim

To implement the Observer Design Pattern for notifying multiple clients whenever stock prices change.

---

## Scenario

A stock market monitoring system needs to notify multiple clients whenever stock prices are updated. The Observer Pattern enables automatic communication between the stock market and its observers.

---

## Classes Created

### Subject Interface

- Stock.java

Defines:

- registerObserver()
- removeObserver()
- notifyObservers()

---

### Observer Interface

- Observer.java

Defines:

```java
update(double price)
```

---

### Concrete Subject

- StockMarket.java

Maintains a list of observers and notifies them whenever stock prices change.

---

### Concrete Observers

- MobileApp.java
- WebApp.java

Receive stock price updates.

---

### Test Class

- ObserverTest.java

Demonstrates registration and notification of observers.

---

## Working

1. Create observers.
2. Register observers with StockMarket.
3. Change stock price.
4. StockMarket calls notifyObservers().
5. All observers receive updates through update().

---

## Expected Output

```
Stock price changed to 1000
Mobile App: Stock price updated to Rs.1000.0
Web App: Stock price updated to Rs.1000.0

Stock price changed to 1200
Mobile App: Stock price updated to Rs.1200.0
Web App: Stock price updated to Rs.1200.0
```

---

## Result

Successfully implemented the Observer Design Pattern for stock price notifications.

---

## Design Pattern Used

Observer Pattern (Behavioral Design Pattern)

---

- MobileApp.java
- WebApp.java
- ObserverTest.java
