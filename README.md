# LGraebin.Extensions
A small set of C# extension methods I've been using on my projects.

## :floppy_disk: Installation
This project is target to .NET Standard 2.0 and available as a NuGet package. You can install it using the NuGet Package Console window:

```
PM> Install-Package LGraebin.Extensions
```

## :white_check_mark: Features
These are the features available.

### Validate e-mail address
You can call `IsEmail()` on any string to check if it is a valid e-mail address.

```C#
"john.doe@example.com".IsEmail() => true
"@example.com".IsEmail() => false
```

### Mask e-mail address
You can mask the local-part of an e-mail address (the bit before the @-sign) using the `MaskEmail()` method. It replaces all characters of the local-part with `*`, except the first and last characters.

```C#
"john.doe@example.com".MaskEmail() => "j******e@example.com"
```

## :star: Give a Star!
If you like or are using this project to learn or start your solution, please give it a star. Thanks!
