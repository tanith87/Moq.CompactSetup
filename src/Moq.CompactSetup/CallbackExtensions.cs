using Moq.Language;
using Moq.Language.Flow;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The extension class for Moq callbacks.
    /// </summary>
    public static partial class CallbackExtensions
    {
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        public delegate void Out1Action1<TParameter1>(out TParameter1 parameter1);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1>(this ICallback<TMock, TReturn> mock, Out1Action1<TParameter1> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1>(this ICallback mock, Out1Action1<TParameter1> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        public delegate void Out2Action1<TParameter1, in TParameter2>(out TParameter1 parameter1, TParameter2 parameter2);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2>(this ICallback<TMock, TReturn> mock, Out2Action1<TParameter1, TParameter2> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2>(this ICallback mock, Out2Action1<TParameter1, TParameter2> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        public delegate void Out2Action2<in TParameter1, TParameter2>(TParameter1 parameter1, out TParameter2 parameter2);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2>(this ICallback<TMock, TReturn> mock, Out2Action2<TParameter1, TParameter2> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2>(this ICallback mock, Out2Action2<TParameter1, TParameter2> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        public delegate void Out2Action3<TParameter1, TParameter2>(out TParameter1 parameter1, out TParameter2 parameter2);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2>(this ICallback<TMock, TReturn> mock, Out2Action3<TParameter1, TParameter2> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2>(this ICallback mock, Out2Action3<TParameter1, TParameter2> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        public delegate void Out3Action1<TParameter1, in TParameter2, TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3>(this ICallback<TMock, TReturn> mock, Out3Action1<TParameter1, TParameter2, TParameter3> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3>(this ICallback mock, Out3Action1<TParameter1, TParameter2, TParameter3> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        public delegate void Out3Action2<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3>(this ICallback<TMock, TReturn> mock, Out3Action2<TParameter1, TParameter2, TParameter3> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3>(this ICallback mock, Out3Action2<TParameter1, TParameter2, TParameter3> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        public delegate void Out3Action3<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3>(this ICallback<TMock, TReturn> mock, Out3Action3<TParameter1, TParameter2, TParameter3> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3>(this ICallback mock, Out3Action3<TParameter1, TParameter2, TParameter3> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        public delegate void Out3Action4<in TParameter1, in TParameter2, in TParameter3>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3>(this ICallback<TMock, TReturn> mock, Out3Action4<TParameter1, TParameter2, TParameter3> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3>(this ICallback mock, Out3Action4<TParameter1, TParameter2, TParameter3> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        public delegate void Out3Action5<TParameter1, in TParameter2, TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3>(this ICallback<TMock, TReturn> mock, Out3Action5<TParameter1, TParameter2, TParameter3> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3>(this ICallback mock, Out3Action5<TParameter1, TParameter2, TParameter3> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        public delegate void Out3Action6<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3>(this ICallback<TMock, TReturn> mock, Out3Action6<TParameter1, TParameter2, TParameter3> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3>(this ICallback mock, Out3Action6<TParameter1, TParameter2, TParameter3> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        public delegate void Out3Action7<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3>(this ICallback<TMock, TReturn> mock, Out3Action7<TParameter1, TParameter2, TParameter3> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3>(this ICallback mock, Out3Action7<TParameter1, TParameter2, TParameter3> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action1<TParameter1, in TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action1<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action1<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action2<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action2<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action2<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action3<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action3<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action3<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action4<in TParameter1, in TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action4<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action4<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action5<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action5<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action5<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action6<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action6<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action6<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action7<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action7<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action7<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action8<in TParameter1, in TParameter2, in TParameter3, in TParameter4>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action8<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action8<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action9<TParameter1, in TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action9<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action9<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action10<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action10<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action10<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action11<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action11<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action11<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action12<in TParameter1, in TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action12<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action12<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action13<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action13<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action13<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action14<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action14<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action14<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
        /// <summary>
        /// The signature for a method with in and out parameters.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="parameter1"> The 1. parameter. </param>
        /// <param name="parameter2"> The 2. parameter. </param>
        /// <param name="parameter3"> The 3. parameter. </param>
        /// <param name="parameter4"> The 4. parameter. </param>
        public delegate void Out4Action15<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

        /// <summary>
        /// Applies the callback called.
        /// </summary>
        /// <typeparam name="TMock"> The type of the mock. </typeparam>
        /// <typeparam name="TReturn"> The type of the return. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The return handler. </returns>
        public static IReturnsThrows<TMock, TReturn> OutCallback<TMock, TReturn, TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback<TMock, TReturn> mock, Out4Action15<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMock : class
        {
            return SetOutCallback(mock, action);
        }

        /// <summary>
        /// Applies the callback called without return value.
        /// </summary>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="action"> The action. </param>
        /// <returns> The callback result. </returns>
        public static ICallbackResult OutCallback<TParameter1, TParameter2, TParameter3, TParameter4>(this ICallback mock, Out4Action15<TParameter1, TParameter2, TParameter3, TParameter4> action)
        {
            return SetOutCallback(mock, action);
        }
  
    }
} 