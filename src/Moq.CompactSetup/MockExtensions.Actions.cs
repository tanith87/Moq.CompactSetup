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
        /// Sets up a member with the specified callback action.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action action)
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
        /// <param name="action"> The action to call when the member is utilized. </param>
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TParameter9"> The type of the 9. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TParameter9"> The type of the 9. parameter. </typeparam>
        /// <typeparam name="TParameter10"> The type of the 10. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TParameter9"> The type of the 9. parameter. </typeparam>
        /// <typeparam name="TParameter10"> The type of the 10. parameter. </typeparam>
        /// <typeparam name="TParameter11"> The type of the 11. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TParameter9"> The type of the 9. parameter. </typeparam>
        /// <typeparam name="TParameter10"> The type of the 10. parameter. </typeparam>
        /// <typeparam name="TParameter11"> The type of the 11. parameter. </typeparam>
        /// <typeparam name="TParameter12"> The type of the 12. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TParameter9"> The type of the 9. parameter. </typeparam>
        /// <typeparam name="TParameter10"> The type of the 10. parameter. </typeparam>
        /// <typeparam name="TParameter11"> The type of the 11. parameter. </typeparam>
        /// <typeparam name="TParameter12"> The type of the 12. parameter. </typeparam>
        /// <typeparam name="TParameter13"> The type of the 13. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12, TParameter13>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12, TParameter13> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TParameter9"> The type of the 9. parameter. </typeparam>
        /// <typeparam name="TParameter10"> The type of the 10. parameter. </typeparam>
        /// <typeparam name="TParameter11"> The type of the 11. parameter. </typeparam>
        /// <typeparam name="TParameter12"> The type of the 12. parameter. </typeparam>
        /// <typeparam name="TParameter13"> The type of the 13. parameter. </typeparam>
        /// <typeparam name="TParameter14"> The type of the 14. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12, TParameter13, TParameter14>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12, TParameter13, TParameter14> action)
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
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
        /// <typeparam name="TParameter6"> The type of the 6. parameter. </typeparam>
        /// <typeparam name="TParameter7"> The type of the 7. parameter. </typeparam>
        /// <typeparam name="TParameter8"> The type of the 8. parameter. </typeparam>
        /// <typeparam name="TParameter9"> The type of the 9. parameter. </typeparam>
        /// <typeparam name="TParameter10"> The type of the 10. parameter. </typeparam>
        /// <typeparam name="TParameter11"> The type of the 11. parameter. </typeparam>
        /// <typeparam name="TParameter12"> The type of the 12. parameter. </typeparam>
        /// <typeparam name="TParameter13"> The type of the 13. parameter. </typeparam>
        /// <typeparam name="TParameter14"> The type of the 14. parameter. </typeparam>
        /// <typeparam name="TParameter15"> The type of the 15. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12, TParameter13, TParameter14, TParameter15>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Action<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5, TParameter6, TParameter7, TParameter8, TParameter9, TParameter10, TParameter11, TParameter12, TParameter13, TParameter14, TParameter15> action)
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