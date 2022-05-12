# SOLID principles

This repository contains the SOLID principles details and code examples written in Dotnet C#.

## Definition

SOLID is a mnemonic acronym for five design principles intended to make software designs more understandable, flexible, and maintainable.

The SOLID principles are:

### [S] Single responsibility principle

There should never be more than one reason for a class to change.
In other words, every class should have only one responsibility.

### [O] Open–Closed principle

Software entities should be open for extension, but closed for modification.

### [L] Liskov substitution principle

Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.
See also design by contract.

### [I] Interface segregation principle

Many client-specific interfaces are better than one general-purpose interface.

### [D] Dependency inversion principle

Depend upon abstractions, not concretions.

[👆 Source](https://en.wikipedia.org/wiki/SOLID)

## Code examples

| Principle | Information |
| -- | -- |
| Single responsibility | [📄](./SolidPrinciples.SingleResponsibilityPrinciple/README.md) |
| Open Closed | [📄](./SolidPrinciples.OpenClosedPrinciple/README.md) |
| Liskov Substitution | [📄](./SolidPrinciples.LiskovSubstitutionPrinciple/README.md) |
| Interface Segregation | [📄](./SolidPrinciples.InterfaceSegregationPrinciple/README.md) |
| Dependency Inversion | [📄](./SolidPrinciples.DependencyInversionPrinciple/README.md) |

# Technologies

| Technology | Documentation |  
| -- | -- |
| Dotnet | [📎](https://docs.microsoft.com/en-gb/dotnet/) | 
| C# | [📎](https://docs.microsoft.com/en-us/dotnet/csharp/) |

# Setup

## Clone repository

Create and go to the directory where you want to place the repository

```bash
  cd my-directory
```

Clone the project

```bash
  git clone https://github.com/pncsoares/dotnet-solid-principles.git
```

Go to the project directory

```bash
  cd dotnet-solid-principles
```

## Contribute

Feel free to contribute and fix something that is wrong or could be better! Issues and pull requests are welcome.

To do so please create a new branch, change or add what you want and then create a Pull Request to branch `main` and add me as reviewer.

Thanks 🙏

# License

MIT
