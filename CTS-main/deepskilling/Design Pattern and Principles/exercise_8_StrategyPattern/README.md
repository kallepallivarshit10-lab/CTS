# Exercise 8: Implementing the Strategy Pattern

## Aim

To implement the Strategy Design Pattern for supporting multiple payment methods that can be selected dynamically at runtime.

---

## Scenario

A payment system supports different payment methods such as Credit Card and PayPal. The Strategy Pattern allows switching between payment algorithms without modifying the client code.

---

## Classes Created

### Strategy Interface

- PaymentStrategy.java

Defines:

```java
pay(double amount)
```

---

### Concrete Strategies

- CreditCardPayment.java
- PayPalPayment.java

Provide implementations for different payment methods.

---

### Context Class

- PaymentContext.java

Maintains a reference to PaymentStrategy and executes the selected strategy.

---

### Test Class

- StrategyTest.java

Demonstrates runtime selection of payment methods.

---

## Working

1. Create a payment strategy.
2. Pass it to PaymentContext.
3. Call executePayment().
4. Context delegates the payment to the selected strategy.

---

## Expected Output

```
Paid Rs.5000.0 using Credit Card
Paid Rs.10000.0 using PayPal
```

---

## Result

Successfully implemented the Strategy Design Pattern for supporting multiple payment methods dynamically.

---

## Design Pattern Used

Strategy Pattern (Behavioral Design Pattern)

---
