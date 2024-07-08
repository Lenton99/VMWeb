// ConsoleInterop.cs
using Microsoft.JSInterop;

public static class ConsoleInterop
{
    public static ValueTask LogToConsole(IJSRuntime jsRuntime, string data)
    {
        return jsRuntime.InvokeVoidAsync("consoleInterop.logToConsole", data);
    }
}
