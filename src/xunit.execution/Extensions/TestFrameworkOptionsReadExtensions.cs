using System;
using Xunit.Abstractions;
using Xunit.Sdk;

/// <summary>
/// Extension methods for reading <see cref="ITestFrameworkDiscoveryOptions"/> and <see cref="ITestFrameworkExecutionOptions"/>.
/// </summary>
public static class TestFrameworkOptionsReadExtensions
{
    // Read methods for ITestFrameworkDiscoveryOptions

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted.
    /// </summary>
    public static bool? DiagnosticMessages(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted. If the flag is not present,
    /// returns the default value (<c>false</c>).
    /// </summary>
    public static bool DiagnosticMessagesOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag that determines the default display name format for test methods.
    /// </summary>
    public static TestMethodDisplay? MethodDisplay(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return TestMethodDisplay.ClassAndMethod;
    }

    /// <summary>
    /// Gets a flag that determines the default display name format for test methods. If the flag is not present,
    /// returns the default value (<see cref="TestMethodDisplay.ClassAndMethod"/>).
    /// </summary>
    public static TestMethodDisplay MethodDisplayOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return TestMethodDisplay.ClassAndMethod;
    }

    /// <summary>
    /// Gets a flag that determines whether theories are pre-enumerated. If they enabled, then the
    /// discovery system will return a test case for each row of test data; they are disabled, then the
    /// discovery system will return a single test case for the theory.
    /// </summary>
    public static bool? PreEnumerateTheories(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    /// <summary>
    /// Gets a flag that determines whether theories are pre-enumerated. If they enabled, then the
    /// discovery system will return a test case for each row of test data; they are disabled, then the
    /// discovery system will return a single test case for the theory. If the flag is not present,
    /// returns the default value (<c>true</c>).
    /// </summary>
    public static bool PreEnumerateTheoriesOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// </summary>
    public static bool? SynchronousMessageReporting(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// If the flag is not set, returns the default value (<c>false</c>).
    /// </summary>
    public static bool SynchronousMessageReportingOrDefault(this ITestFrameworkDiscoveryOptions discoveryOptions)
    {
        return false;
    }

    // Read methods for ITestFrameworkExecutionOptions

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted.
    /// </summary>
    public static bool? DiagnosticMessages(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag that determines whether diagnostic messages will be emitted. If the flag is not
    /// present, returns the default value (<c>false</c>).
    /// </summary>
    public static bool DiagnosticMessagesOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag to disable parallelization.
    /// </summary>
    public static bool? DisableParallelization(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag to disable parallelization. If the flag is not present, returns the
    /// default value (<c>false</c>).
    /// </summary>
    public static bool DisableParallelizationOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets the maximum number of threads to use when running tests in parallel.
    /// </summary>
    public static int? MaxParallelThreads(this ITestFrameworkExecutionOptions executionOptions)
    {
        return 1;
    }

    /// <summary>
    /// Gets the maximum number of threads to use when running tests in parallel. If set to 0 (or not set),
    /// the value of <see cref="Environment.ProcessorCount"/> is used; if set to a value less
    /// than 0, does not limit the number of threads.
    /// </summary>
    public static int MaxParallelThreadsOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return 1;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// </summary>
    public static bool? SynchronousMessageReporting(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }

    /// <summary>
    /// Gets a flag that determines whether xUnit.net should report test results synchronously.
    /// If the flag is not set, returns the default value (<c>false</c>).
    /// </summary>
    public static bool SynchronousMessageReportingOrDefault(this ITestFrameworkExecutionOptions executionOptions)
    {
        return true;
    }
}