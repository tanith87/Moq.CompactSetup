using System;
using System.Linq.Expressions;

namespace Moq.CompactSetup.Delegates
{
    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    public delegate void Ref1Action1<TParameter1>(out TParameter1 parameter1);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    public delegate void Ref1Action2<TParameter1>(ref TParameter1 parameter1);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action1<TParameter1, in TParameter2>(out TParameter1 parameter1, TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action2<TParameter1, in TParameter2>(ref TParameter1 parameter1, TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action3<in TParameter1, TParameter2>(TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action4<TParameter1, TParameter2>(out TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action5<TParameter1, TParameter2>(ref TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action6<in TParameter1, TParameter2>(TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action7<TParameter1, TParameter2>(out TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Ref2Action8<TParameter1, TParameter2>(ref TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action1<TParameter1, in TParameter2, in TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action2<TParameter1, in TParameter2, in TParameter3>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action3<in TParameter1, TParameter2, in TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action4<TParameter1, TParameter2, in TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action5<TParameter1, TParameter2, in TParameter3>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action6<in TParameter1, TParameter2, in TParameter3>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action7<TParameter1, TParameter2, in TParameter3>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action8<TParameter1, TParameter2, in TParameter3>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action9<in TParameter1, in TParameter2, TParameter3>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action10<TParameter1, in TParameter2, TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action11<TParameter1, in TParameter2, TParameter3>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action12<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action13<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action14<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action15<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action16<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action17<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action18<in TParameter1, in TParameter2, TParameter3>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action19<TParameter1, in TParameter2, TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action20<TParameter1, in TParameter2, TParameter3>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action21<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action22<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action23<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action24<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action25<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Ref3Action26<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action1<TParameter1, in TParameter2, in TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action2<TParameter1, in TParameter2, in TParameter3, in TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action3<in TParameter1, TParameter2, in TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action4<TParameter1, TParameter2, in TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action5<TParameter1, TParameter2, in TParameter3, in TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action6<in TParameter1, TParameter2, in TParameter3, in TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action7<TParameter1, TParameter2, in TParameter3, in TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action8<TParameter1, TParameter2, in TParameter3, in TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action9<in TParameter1, in TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action10<TParameter1, in TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action11<TParameter1, in TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action12<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action13<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action14<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action15<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action16<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action17<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action18<in TParameter1, in TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action19<TParameter1, in TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action20<TParameter1, in TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action21<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action22<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action23<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action24<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action25<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action26<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action27<in TParameter1, in TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action28<TParameter1, in TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action29<TParameter1, in TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action30<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action31<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action32<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action33<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action34<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action35<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action36<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action37<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action38<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action39<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action40<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action41<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action42<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action43<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action44<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action45<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action46<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action47<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action48<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action49<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action50<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action51<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action52<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action53<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action54<in TParameter1, in TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action55<TParameter1, in TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action56<TParameter1, in TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action57<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action58<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action59<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action60<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action61<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action62<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action63<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action64<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action65<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action66<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action67<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action68<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action69<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action70<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action71<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action72<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action73<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action74<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action75<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action76<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action77<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action78<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action79<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    public delegate void Ref4Action80<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

}

namespace Moq.CompactSetup
{
    /// <summary>
    /// The mock extensions class part for predefined ref callbacks.
    /// </summary>
    public static partial class MockExtensions
    {
  
        /// <summary>
        /// Sets up a member with the specified callback action.
        /// </summary>
        /// <typeparam name="TMockable"> The type of the mockable class or interface. </typeparam>
        /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
        /// <param name="mock"> The mock. </param>
        /// <param name="memberExpression"> The member expression to set up. </param>
        /// <param name="action"> The action to call when the member is utilized. </param>
        /// <returns> The same mock again. </returns>
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref1Action1<TParameter1> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref1Action2<TParameter1> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action1<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action2<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action3<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action4<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action5<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action6<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action7<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref2Action8<TParameter1, TParameter2> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action1<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action2<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action3<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action4<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action5<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action6<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action7<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action8<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action9<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action10<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action11<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action12<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action13<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action14<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action15<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action16<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action17<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action18<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action19<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action20<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action21<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action22<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action23<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action24<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action25<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref3Action26<TParameter1, TParameter2, TParameter3> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action1<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action2<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action3<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action4<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action5<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action6<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action7<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action8<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action9<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action10<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action11<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action12<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action13<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action14<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action15<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action16<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action17<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action18<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action19<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action20<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action21<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action22<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action23<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action24<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action25<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action26<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action27<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action28<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action29<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action30<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action31<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action32<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action33<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action34<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action35<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action36<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action37<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action38<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action39<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action40<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action41<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action42<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action43<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action44<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action45<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action46<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action47<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action48<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action49<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action50<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action51<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action52<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action53<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action54<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action55<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action56<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action57<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action58<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action59<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action60<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action61<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action62<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action63<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action64<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action65<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action66<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action67<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action68<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action69<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action70<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action71<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action72<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action73<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action74<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action75<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action76<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action77<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action78<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action79<TParameter1, TParameter2, TParameter3, TParameter4> action)
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
        /// <exception cref="ArgumentNullException"> When <paramref name="mock"/>, <paramref name="memberExpression"/> or <paramref name="action"/> is <see langword="null"/>. </exception>
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Delegates.Ref4Action80<TParameter1, TParameter2, TParameter3, TParameter4> action)
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