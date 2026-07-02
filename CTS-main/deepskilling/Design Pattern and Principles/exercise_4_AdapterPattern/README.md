# Exercise 4: Implementing the Adapter Pattern

## Aim

To implement the Adapter Design Pattern for integrating different third-party payment gateways with a common interface.

---

## Scenario

A payment processing system needs to work with multiple payment gateways such as PayPal and Stripe, each having different interfaces. The Adapter Pattern helps provide a common interface for payment processing.

---

## Classes Created

### Target Interface

- PaymentProcessor.java

Defines:

```java
processPayment()
```

---

### Adaptee Classes

- PayPalGateway.java
- StripeGateway.java

These classes contain their own payment methods:

- sendPayment()
- makePayment()

---

### Adapter Classes

- PayPalAdapter.java
- StripeAdapter.java

These classes implement PaymentProcessor and translate calls to the corresponding gateway-specific methods.

---

### Test Class

- AdapterTest.java

Demonstrates payment processing using different adapters.

---

## Working

1. Create the required gateway object.
2. Wrap it inside its adapter.
3. Call processPayment().
4. Adapter internally invokes the gateway-specific method.

---

## Expected Output

```
Payment of Rs.5000.0 processed through PayPal.
Payment of Rs.10000.0 processed through Stripe.
```

---

## Result

Successfully implemented the Adapter Design Pattern to integrate multiple payment gateways using a common interface.

---

## Design Pattern Used

Adapter Pattern (Structural Design Pattern)

---

## Files Included

- PaymentProcessor.java
- PayPalGateway.java
- StripeGateway.java
- PayPalAdapter.java
- StripeAdapter.java
- AdapterTest.java
