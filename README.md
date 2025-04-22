# InventoryManager
🧰 Inventory Manager
Inventory Manager is a simple console-based C# application designed to simulate an inventory system for games or applications. It supports modular item types, object-oriented architecture, and a navigable inventory grid. The system showcases key software development principles including abstraction, inheritance, interfaces, and structured code design.



⚙️ Features
Inventory Grid System
Displays a 2D inventory with slots where items can be added, removed, or highlighted.

Object-Oriented Item Design
Each item type (e.g., GoldenSword, HealthPotion) is a separate class implementing shared behaviors using interfaces and inheritance.

Interfaces & Abstraction
Shared behaviors between item types are defined using interfaces to allow flexibility and extensibility.

Console UI Navigation
Basic console UI with the ability to show current slots and navigate or highlight the selected slot.

Modular Design
New items can be added easily by creating a new class under the Item folder and implementing necessary interfaces.



🧪 How It Works
The Inventory class manages dimensions (Width, Height) and tracks the current slot using CurrentSlotId.

Init() method renders the grid and visually marks the currently selected slot using an "X".

Item logic (damage, healing, stats) is encapsulated in individual item classes such as ManaPotion or IronArmor.

Items are stored and managed via StoredItems.cs, which may include lists or dictionaries to track added items.

Menu.cs provides interactive options like navigating slots, using items, or viewing inventory contents.



🛠️ Technologies Used
Language: C#

IDE: Visual Studio

Framework: .NET Core / .NET 6 (adjust as applicable)

OOP Principles: Encapsulation, Inheritance, Polymorphism, Abstraction

Data Structures: Lists, Classes, Interfaces
