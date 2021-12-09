# ThrowIf for .NET

A small helper library for .NET to throw if an argument does not meet specified criteria.

Similar to contract programming or "Guard" classes but a bit more informative as to what it will do.

## Example

```csharp
public void MyMethod(int aNumber, string something)
{
  ThrowIf.ArgumentNegative(aNumber, nameof(aNumber));
  ThrowIf.ArgumentNullOrEmpty(something, nameof(something));
}
```
