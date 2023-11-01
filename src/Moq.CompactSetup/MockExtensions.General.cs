using System;
using System.Collections.Generic;
using System.Linq;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class part for general purposes.
    /// </summary>
    public static partial class MockExtensions
    {
        /// <summary>
        /// Creates a mock of the specified type.
        /// </summary>
        /// <param name="type"> The type to create a mock for. </param>
        /// <param name="parameters"> The parameters to pass to the constructor if the type is a class. </param>
        /// <returns> The created mock. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="type" /> is <see langword="null" />. </exception>
        public static Mock CreateMock(this Type type, params object[] parameters)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            return (Mock)Activator.CreateInstance(typeof(Mock<>).MakeGenericType(type), parameters);
        }

        /// <summary>
        /// Creates a mock of the specified type.
        /// </summary>
        /// <param name="type"> The type to create a mock for. </param>
        /// <param name="mockBehavior"> The behavior of the mock. </param>
        /// <param name="parameters"> The parameters to pass to the constructor if the type is a class. </param>
        /// <returns> The created mock. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="type" /> is <see langword="null" />. </exception>
        public static Mock CreateMock(this Type type, MockBehavior mockBehavior, params object[] parameters)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            return (Mock)Activator.CreateInstance(typeof(Mock<>).MakeGenericType(type), mockBehavior, parameters);
        }

        /// <summary>
        /// Gets the objects for the specified enumerable of mocks.
        /// </summary>
        /// <typeparam name="TElement"> The type of the element. </typeparam>
        /// <param name="mockEnumerable"> The mock enumerable. </param>
        /// <returns> The enumeration of objects. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mockEnumerable" /> is <see langword="null" />. </exception>
        public static IEnumerable<TElement> Objects<TElement>(this IEnumerable<Mock<TElement>> mockEnumerable)
            where TElement : class
        {
            if (mockEnumerable == null)
            {
                throw new ArgumentNullException(nameof(mockEnumerable));
            }

            return mockEnumerable.Select(x => x.Object);
        }
    }
}