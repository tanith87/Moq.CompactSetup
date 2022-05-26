using System;
using System.Linq.Expressions;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class part for setups with new created mocks.
    /// </summary>
    public static partial class MockExtensions
    {
        /// <summary>
        /// Sets up the member with a new mock instance.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/> or <paramref name="memberExpression"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithNew<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression)
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

            mock.WithNew(memberExpression, out _);
            return mock;
        }

        /// <summary>
        /// Sets up the member with a new mock instance of a specific derived type.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <typeparam name="TSpecificResult"> The specific type of <typeparamref name="TResult"/> to mock. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/> or <paramref name="memberExpression"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithNew<TMockable, TResult, TSpecificResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression)
            where TMockable : class
            where TResult : class
            where TSpecificResult : class, TResult
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            mock.WithNew<TMockable, TResult, TSpecificResult>(memberExpression, out _);
            return mock;
        }

        /// <summary>
        /// Sets up the member with a new mock instance and provides that instance.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="newMock"> The newly created mock. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/> or <paramref name="memberExpression"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithNew<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, out Mock<TResult> newMock)
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

            var actualNewMock = new Mock<TResult>();
            mock.Setup(memberExpression).Returns(() => actualNewMock.Object);
            newMock = actualNewMock;
            return mock;
        }

        /// <summary>
        /// Sets up the member with a new mock instance of a specific derived type and provides that instance.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <typeparam name="TSpecificResult"> The specific type of <typeparamref name="TResult"/> to mock. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="newMock"> The newly created mock. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/> or <paramref name="memberExpression"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithNew<TMockable, TResult, TSpecificResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, out Mock<TSpecificResult> newMock)
            where TMockable : class
            where TResult : class
            where TSpecificResult : class, TResult
        {
            if (mock == null)
            {
                throw new ArgumentNullException(nameof(mock));
            }

            if (memberExpression == null)
            {
                throw new ArgumentNullException(nameof(memberExpression));
            }

            var actualNewMock = new Mock<TSpecificResult>();
            mock.Setup(memberExpression).Returns(() => actualNewMock.Object);
            newMock = actualNewMock;
            return mock;
        }

        /// <summary>
        /// Sets up the member with a new mock instance modified by the specified action.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action for modifying the new mock. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithNew<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Action<Mock<TResult>> action)
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

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            var newMock = new Mock<TResult>();
            mock.Setup(memberExpression).Returns(() => newMock.Object);
            action(newMock);
            return mock;
        }

        /// <summary>
        /// Sets up the member with a new mock instance of a specific derived type modified by the specified action.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <typeparam name="TSpecificResult"> The specific type of <typeparamref name="TResult"/> to mock. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action for modifying the new mock. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithNew<TMockable, TResult, TSpecificResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Action<Mock<TSpecificResult>> action)
            where TMockable : class
            where TResult : class
            where TSpecificResult : class, TResult
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

            var newMock = new Mock<TSpecificResult>();
            mock.Setup(memberExpression).Returns(() => newMock.Object);
            action(newMock);
            return mock;
        }
    }
}