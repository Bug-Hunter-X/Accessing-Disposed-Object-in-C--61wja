public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Correctly accessing the object within the using block
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
            context.SaveChanges(); // SaveChanges is now called before the context is disposed
        }
    }
}