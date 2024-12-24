# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing class properties before they've been explicitly assigned a value.  In some cases, this might lead to unexpected default values (0 for integers, false for booleans, etc.) rather than an exception, making it harder to detect.

## The Bug
The `bug.cs` file shows an example where `MyProperty` is accessed in `MyMethod` before it's explicitly set.  Depending on the context, this could result in the property having its default value (0 in this case), leading to unexpected results and making debugging more challenging. 

## The Solution
The `bugSolution.cs` file illustrates the correct way to handle this: initializing `MyProperty` with a default value in the constructor or explicitly assigning a value before accessing it within a method.  This ensures predictable behavior and avoids potential runtime issues.
