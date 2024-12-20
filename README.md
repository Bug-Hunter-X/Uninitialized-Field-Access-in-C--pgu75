# Uninitialized Field Access in C#

This repository demonstrates a common error in C#: accessing a class field before it has been initialized.  The `bug.cs` file contains code that illustrates this problem, while `bugSolution.cs` provides a corrected version.

## The Problem

In the original code (`bug.cs`), the `MyMethod()` function accesses the `_myField` field without first assigning it a value. This can lead to unpredictable behavior, as the field's value will be whatever happened to be in that memory location. This is especially dangerous because this will not throw a compiler error!

## The Solution

The solution (`bugSolution.cs`) addresses this by assigning a default value to `_myField` (or initializing it in the constructor).