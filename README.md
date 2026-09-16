# 🏦 Bank Management System

A simple **console-based Bank Management System** built with **C#**.

This project was created as a learning project to practice **Object-Oriented Programming (OOP)** concepts in C#, including classes, objects, constructors, inheritance, methods, lists, and code reuse.

---

## 📌 Features

The application provides the following features:

1. **Create Account**
   - Create a normal account
   - Create a savings account
   - Set initial balance
   - Set interest rate for savings accounts
   - Prevent duplicate account numbers

2. **Deposit Money**
   - Deposit money into an existing account
   - Validate the deposit amount

3. **Withdraw Money**
   - Withdraw money from an account
   - Prevent withdrawals greater than the available balance
   - Validate withdrawal amounts

4. **Check Balance**
   - View the current account balance
   - Display account holder name

5. **Transfer Money**
   - Transfer money from one account to another
   - Check sender and receiver accounts
   - Prevent transfers with insufficient balance

6. **Apply Interest**
   - Available for savings accounts
   - Calculate interest based on the account's interest rate
   - Add the interest to the account balance

7. **Account Details**
   - Display account number
   - Display account holder name
   - Display account balance

8. **Exit**
   - Exit the application safely

---

## 🛠️ Technologies Used

- **C#**
- **.NET**
- Console Application
- Object-Oriented Programming

---

## 🧱 Project Structure

```text
BankManagementSystem/
│
├── Program.cs
├── Account.cs
├── Bank.cs
├── SavingsAccount.cs
└── README.md
