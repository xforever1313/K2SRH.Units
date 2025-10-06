# K2SRH.Units

This is my Hacktoberfest project for 2025.

The intent is to have a series of "unit" classes written in C# that people can use instead of having to convert between units. It all just happens magically.

## Features

* Targets .NET Standard 2.0, so it can be used in both .NET Framework, Mono, .NET Core, and .NET projects.
* All unit types are structs.
* All unit types are backed by C#'s decimal type, meaning there will be no rounding errors unlike if floats or doubles were used.
* Operators that allow units to become other units.
