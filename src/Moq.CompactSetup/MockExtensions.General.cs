using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Moq.Protected;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class.
    /// </summary>
    public static partial class MockExtensions
    {
        /// <summary>
        /// Gets the objects for the specified enumerable of mocks.
        /// </summary>
        /// <typeparam name="TElement"> The type of the element. </typeparam>
        /// <param name="mockEnumerable"> The mock enumerable. </param>
        /// <returns> The enumeration of objects. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mockEnumerable"/> is <c>null</c>. </exception>
        public static IEnumerable<TElement> Objects<TElement>(this IEnumerable<Mock<TElement>> mockEnumerable)
            where TElement : class
        {
            if (mockEnumerable == null)
            {
                throw new ArgumentNullException(nameof(mockEnumerable));
            }

            return mockEnumerable.Select(x => x.Object);
        }

        /// <summary>
        /// Sets up a member with the specified value.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="value"> The value to set. </param>
        /// <param name="enableSetBack"> The value indicating, whether for properties the simple set back should be enabled. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/> or <paramref name="memberExpression"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, TResult value, bool enableSetBack = false)
            where TMockable : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (enableSetBack)
            {
                mock.SetupProperty(memberExpression, value);
            }
            else
            {
                mock.Setup(memberExpression).Returns(value);
            }

            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value in an pseudo asynchronous way.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="value"> The value to set. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/> or <paramref name="memberExpression"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, Task<TResult>>> memberExpression, TResult value)
            where TMockable : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            mock.Setup(memberExpression).Returns(Task.FromResult(value));
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified mocked value.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="mockedValue"> The mocked value to set. </param>
        /// <param name="enableSetBack"> The value indicating, whether for properties the simple set back should be enabled. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="mockedValue"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Mock<TResult> mockedValue, bool enableSetBack = false)
            where TMockable : class
            where TResult : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (mockedValue == null)
            {
                throw new ArgumentNullException(nameof(mockedValue));
            }

            mock.Setup(memberExpression).Returns(() => mockedValue.Object);
            if (enableSetBack)
            {
                // This is not using SetupProperty, as SetupProperty directly creates the object of the mock, which might breaks some later setup in user code.
                var itIsAnyExpression = Expression.Lambda<Action<TMockable>>(Expression.Assign(memberExpression.Body, ItExpr.IsAny<TResult>()), memberExpression.Parameters[0]);
                mock.SetupSet(itIsAnyExpression.Compile()).Callback<TResult>(newValue => { mock.Setup(memberExpression).Returns(newValue); });
            }

            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified mocked value in an pseudo asynchronous way.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="mockedValue"> The mocked value to set. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="mockedValue"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, Task<TResult>>> memberExpression, Mock<TResult> mockedValue)
            where TMockable : class
            where TResult : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (mockedValue == null)
            {
                throw new ArgumentNullException(nameof(mockedValue));
            }

            mock.Setup(memberExpression).Returns(() => Task.FromResult(mockedValue.Object));
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <remarks>
        /// As not all permutations can be pre-delivered this method offers the possibility to pass a custom delegate.
        /// </remarks>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegate valueSelector)
            where TMockable : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (valueSelector == null)
            {
                throw new ArgumentNullException(nameof(valueSelector));
            }

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified callback action.
        /// </summary>
        /// <remarks>
        /// As not all permutations can be pre-delivered this method offers the possibility to pass a custom delegate.
        /// </remarks>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <c>null</c>. </exception>
        public static Mock<TMockable> WithCallback<TMockable>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegate action)
            where TMockable : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            mock.Setup(memberExpression).Callback(action);
            return mock;
        }

        /// <summary>
        /// Sets up the property setter with a callback, that is called when the setter is invoked.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TProperty"> The type of the property. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="propertySetter"> The property setter. </param>
        /// <param name="callback"> The callback action. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="propertySetter"/> or <paramref name="callback"/> is <c>null</c>. </exception>
        public static Mock<TMockable> WithSet<TMockable, TProperty>(this Mock<TMockable> mock, Action<TMockable> propertySetter, Action<TProperty> callback)
            where TMockable : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (propertySetter == null)
            {
                throw new ArgumentNullException(nameof(propertySetter));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            mock.SetupSet(propertySetter).Callback(callback);
            return mock;
        }
    }
}