using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class part for setting up thrown exceptions.
    /// </summary>
    public static partial class MockExtensions
    {
        /// <summary>
        /// Sets up the member with the specified exception.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TException"> The type of the exception that is thrown. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="exception"> The exception to throw. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="memberExpression" /> or <paramref name="exception" /> is <see langword="null" />. </exception>
        public static Mock<TMockable> WithException<TMockable, TException>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, TException exception)
            where TMockable : class
            where TException : Exception
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            mock.Setup(memberExpression).Throws(exception);
            return mock;
        }

        /// <summary>
        /// Sets up the member with the specified exception type.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TException"> The type of the exception that is thrown. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" /> or <paramref name="memberExpression" /> is <see langword="null" />. </exception>
        public static Mock<TMockable> WithException<TMockable, TException>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression)
            where TMockable : class
            where TException : Exception, new()
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            mock.Setup(memberExpression).Throws<TException>();
            return mock;
        }

        /// <summary>
        /// Sets up the member with the specified exception in an asynchronous way.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TException"> The type of the exception that is thrown. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="exception"> The exception to throw. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" />, <paramref name="memberExpression" /> or <paramref name="exception" /> is <see langword="null" />. </exception>
        public static Mock<TMockable> WithException<TMockable, TException>(this Mock<TMockable> mock, Expression<Func<TMockable, Task>> memberExpression, TException exception)
            where TMockable : class
            where TException : Exception
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            mock.Setup(memberExpression).ThrowsAsync(exception);
            return mock;
        }

        /// <summary>
        /// Sets up the member with the specified exception type in an asynchronous way.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TException"> The type of the exception that is thrown. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock" /> or <paramref name="memberExpression" /> is <see langword="null" />. </exception>
        public static Mock<TMockable> WithException<TMockable, TException>(this Mock<TMockable> mock, Expression<Func<TMockable, Task>> memberExpression)
            where TMockable : class
            where TException : Exception, new()
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            mock.Setup(memberExpression).ThrowsAsync(Activator.CreateInstance<TException>());
            return mock;
        }
    }
}