This repository contains two foundational applications developed as part of the
Programming with Visual Basic Dot Net course. The projects demonstrate the transition from
structured programming in a text-based environment to event-driven programming using a
Graphical User Interface (GUI).

# Applications Overview
1. Sales Book - Daily Sales &amp; Discount Tracker (Console Application):
This project is a command-line tool focused on the sequence control structure and data
processing logic.

# Key Features:
Uses a Pretest loop (‘Do While’) to repeatedly process user entries while a condition
remains true.
Implements Accumulators to calculate total sales amounts.
Utilizes a Select Case selection structure to determine discount tiers based on a
‘selectorExpression’.
Employs Type Conversion functions (like ‘CDec’ and ‘CInt’) to coerce string inputs into
specific numeric data types.

2. Event Registration Portal (Windows Forms Application)
A visual interface that leverages the ‘Rapid Application Development (RAD)’ strategy to
create an interactive user experience.

# Key Features:
Event-Driven Logic: Operations are triggered by user actions, specifically the ‘Click’
event of the ‘Button control’.
Toolbox Integration: Features a variety of controls including ‘TextBox’ for data entry,
‘ComboBox’ for drop-down selections, ‘CheckBox’ for multiple options, and ‘RadioButtons’
(inside a ‘GroupBox’) for mutually exclusive choices.
Complex Selection: Uses Nested If/Then/Else statements to perform multi-stage
validation and eligibility checks.
Logical Operators: Implements Short-circuiting via ‘AndAlso’ and ‘OrElse’ to improve
efficiency during input validation.

# Technical Concepts Demonstrated
Option Statements: Inclusion of ‘Option Explicit On’ to force variable declaration and
‘Option Strict On’ to prevent data loss during type conversion.
Data Types: Use of high-precision.
Decimal for currency (utilizing the `D` literal type character) and Integer for whole-number
counts.
Arithmetic Operators: Calculations performed using standard operators (‘+’, ‘-‘, ‘*’, ‘/‘ ) and
assignment abbreviations like ‘+=‘.
File-Level Structure: Adherence to the standard VB.NET coding sequence: ‘Option’
statements, ‘Imports’, and then the ‘Module’ or ‘Class’ definition.
Environment &amp; Setup
Language: Visual Basic.
Framework: .NET 10.

IDE: Visual Studio.
To Run:
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Press Ctrl+F5 to run without debugging.

# Course Objectives Met
Explain core concepts including variables, data types, and control structures.
Construct event-driven programs that respond to user input.
Utilize the Visual Studio IDE and .NET framework for writing, compiling, and testing code.
