using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}