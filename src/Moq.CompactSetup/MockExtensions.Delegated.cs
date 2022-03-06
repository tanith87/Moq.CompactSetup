using System;
using System.Linq.Expressions;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class.
    /// </summary>
    public static partial class MockExtensions
    {
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
    }
}