using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Moq;

namespace BoostSharp.TestHelpers.Extensions
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
        /// Sets up a member with the specified action.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The callback action to apply. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action action)
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
        /// Sets up a member with the specified callback action.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is accessed. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1> action)
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

            mock.Setup(memberExpression).Callback(action);
            return mock;
        }
    }
}