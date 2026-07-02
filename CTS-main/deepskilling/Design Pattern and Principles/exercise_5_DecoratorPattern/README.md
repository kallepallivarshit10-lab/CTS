# Exercise 5: Implementing the Decorator Pattern

## Aim

To implement the Decorator Design Pattern for dynamically adding multiple notification channels such as Email, SMS, and Slack.

---

## Scenario

A notification system needs to support multiple communication channels. Instead of creating separate classes for every combination, the Decorator Pattern is used to add functionalities dynamically.

---

## Classes Created

### Component Interface

- Notifier.java

Defines:

```java
send(String message)
```

---

### Concrete Component

- EmailNotifier.java

Provides email notification functionality.

---

### Abstract Decorator

- NotifierDecorator.java

Maintains a reference to a Notifier object.

---

### Concrete Decorators

- SMSNotifierDecorator.java
- SlackNotifierDecorator.java

These classes extend the notification functionality dynamically.

---

### Test Class

- DecoratorTest.java

Demonstrates sending notifications through different combinations of channels.

---

## Working

1. Create EmailNotifier.
2. Wrap it with SMSNotifierDecorator.
3. Wrap again with SlackNotifierDecorator.
4. Each decorator adds new behavior.

---

## Expected Output

```
Email Notification:
Sending Email: Hello User

Email + SMS Notification:
Sending Email: Hello User
Sending SMS: Hello User

Email + SMS + Slack Notification:
Sending Email: Hello User
Sending SMS: Hello User
Sending Slack Notification: Hello User
```

---

## Result

Successfully implemented the Decorator Design Pattern to dynamically add notification channels.

---

## Design Pattern Used

Decorator Pattern (Structural Design Pattern)

---
