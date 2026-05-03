# 🧱 Design Patterns & SOLID Principles in C#

A complete reference and practical implementation of all **5 SOLID Principles** and all **23 Gang of Four (GoF) Design Patterns** using C#. Built for learning, revision, and use as a personal reference guide.

---

## 📐 SOLID Principles

| # | Principle | Description |
|---|-----------|-------------|
| S | **Single Responsibility** | A class should have only one reason to change |
| O | **Open/Closed** | Open for extension, closed for modification |
| L | **Liskov Substitution** | Subtypes must be substitutable for their base types |
| I | **Interface Segregation** | Clients should not depend on interfaces they don't use |
| D | **Dependency Inversion** | Depend on abstractions, not concretions |

---

## 🎨 Design Patterns

### Creational Patterns
> Deal with object creation mechanisms

| Pattern | Intent |
|---------|--------|
| **Singleton** | Ensure a class has only one instance |
| **Factory Method** | Define an interface for creating objects, let subclasses decide which class to instantiate |
| **Abstract Factory** | Create families of related objects without specifying their concrete classes |
| **Builder** | Construct complex objects step by step |
| **Prototype** | Clone existing objects without coupling to their classes |

### Structural Patterns
> Deal with object composition and relationships

| Pattern | Intent |
|---------|--------|
| **Adapter** | Convert an interface into another interface clients expect |
| **Bridge** | Separate abstraction from its implementation |
| **Composite** | Compose objects into tree structures to represent part-whole hierarchies |
| **Decorator** | Attach additional responsibilities to an object dynamically |
| **Facade** | Provide a simplified interface to a complex subsystem |
| **Flyweight** | Use sharing to support a large number of fine-grained objects efficiently |
| **Proxy** | Provide a surrogate or placeholder for another object |

### Behavioral Patterns
> Deal with communication and responsibility between objects

| Pattern | Intent |
|---------|--------|
| **Chain of Responsibility** | Pass requests along a chain of handlers |
| **Command** | Encapsulate a request as an object |
| **Interpreter** | Define a grammar and provide an interpreter for it |
| **Iterator** | Access elements of a collection sequentially without exposing its structure |
| **Mediator** | Define an object that encapsulates how objects interact |
| **Memento** | Capture and restore an object's internal state |
| **Observer** | Define a one-to-many dependency between objects |
| **State** | Allow an object to alter its behavior when its internal state changes |
| **Strategy** | Define a family of algorithms and make them interchangeable |
| **Template Method** | Define the skeleton of an algorithm, deferring some steps to subclasses |
| **Visitor** | Separate an algorithm from the object structure it operates on |

---

## 📁 Project Structure

```
DesignPatterns-SOLID-CSharp/
├── SOLID/
│   ├── SingleResponsibility/
│   ├── OpenClosed/
│   ├── LiskovSubstitution/
│   ├── InterfaceSegregation/
│   └── DependencyInversion/
├── Creational/
│   ├── Singleton/
│   ├── FactoryMethod/
│   ├── AbstractFactory/
│   ├── Builder/
│   └── Prototype/
├── Structural/
│   ├── Adapter/
│   ├── Bridge/
│   ├── Composite/
│   ├── Decorator/
│   ├── Facade/
│   ├── Flyweight/
│   └── Proxy/
├── Behavioral/
│   ├── ChainOfResponsibility/
│   ├── Command/
│   ├── Interpreter/
│   ├── Iterator/
│   ├── Mediator/
│   ├── Memento/
│   ├── Observer/
│   ├── State/
│   ├── Strategy/
│   ├── TemplateMethod/
│   └── Visitor/
└── README.md
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- Any C# IDE — Visual Studio, Visual Studio Code, or Rider

### Run a Pattern

```bash
# Clone the repository
git clone https://github.com/khairyazedan/Design-Patterns-SOLID-Principles-C-Sharp.git

# Navigate to a pattern folder
cd Creational/Singleton

# Run it
dotnet run
```

---

## 💡 Why This Repo?

Understanding Design Patterns and SOLID Principles is essential for writing:
- **Maintainable** code that is easy to change
- **Scalable** code that grows without breaking
- **Readable** code that other developers can understand
- **Testable** code with clear separation of concerns

These patterns are language-agnostic concepts — this repo demonstrates them concretely in C#.

---

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET 6+
- **IDE:** Visual Studio / VS Code

---

## 📚 Resources

- [Refactoring Guru — Design Patterns](https://refactoring.guru/design-patterns)
- [Refactoring Guru — SOLID Principles](https://refactoring.guru/solid)
- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).
