using System.Runtime.InteropServices;

namespace crash_repro
{
    public static class Program
    {
        public delegate void ManagedCallbackDelegate(int value);

        [DllImport("crash_repro_native")]
        public static extern void do_callback(ManagedCallbackDelegate callbackDelegate);

        [DllImport("crash_repro_native")]
        public static extern int get_value();

        public static void Main()
        {
            do_callback((int value) => Console.WriteLine($"Native to Managed callback gave value: {value}"));
            // int value = get_value();
            // Console.WriteLine($"Got value: {value}");
        }
    }
}
