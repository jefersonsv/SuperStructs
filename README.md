# SuperStructs
Superstructs is a bunch of useful value types that fortify the source code

# Or Struct

Or is a super struct that can receive differents typed types to an object (property, field, local variable).

His construction has five generic types like ```Or<T, U, V, W, X>``` then it's will be possible put a lot of combination data types into a object.

See example:

```c#
var age = new Or<string, int>();
age = "ten years";
age = 10;

Console.WriteLine(age); // 10
```

Nuget Package
------------
You can install superstruct from nuget
- https://www.nuget.org/packages//

```
PM> Install-Package superstructs
```

Build Status
------------
[![Build status](https://ci.appveyor.com/api/projects/status/ggj9ox7f633vmp2y?svg=true)](https://ci.appveyor.com/project/jefersonsv/superstructs)