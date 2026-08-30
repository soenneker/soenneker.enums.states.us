[![](https://img.shields.io/nuget/v/soenneker.enums.states.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.states.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.states.us/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.states.us/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.states.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.states.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.states.us/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.states.us/actions/workflows/codeql.yml)

# Soenneker.Enums.States.US

A string-backed enum-value type containing the two-letter postal abbreviations for the 50 U.S. states.

## Install

```bash
dotnet add package Soenneker.Enums.States.US
```

## Usage

```csharp
using Soenneker.Enums.States.US;

USState state = USState.TX;
string postalCode = state.Value; // "TX"

if (USState.TryFromValue(input, out USState? parsed))
{
    // parsed is one of the shared state instances
}
```

Every defined value uses the same uppercase two-letter text for its C# member name and wire value. Lookup is case-sensitive, so normalize user input deliberately if lowercase codes should be accepted. `System.Text.Json` serializes the value as a string. `FromValue` throws for unknown input; use `TryFromValue` when accepting addresses. `FromName` and `TryFromName` are also generated.

The set contains the 50 states only. It does not contain the District of Columbia, U.S. territories, military postal regions, or freely associated states. This package does not validate an address, ZIP code, state/ZIP relationship, deliverability, or residency, and it does not provide full state display names.
