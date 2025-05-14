# Lab1 — Principles of Software Design in C#

This project demonstrates multiple software design principles using a small inventory system with products and warehouse operations.

## ✅ Applied Programming Principles

---

### 1. DRY (Don't Repeat Yourself)
Avoided code duplication by extracting reusable logic into classes like `Product`, `Warehouse`, and `Reporting`.

**Example:**
- [`Classes/Warehouse.cs`](./Classes/Warehouse.cs) — methods `Incoming` and `Outgoing` are reused without code duplication.
- [`Interfaces/IProduct.cs`](./Interfaces/IProduct.cs) — shared interface for any product type.

---

### 2. KISS (Keep It Simple, Stupid)
Each class has a single, simple responsibility and clear method names.

**Example:**
- [`Program.cs`](./Program.cs) — the main method clearly shows flow without overcomplication.
- Simple property logic in [`Classes/Product.cs`](./Classes/Product.cs)

---

### 3. S — Single Responsibility Principle
Each class has **one reason to change**.

- `Product` handles product logic ([`Classes/Product.cs`](./Classes/Product.cs))
- `Warehouse` manages stock entries ([`Classes/Warehouse.cs`](./Classes/Warehouse.cs))
- `Reporting` is for output only ([`Classes/Reporting.cs`](./Classes/Reporting.cs))

---

### 4. O — Open/Closed Principle
New types of `IProduct` can be added without modifying existing logic — just implement the interface.

**Example:**
- [`Interfaces/IProduct.cs`](./Interfaces/IProduct.cs)
- Any class implementing `IProduct` works with `Warehouse`, `Reporting`.

---

### 5. L — Liskov Substitution Principle
`Product` (a class) can be used wherever `IProduct` (an interface) is expected.

**Example:**
- [`Program.cs`](./Program.cs#L11) — uses `IProduct`, but assigns `Product`.

---

### 6. I — Interface Segregation Principle
`IProduct` contains only the necessary methods and properties related to products — no excess.

**Example:**
- [`Interfaces/IProduct.cs`](./Interfaces/IProduct.cs)

---

### 7. D — Dependency Inversion Principle
High-level modules depend on abstractions, not concrete classes.

**Example:**
- [`Warehouse`](./Classes/Warehouse.cs) works with `IProduct`, not `Product`.

---

### 8. YAGNI (You Ain’t Gonna Need It)
No extra classes, methods or features were added unless directly needed for the lab.

---

### 9. Composition Over Inheritance
Rather than subclassing, behavior is composed using interfaces and delegation.

**Example:**
- `Warehouse` composes `IProduct`, doesn't inherit from it.

---

### 10. Program to Interfaces, Not Implementations
All logic is built around `IProduct`, not the concrete `Product` class.

**Example:**
- [`Program.cs`](./Program.cs#L11-L20)

---

### 11. Fail Fast
Simple validation can be added to ensure methods fail early (e.g., preventing negative quantities).

> See future work: consider adding validation in `Product.ReducePrice()` or `Warehouse.Outgoing()`.

---

## 🔗 Notes

You can click any file or line to view code details directly in your IDE or Git viewer.

