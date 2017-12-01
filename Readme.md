# Aniel.SecretSanta

A [Secret Santa](https://en.wikipedia.org/wiki/Secret_Santa) is a wonderful thing. To Help plan I created this small helper library to assign people to each other.

## Usage
Just pass an `IEnumerable<T>` to the `Aniel.SecretSanta.Assign` function and receive a `IEnumerable<(T Giver, T Receiver)>`.

```csharp
var names = new string[] { "A", "B", "C", "D", "E", "F", "G" };
var result = Aniel.SecretSanta.Assign(names);
foreach (var item in result)
{
  Console.WriteLine(item);
}
```

## Result:
```
Wonder Woman -> Captian America
Captian America -> Batman
Batman -> Iron Man
Iron Man -> Super Man
Super Man -> Thor
Thor -> Wonder Woman
```