﻿using System;
using System.Linq.Expressions;
using Moq;

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
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TParameter2, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the return type. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Func<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TResult> valueSelector)
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

            mock.Setup(memberExpression).Returns(valueSelector);
            return mock;
        }

  
    }
} 