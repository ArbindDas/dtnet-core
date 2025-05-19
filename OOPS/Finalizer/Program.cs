using System;

class ResourceManager
{
    private IntPtr unmanagedResource;  // Simulating an unmanaged resource

    public ResourceManager()
    {
        // Simulating acquiring an unmanaged resource
        unmanagedResource = new IntPtr(123456);
        Console.WriteLine("Resource acquired.");
    }

    // Finalizer (Destructor) to clean up unmanaged resource
    ~ResourceManager()
    {
        // Release unmanaged resources here
        Console.WriteLine("Finalizer called. Releasing unmanaged resource.");
        unmanagedResource = IntPtr.Zero; // Clean up
    }
}

class Program
{
    static void Main()
    {
        ResourceManager rm = new ResourceManager();
        // Allow the object to be eligible for GC
        rm = null;

        // Forcing garbage collection to call the finalizer
        GC.Collect();
        GC.WaitForPendingFinalizers();
        
        Console.WriteLine("End of Main.");
    }
}
