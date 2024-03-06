# Performance of all collections in C#

> [!NOTE]
> All benchmarks were conducted using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet).  
> Each folder is named after the operation performed on the collection and consists of three files:
> - Operation.cs: benchmark file itself
> - Operation.md: benchmark results
> - Operation.log: benchmark log

> [!IMPORTANT]
> Over time, I plan to create a best-practice guide here on working with each collection from the System.Collections namespace:  
> which collections exist and what are they used for, real business examples of their use, which collections are better to use, which collections are better to avoid and never use.

# Navigation

- [Add, Push, Enqueue](#add)
- [Contains](#contains)
- [Enumerate](#enumerate)
- [Remove](#remove)
- [Clear](#clear)

## Add

- [Add.cs](./Add/Add.cs)  
- [Add.log](./Add/Add.log)  
- [Add.md](./Add/Add.md)

## Contains

- [Contains.cs](./Contains/Contains.cs)  
- [Contains.log](./Contains/Contains.log)  
- [Contains.md](./Contains/Contains.md)

## Enumerate

- [Enumerate.cs](./Enumerate/Enumerate.cs)  
- [Enumerate.log](./Enumerate/Enumerate.log)  
- [Enumerate.md](./Enumerate/Enumerate.md)

## Remove

- [Remove.cs](./Remove/Remove.cs)  
- [Remove.log](./Remove/Remove.log)  
- [Remove.md](./Remove/Remove.md)

## Clear

- [Clear.cs](./Clear/Clear.cs)  
- [Clear.log](./Clear/Clear.log)  
- [Clear.md](./Clear/Clear.md)
