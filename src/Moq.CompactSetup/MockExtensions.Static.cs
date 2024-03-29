﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Moq.Protected;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class part for static value setups.
    /// </summary>
    public static partial class MockExtensions
    {
        /// <summary>
        /// Sets up a member with a mock of its return type and returns that mock.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <typeparam name="TDerivedResult"> The derived type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="value"> The mock to set. </param>
        /// <returns> The passed mock. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="memberExpression" /> or <paramref name="value" /> is <see langword="null" />. </exception>
        public static Mock<TDerivedResult> SetupMock<TMockable, TResult, TDerivedResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Mock<TDerivedResult> value)
            where TMockable : class
            where TResult : class
            where TDerivedResult : class, TResult
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            mock.With(memberExpression, () => value.Object);
            return value;
        }

        /// <summary>
        /// Sets up a member with a new mock of its return type and returns that newly created mock.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <returns> The created mock. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" /> or <paramref name="memberExpression" /> is <see langword="null" />. </exception>
        public static Mock<TResult> SetupNewMock<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression)
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

            return mock.SetupMock(memberExpression, new Mock<TResult>());
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" /> or <paramref name="memberExpression" /> is <see langword="null" />. </exception>
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
        /// Sets up a member with the specified value in a pseudo asynchronous way.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="value"> The value to set. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" /> or <paramref name="memberExpression" /> is <see langword="null" />. </exception>
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
        /// <typeparam name="TDerivedResult"> The derived type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="mockedValue"> The mocked value to set. </param>
        /// <param name="enableSetBack"> The value indicating, whether for properties the simple set back should be enabled. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="memberExpression" /> or <paramref name="mockedValue" /> is <see langword="null" />. </exception>
        public static Mock<TMockable> With<TMockable, TResult, TDerivedResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Mock<TDerivedResult> mockedValue, bool enableSetBack = false)
            where TMockable : class
            where TResult : class
            where TDerivedResult : class, TResult
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
        /// Sets up a member with the specified mocked value in a pseudo asynchronous way.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="mockedValue"> The mocked value to set. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="memberExpression" /> or <paramref name="mockedValue" /> is <see langword="null" />. </exception>
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
        /// Sets up a member with the specified mocked values.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TElement"> The type of the element of the values. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="mockedValues"> The mocked values to set. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="memberExpression" /> or <paramref name="mockedValues" /> is <see langword="null" />. </exception>
        public static Mock<TMockable> With<TMockable, TElement>(this Mock<TMockable> mock, Expression<Func<TMockable, IEnumerable<TElement>>> memberExpression, IEnumerable<Mock<TElement>> mockedValues)
            where TMockable : class
            where TElement : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (mockedValues == null)
            {
                throw new ArgumentNullException(nameof(mockedValues));
            }

            mock.Setup(memberExpression).Returns(mockedValues.Objects);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified mocked values in a pseudo asynchronous way.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TElement"> The type of the element of the values. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="mockedValues"> The mocked values to set. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="memberExpression" /> or <paramref name="mockedValues" /> is <see langword="null" />. </exception>
        public static Mock<TMockable> With<TMockable, TElement>(this Mock<TMockable> mock, Expression<Func<TMockable, Task<IEnumerable<TElement>>>> memberExpression, IEnumerable<Mock<TElement>> mockedValues)
            where TMockable : class
            where TElement : class
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (mockedValues == null)
            {
                throw new ArgumentNullException(nameof(mockedValues));
            }

            mock.Setup(memberExpression).Returns(() => Task.FromResult(mockedValues.Objects()));
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="propertySetter" /> or <paramref name="callback" /> is <see langword="null" />. </exception>
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