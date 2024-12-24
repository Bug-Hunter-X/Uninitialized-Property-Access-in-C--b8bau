public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize the property in the constructor
        MyProperty = 10; 
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now it's safe to access MyProperty
    }
}