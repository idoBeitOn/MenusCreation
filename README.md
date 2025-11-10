#  Hierarchical Menu Manager

A **C# console application** that provides a reusable component for managing **hierarchical menus**.  
It demonstrates clean software design principles such as **polymorphism**, **interfaces**, and **delegates**.

---

## 🌟 Overview

This project allows developers to easily:
- Create and manage menus with nested submenus.  
- Handle user input dynamically.  
- Execute actions based on user selections.  

---

## 🚀 Key Features

- **Polymorphism & Interfaces** – Flexible menu handling using OOP principles.  
- **Delegates** – Demonstrates the use of delegates for event-driven behavior.  
- **Dynamic Menu Creation** – Build and manage hierarchical menus using `MainMenu` and `MenuItem` classes.  

---

## 🧱 Project Structure

| Module | Description |
|--------|--------------|
| **Ex04.Menus.Interfaces** | Implements menu handling using interfaces and polymorphism. |
| **Ex04.Menus.Delegates** | Implements menu handling using delegates. |
| **Ex04.Menus.Test** | Example console application demonstrating both approaches. |

---

## 🧩 Example Menu


Main Menu

│

├── Show Date/Time

│ ├── Show Date

│ └── Show Time

│

└── Version and Spaces

├── Show Version

└── Count Spaces




## ⚙️ Functionality

- Navigate between menus and submenus.  
- Execute operations like showing the current date/time or counting spaces in a sentence.  
- Easily extend the system by adding new menu actions.

---

## 💡 Purpose

This project demonstrates Object-Oriented Programming design, showcasing how the same functionality can be implemented using both **interfaces** and **delegates**.
