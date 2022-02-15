using System.Reflection;
using Moq.Language;
using Moq.Language.Flow;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The extension class for Moq callbacks.
    /// </summary>
    internal static partial class CallbackExtensions
    {
        /// <summary>
        /// Sets the a callback using the internal Moq facilities.
        /// </summary>
        /// <typeparam name="TCallback"> The type of the callback. </typeparam>
        /// <param name="callback"> The mock represented by a callback. </param>
        /// <param name="action"> The callback action. </param>
        private static void SetCallbackWithArguments<TCallback>(TCallback callback, object action)
            where TCallback : IFluentInterface
        {
            typeof(TCallback)
                .Assembly
                .GetType("Moq.MethodCall")
                .InvokeMember("SetCallbackWithArguments", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance, null, callback, new[] { action });
        }

        /// <summary>
        /// Sets the out callback.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TResult"> The type of the result value. </typeparam>
        /// <param name="mock"> The mock represented by a generic callback. </param>
        /// <param name="action"> The callback action. </param>
        /// <returns> The return handler. </returns>
        private static IReturnsThrows<TMock, TResult> SetOutCallback<TMock, TResult>(ICallback<TMock, TResult> mock, object action)
            where TMock : class
        {
            SetCallbackWithArguments(mock, action);
            return (IReturnsThrows<TMock, TResult>)mock;
        }

        /// <summary>
        /// Sets the out callback.
        /// </summary>
        /// <param name="mock"> The mock represented by a callback. </param>
        /// <param name="action"> The callback action. </param>
        /// <returns> The callback result. </returns>
        private static ICallbackResult SetOutCallback(ICallback mock, object action)
        {
            SetCallbackWithArguments(mock, action);
            return (ICallbackResult)mock;
        }
    }
}