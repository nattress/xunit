using System;
using Xunit;
using Xunit.Abstractions;

/// <summary>
/// Extension methods for reading and writing <see cref="ITestFrameworkDiscoveryOptions"/> and <see cref="ITestFrameworkExecutionOptions"/>.
/// </summary>
public static class TestFrameworkOptionsReadWriteExtensions
{
    // Read/write methods for ITestFrameworkDiscoveryOptions

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted.
    /// </summary>
    public static bool? GetDiagnosticMessages(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted. If the flag is not
    /// set, returns the default value (<c>false</c>).
    /// </summary>
    public static bool GetDiagnosticMessagesOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag that determines the default display name format for test methods.
    /// </summary>
    public static TestMethodDisplay? GetMethodDisplay(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return TestMethodDisplay.ClassAndMethod;
    }

    /// <summary>
    /// Gets a flag that determines the default display name format for test methods. If the flag is not present,
    /// returns the default value (<see cref="TestMethodDisplay.ClassAndMethod"/>).
    /// </summary>
    public static TestMethodDisplay GetMethodDisplayOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return TestMethodDisplay.ClassAndMethod;
    }

    /// <summary>
    /// Gets a flag that determines whether theories are pre-enumerated. If they enabled, then the
    /// discovery system will return a test case for each row of test data; they are disabled, then the
    /// discovery system will return a single test case for the theory.
    /// </summary>
    public static bool? GetPreEnumerateTheories(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    /// <summary>
    /// Gets a flag that determines whether theories are pre-enumerated. If they enabled, then the
    /// discovery system will return a test case for each row of test data; they are disabled, then the
    /// discovery system will return a single test case for the theory. If the flag is not present,
    /// returns the default value (<c>true</c>).
    /// </summary>
    public static bool GetPreEnumerateTheoriesOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// </summary>
    public static bool? GetSynchronousMessageReporting(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// If the flag is not set, returns the default value (<c>false</c>).
    /// </summary>
    public static bool GetSynchronousMessageReportingOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    /// <summary>
    /// Sets a flag that determines whether diagnostic messages will be emitted.
    /// </summary>
    public static void SetDiagnosticMessages(this ITestFrameworkDiscoveryOptions discoveryOptions, bool? value)
    {
        
    }

    /// <summary>
    /// Sets a flag that determines the default display name format for test methods.
    /// </summary>
    public static void SetMethodDisplay(this ITestFrameworkDiscoveryOptions discoveryOptions, TestMethodDisplay? value)
    {
        
    }

    /// <summary>
    /// Sets a flag that determines whether theories are pre-enumerated. If they enabled, then the
    /// discovery system will return a test case for each row of test data; they are disabled, then the
    /// discovery system will return a single test case for the theory.
    /// </summary>
    public static void SetPreEnumerateTheories(this ITestFrameworkDiscoveryOptions discoveryOptions, bool? value)
    {
        
    }

    /// <summary>
    /// Sets a flag that determines whether xUnit.net should report test results synchronously.
    /// </summary>
    public static void SetSynchronousMessageReporting(this ITestFrameworkDiscoveryOptions discoveryOptions, bool? value)
    {
        
    }

    // Read/write methods for ITestFrameworkExecutionOptions

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted.
    /// </summary>
    public static bool? GetDiagnosticMessages(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted. If the flag is not
    /// present, returns the default value (<c>false</c>).
    /// </summary>
    public static bool GetDiagnosticMessagesOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag to disable parallelization.
    /// </summary>
    public static bool? GetDisableParallelization(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag to disable parallelization. If the flag is not present, returns the
    /// default value (<c>false</c>).
    /// </summary>
    public static bool GetDisableParallelizationOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets the maximum number of threads to use when running tests in parallel.
    /// </summary>
    public static int? GetMaxParallelThreads(this ITestFrameworkExecutionOptions executionOptions)
    {
        return 1;
    }

    /// <summary>
    /// Gets the maximum number of threads to use when running tests in parallel. If set to 0 (or not set),
    /// the value of <see cref="Environment.ProcessorCount"/> is used; if set to a value less
    /// than 0, does not limit the number of threads.
    /// </summary>
    public static int GetMaxParallelThreadsOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return 1;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// </summary>
    public static bool? GetSynchronousMessageReporting(this ITestFrameworkExecutionOptions executionOptions)
    {
        return false;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// If the flag is not set, returns the default value (<c>false</c>).
    /// </summary>
    public static bool GetSynchronousMessageReportingOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return false;
    }

    /// <summary>
    /// Sets a flag that determines whether diagnostic messages will be emitted.
    /// </summary>
    public static void SetDiagnosticMessages(this ITestFrameworkExecutionOptions executionOptions, bool? value)
    {
        
    }

    /// <summary>
    /// Sets a flag to disable parallelization.
    /// </summary>
    public static void SetDisableParallelization(this ITestFrameworkExecutionOptions executionOptions, bool? value)
    {
        
    }

    /// <summary>
    /// Sets the maximum number of threads to use when running tests in parallel.
    /// If set to 0 (the default value), does not limit the number of threads.
    /// </summary>
    public static void SetMaxParallelThreads(this ITestFrameworkExecutionOptions executionOptions, int? value)
    {
        
    }

    /// <summary>
    /// Sets a flag that determines whether xUnit.net should report test results synchronously.
    /// </summary>
    public static void SetSynchronousMessageReporting(this ITestFrameworkExecutionOptions executionOptions, bool? value)
    {
        
    }
}
