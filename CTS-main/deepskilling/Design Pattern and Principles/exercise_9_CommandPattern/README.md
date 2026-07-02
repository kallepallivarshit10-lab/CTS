# Exercise 9: Implementing the Command Pattern

## Aim

To implement the Command Design Pattern for controlling devices in a home automation system.

---

## Scenario

A home automation system needs to issue commands to turn devices on and off. The Command Pattern encapsulates requests as objects and separates the invoker from the receiver.

---

## Classes Created

### Command Interface

- Command.java

Defines:

```java
execute()
```

---

### Receiver Class

- Light.java

Contains:

- turnOn()
- turnOff()

---

### Concrete Commands

- LightOnCommand.java
- LightOffCommand.java

Implement the execute() method and invoke the corresponding operations on Light.

---

### Invoker Class

- RemoteControl.java

Stores a Command object and executes it through pressButton().

---

### Test Class

- CommandTest.java

Demonstrates turning the light on and off using RemoteControl.

---

## Working

1. Create a Light object.
2. Create command objects.
3. Assign commands to RemoteControl.
4. Press the button.
5. The command invokes the corresponding operation on Light.

---

## Expected Output

```
Light is ON
Light is OFF
```

---

## Result

Successfully implemented the Command Design Pattern for a home automation system.

---

## Design Pattern Used

Command Pattern (Behavioral Design Pattern)

---


- LightOffCommand.java
- RemoteControl.java
- CommandTest.java
