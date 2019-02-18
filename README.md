# SuperStructs
Superstructs is a bunch of useful value types that fortify the source code

# Or Struct

Or is a super struct that can receive differents typed types to an object (property, field, local variable).

His construction has five generic types like ```Or<T, U, V, W, X>``` then it's will be possible put a lot of combination data types into a object.

See example:

```
var age = new Or<string, int>();
age = "ten years";
age = 10;

Console.WriteLine(age); // 10
```

# Build Status

[![Build status](https://ci.appveyor.com/api/projects/jefersonsv/superstructs?svg=true?svg=true)](https://ci.appveyor.com/project/jefersonsv/superstructs)
