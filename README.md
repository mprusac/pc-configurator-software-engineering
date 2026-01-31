# Software for PC Component Selection and Assembly

This project was developed as part of the **Software Engineering** course.  
The goal of the application is to support customers and employees of an IT equipment store
in selecting compatible computer components and assembling complete PC configurations.

The system provides an interactive and automated way of configuring computers,
reducing human errors, improving customer experience, and increasing operational efficiency.

---

## 📌 Problem Description

Customers often lack sufficient technical knowledge to choose compatible PC components,
which can lead to incorrect purchases, product returns, and dissatisfaction.
At the same time, employees spend significant time manually advising customers.

This application addresses these issues by:
- Ensuring **component compatibility**
- Supporting **predefined and custom PC configurations**
- Automating parts of the **purchase and validation process**

---

## ⚙️ Key Features

### Employee Features
- Manage a catalog of computer components (CPU, motherboard, GPU, RAM, PSU, etc.)
- Define compatibility relationships between components
- Create predefined PC configurations (e.g. Gaming PC, Office PC, Workstation)
- Review and validate customer-created configurations

### Customer Features
- Browse predefined PC configurations
- Create custom PC configurations with guided compatibility checks
- View detailed specifications and prices of selected components
- See total configuration price
- Generate a printable configuration summary
- Send configuration to store employees for purchase confirmation

---

## 🧩 Implemented Use Cases

### Use Case 1: Component Management (Database-Oriented)
- Create, read, update and delete components in the database
- Search and filter components by category and specifications
- Define compatibility constraints between components

### Use Case 2: PC Configuration and Validation
- Interactive PC configuration process
- Real-time compatibility validation
- Price calculation and configuration summary
- Sending configuration data to employees for review

Both use cases involve non-trivial interaction between multiple entities
and database operations.

---

## 🗄️ Database

- Centralized database provided by the course infrastructure
- Data access implemented using concepts shown in laboratory exercises
- Supports structured storage of components, compatibility rules and configurations

---

## 🖥️ Technologies Used

- Programming Language: C#
- Framework: .NET (Visual Studio Solution)
- Database: Course-provided relational database
- Data Access: DbLayer / custom data access layer
- Version Control: Git & GitHub

---

## 📂 Project Structure

