# 🧰 InventoryManager

**Inventory Manager** is a simple console-based C# application designed to simulate an inventory system for games or applications. It supports modular item types, object-oriented architecture, and a navigable inventory grid. The system showcases key software development principles including **abstraction**, **inheritance**, **interfaces**, and **structured code design**.

---

## ⚙️ Features

- **Inventory Grid System**  
  Displays a 2D inventory with slots where items can be added, removed, or highlighted.

- **Object-Oriented Item Design**  
  Each item type (e.g., `GoldenSword`, `HealthPotion`) is a separate class implementing shared behaviors via interfaces and inheritance.

- **Interfaces & Abstraction**  
  Common behaviors are defined through interfaces, enabling flexible and extensible item creation.

- **Console UI Navigation**  
  Users can navigate the grid and interact with slots using a simple console-based interface.

- **Modular Design**  
  New items can be added easily by creating a new class under the `Item` folder and implementing necessary interfaces.

---

## 🧪 How It Works

- The `Inventory` class manages grid dimensions (`Width`, `Height`) and tracks the selected slot via `CurrentSlotId`.
- The `Init()` method renders the grid and marks the current slot with an `"X"`.
- Item logic (e.g., damage, healing, stats) is encapsulated in individual classes like `ManaPotion` or `IronArmor`.
- Items are managed in `StoredItems.cs`, using collections to store active inventory.
- `Menu.cs` handles user interaction, slot navigation, and item operations.

---

## 🛠️ Technologies Used

- **Language:** C#
- **IDE:** Visual Studio
- **Framework:** .NET Core / .NET 6
- **Principles:** Encapsulation, Inheritance, Polymorphism, Abstraction
- **Data Structures:** Lists, Classes, Interfaces
