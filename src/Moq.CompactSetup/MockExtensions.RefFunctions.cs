using System;
using System.Linq.Expressions;

namespace Moq.CompactSetup.Delegates
{
    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref1Func1<TParameter1, out TResult>(out TParameter1 parameter1);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref1Func2<TParameter1, out TResult>(ref TParameter1 parameter1);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func1<TParameter1, in TParameter2, out TResult>(out TParameter1 parameter1, TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func2<TParameter1, in TParameter2, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func3<in TParameter1, TParameter2, out TResult>(TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func4<TParameter1, TParameter2, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func5<TParameter1, TParameter2, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func6<in TParameter1, TParameter2, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func7<TParameter1, TParameter2, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref2Func8<TParameter1, TParameter2, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func1<TParameter1, in TParameter2, in TParameter3, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func2<TParameter1, in TParameter2, in TParameter3, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func3<in TParameter1, TParameter2, in TParameter3, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func4<TParameter1, TParameter2, in TParameter3, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func5<TParameter1, TParameter2, in TParameter3, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func6<in TParameter1, TParameter2, in TParameter3, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func7<TParameter1, TParameter2, in TParameter3, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func8<TParameter1, TParameter2, in TParameter3, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func9<in TParameter1, in TParameter2, TParameter3, out TResult>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func10<TParameter1, in TParameter2, TParameter3, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func11<TParameter1, in TParameter2, TParameter3, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func12<in TParameter1, TParameter2, TParameter3, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func13<TParameter1, TParameter2, TParameter3, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func14<TParameter1, TParameter2, TParameter3, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func15<in TParameter1, TParameter2, TParameter3, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func16<TParameter1, TParameter2, TParameter3, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func17<TParameter1, TParameter2, TParameter3, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func18<in TParameter1, in TParameter2, TParameter3, out TResult>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func19<TParameter1, in TParameter2, TParameter3, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func20<TParameter1, in TParameter2, TParameter3, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func21<in TParameter1, TParameter2, TParameter3, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func22<TParameter1, TParameter2, TParameter3, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func23<TParameter1, TParameter2, TParameter3, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func24<in TParameter1, TParameter2, TParameter3, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func25<TParameter1, TParameter2, TParameter3, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref3Func26<TParameter1, TParameter2, TParameter3, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func1<TParameter1, in TParameter2, in TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func2<TParameter1, in TParameter2, in TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func3<in TParameter1, TParameter2, in TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func4<TParameter1, TParameter2, in TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func5<TParameter1, TParameter2, in TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func6<in TParameter1, TParameter2, in TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func7<TParameter1, TParameter2, in TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func8<TParameter1, TParameter2, in TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func9<in TParameter1, in TParameter2, TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func10<TParameter1, in TParameter2, TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func11<TParameter1, in TParameter2, TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func12<in TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func13<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func14<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func15<in TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func16<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func17<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func18<in TParameter1, in TParameter2, TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func19<TParameter1, in TParameter2, TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func20<TParameter1, in TParameter2, TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func21<in TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func22<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func23<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func24<in TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func25<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func26<TParameter1, TParameter2, TParameter3, in TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func27<in TParameter1, in TParameter2, in TParameter3, TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func28<TParameter1, in TParameter2, in TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func29<TParameter1, in TParameter2, in TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func30<in TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func31<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func32<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func33<in TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func34<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func35<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func36<in TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func37<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func38<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func39<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func40<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func41<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func42<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func43<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func44<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func45<in TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func46<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func47<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func48<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func49<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func50<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func51<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func52<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func53<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func54<in TParameter1, in TParameter2, in TParameter3, TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func55<TParameter1, in TParameter2, in TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func56<TParameter1, in TParameter2, in TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func57<in TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func58<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func59<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func60<in TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func61<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func62<TParameter1, TParameter2, in TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func63<in TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func64<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func65<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func66<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func67<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func68<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func69<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func70<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func71<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func72<in TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func73<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func74<TParameter1, in TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func75<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func76<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func77<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func78<in TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func79<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TResult"> The type of the result. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <returns> The result. </returns>
    public delegate TResult Ref4Func80<TParameter1, TParameter2, TParameter3, TParameter4, out TResult>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

}

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class part for predefined ref values selector functions.
    /// </summary>
    public static partial class MockExtensions
    {
  
        /// <summary>
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref1Func1<TParameter1, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref1Func2<TParameter1, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func1<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func2<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func3<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func4<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func5<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func6<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func7<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref2Func8<TParameter1, TParameter2, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func1<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func2<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func3<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func4<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func5<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func6<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func7<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func8<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func9<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func10<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func11<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func12<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func13<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func14<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func15<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func16<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func17<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func18<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func19<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func20<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func21<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func22<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func23<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func24<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func25<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref3Func26<TParameter1, TParameter2, TParameter3, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func1<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func2<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func3<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func4<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func5<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func6<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func7<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func8<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func9<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func10<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func11<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func12<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func13<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func14<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func15<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func16<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func17<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func18<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func19<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func20<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func21<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func22<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func23<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func24<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func25<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func26<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func27<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func28<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func29<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func30<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func31<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func32<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func33<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func34<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func35<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func36<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func37<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func38<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func39<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func40<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func41<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func42<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func43<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func44<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func45<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func46<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func47<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func48<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func49<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func50<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func51<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func52<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func53<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func54<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func55<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func56<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func57<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func58<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func59<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func60<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func61<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func62<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func63<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func64<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func65<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func66<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func67<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func68<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func69<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func70<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func71<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func72<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func73<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func74<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func75<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func76<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func77<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func78<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func79<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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
        /// Sets up a member with the specified value selector.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
        /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
        /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
        /// <typeparam name="TResult"> The type of the result. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="valueSelector"> The function returning the value for specified parameters. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="valueSelector"/> is <c>null</c>. </exception>
        public static Mock<TMockable> With<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TResult>(this Mock<TMockable> mock, Expression<Func<TMockable, TResult>> memberExpression, Delegates.Ref4Func80<TParameter1, TParameter2, TParameter3, TParameter4, TResult> valueSelector)
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

  
    }
} 