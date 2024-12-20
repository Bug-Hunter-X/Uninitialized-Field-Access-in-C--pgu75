public class ExampleClass
{
    private int _myField = 0; // Initialize the field with a default value

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        Console.WriteLine(_myField); // Now the field is guaranteed to have a value
    }

    public ExampleClass() { //Constructor
        _myField = 5; // Initialize in Constructor
    }
} 