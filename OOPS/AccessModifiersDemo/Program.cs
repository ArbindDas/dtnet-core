using System;

public class AccessModifiersDemo
{
    // Public: Accessible from anywhere
    public string PublicField = "Public Field";

    // Private: Accessible only within this class
    private string PrivateField = "Private Field";

    // Protected: Accessible within this class and derived classes
    protected string ProtectedField = "Protected Field";

    // Internal: Accessible only within the same assembly
    internal string InternalField = "Internal Field";

    // Protected Internal: Accessible within the same assembly or derived classes
    protected internal string ProtectedInternalField = "Protected Internal Field";

    // Private Protected: Accessible within this class and derived classes in the same assembly
    private protected string PrivateProtectedField = "Private Protected Field";

    public void ShowFields()
    {
        // Accessing all fields from within the same class
        Console.WriteLine(PublicField);             // Public
        Console.WriteLine(PrivateField);            // Private
        Console.WriteLine(ProtectedField);          // Protected
        Console.WriteLine(InternalField);           // Internal
        Console.WriteLine(ProtectedInternalField);  // Protected Internal
        Console.WriteLine(PrivateProtectedField);   // Private Protected
    }
}

class Program
{
    static void Main()
    {
        AccessModifiersDemo demo = new AccessModifiersDemo();

        // Accessing public field from outside the class
        Console.WriteLine(demo.PublicField);  // OK: Public

        // The following lines would cause errors, as they try to access non-public members
        // Console.WriteLine(demo.PrivateField);  // Error: Private
        // Console.WriteLine(demo.ProtectedField);  // Error: Protected
        // Console.WriteLine(demo.InternalField);  // Error: Internal (if accessed outside the assembly)
        // Console.WriteLine(demo.ProtectedInternalField);  // Error: Protected Internal (if outside assembly)
        // Console.WriteLine(demo.PrivateProtectedField); // Error: Private Protected

        // Calling ShowFields() method to see all fields inside the class
        demo.ShowFields();
    }
}
