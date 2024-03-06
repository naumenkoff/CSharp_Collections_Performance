[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[VeryLongRunJob]
[MemoryDiagnoser]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
public class AddBenchmark
{
    [Params(10, 1000, 100000)] public int N;

    public string[] Items;

    [IterationSetup]
    public void Setup()
    {
        Items = Enumerable.Range(0, N).Select(_ => Guid.NewGuid().ToString()).ToArray();
    }

    [Benchmark]
    public System.Collections.ObjectModel.Collection<string> AddInSystem_Collections_ObjectModel_Collection()
    {
        var collection = new System.Collections.ObjectModel.Collection<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.ObjectModel.ObservableCollection<string> AddInSystem_Collections_ObjectModel_ObservableCollection()
    {
        var collection = new System.Collections.ObjectModel.ObservableCollection<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Immutable.ImmutableDictionary<string, string> AddInSystem_Collections_Immutable_ImmutableDictionary()
    {
        var collection = ImmutableDictionary.Create<string, string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection = collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Immutable.ImmutableHashSet<string> AddInSystem_Collections_Immutable_ImmutableHashSet()
    {
        var collection = ImmutableHashSet.Create<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection = collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Immutable.ImmutableList<string> AddInSystem_Collections_Immutable_ImmutableList()
    {
        var collection = ImmutableList.Create<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection = collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Immutable.ImmutableQueue<string> AddInSystem_Collections_Immutable_ImmutableQueue()
    {
        var collection = ImmutableQueue.Create<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection = collection.Enqueue(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Immutable.ImmutableSortedDictionary<string, string> AddInSystem_Collections_Immutable_ImmutableSortedDictionary()
    {
        var collection = ImmutableSortedDictionary.Create<string, string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection = collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Immutable.ImmutableSortedSet<string> AddInSystem_Collections_Immutable_ImmutableSortedSet()
    {
        var collection = ImmutableSortedSet.Create<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection = collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Immutable.ImmutableStack<string> AddInSystem_Collections_Immutable_ImmutableStack()
    {
        var collection = ImmutableStack.Create<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection = collection.Push(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.Dictionary<string, string> AddInSystem_Collections_Generic_Dictionary()
    {
        var collection = new System.Collections.Generic.Dictionary<string, string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.HashSet<string> AddInSystem_Collections_Generic_HashSet()
    {
        var collection = new System.Collections.Generic.HashSet<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.LinkedList<string> AddInSystem_Collections_Generic_LinkedList()
    {
        var collection = new System.Collections.Generic.LinkedList<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.AddLast(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.List<string> AddInSystem_Collections_Generic_List()
    {
        var collection = new System.Collections.Generic.List<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.PriorityQueue<string, string> AddInSystem_Collections_Generic_PriorityQueue()
    {
        var collection = new System.Collections.Generic.PriorityQueue<string, string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Enqueue(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.Queue<string> AddInSystem_Collections_Generic_Queue()
    {
        var collection = new System.Collections.Generic.Queue<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Enqueue(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.SegmentedDictionary<string, string> AddInSystem_Collections_Generic_SegmentedDictionary()
    {
        var collection = new System.Collections.Generic.SegmentedDictionary<string, string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.SortedDictionary<string, string> AddInSystem_Collections_Generic_SortedDictionary()
    {
        var collection = new System.Collections.Generic.SortedDictionary<string, string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.SortedList<string, string> AddInSystem_Collections_Generic_SortedList()
    {
        var collection = new System.Collections.Generic.SortedList<string, string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.SortedSet<string> AddInSystem_Collections_Generic_SortedSet()
    {
        var collection = new System.Collections.Generic.SortedSet<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Generic.Stack<string> AddInSystem_Collections_Generic_Stack()
    {
        var collection = new System.Collections.Generic.Stack<string>();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Push(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.ArrayList AddInSystem_Collections_ArrayList()
    {
        var collection = new System.Collections.ArrayList();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Hashtable AddInSystem_Collections_Hashtable()
    {
        var collection = new System.Collections.Hashtable();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Queue AddInSystem_Collections_Queue()
    {
        var collection = new System.Collections.Queue();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Enqueue(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.SortedList AddInSystem_Collections_SortedList()
    {
        var collection = new System.Collections.SortedList();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Stack AddInSystem_Collections_Stack()
    {
        var collection = new System.Collections.Stack();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Push(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Specialized.ListDictionary AddInSystem_Collections_Specialized_ListDictionary()
    {
        var collection = new System.Collections.Specialized.ListDictionary();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Specialized.NameValueCollection AddInSystem_Collections_Specialized_NameValueCollection()
    {
        var collection = new System.Collections.Specialized.NameValueCollection();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Specialized.OrderedDictionary AddInSystem_Collections_Specialized_OrderedDictionary()
    {
        var collection = new System.Collections.Specialized.OrderedDictionary();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Specialized.StringCollection AddInSystem_Collections_Specialized_StringCollection()
    {
        var collection = new System.Collections.Specialized.StringCollection();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }

    [Benchmark]
    public System.Collections.Specialized.StringDictionary AddInSystem_Collections_Specialized_StringDictionary()
    {
        var collection = new System.Collections.Specialized.StringDictionary();
        ref var start = ref MemoryMarshal.GetArrayDataReference(Items);
        ref var end = ref Unsafe.Add(ref start, Items.Length);
        while (Unsafe.IsAddressLessThan(ref start, ref end))
        {
            collection.Add(start, start);
            start = ref Unsafe.Add(ref start, 1);
        }

        return collection;
    }
}