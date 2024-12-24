public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        int value = MyProperty; // Potential error here if MyProperty is not set before this line
    }
}