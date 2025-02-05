# Accessing Disposed Object in C# Example

This repository demonstrates a common error in C#: attempting to access a disposed object.  The `bug.cs` file shows code that throws an exception because it tries to use a database context after it has been disposed of. The `bugSolution.cs` file provides a corrected version.

## Problem
The issue lies in the `MyMethod()` function.  A `using` statement ensures the `MyDbContext` is properly disposed of when it goes out of scope. However, the subsequent `context.SaveChanges()` attempts to use the context after it's been disposed, causing an exception.

## Solution
The solution involves making sure all operations on the `MyDbContext` happen within the `using` block.  This ensures the context is properly managed and prevents access after disposal.