using System;
using System.Linq.Expressions;
using Moq;

namespace Moq.CompactSetup
{
    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    public delegate void Out1Action1<TParameter1>(out TParameter1 parameter1);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    public delegate void Out1Action2<TParameter1>(ref TParameter1 parameter1);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action1<TParameter1, in TParameter2>(out TParameter1 parameter1, TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action2<TParameter1, in TParameter2>(ref TParameter1 parameter1, TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action3<in TParameter1, TParameter2>(TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action4<TParameter1, TParameter2>(out TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action5<TParameter1, TParameter2>(ref TParameter1 parameter1, out TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action6<in TParameter1, TParameter2>(TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action7<TParameter1, TParameter2>(out TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    public delegate void Out2Action8<TParameter1, TParameter2>(ref TParameter1 parameter1, ref TParameter2 parameter2);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action1<TParameter1, in TParameter2, in TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action2<TParameter1, in TParameter2, in TParameter3>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action3<in TParameter1, TParameter2, in TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action4<TParameter1, TParameter2, in TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action5<TParameter1, TParameter2, in TParameter3>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action6<in TParameter1, TParameter2, in TParameter3>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action7<TParameter1, TParameter2, in TParameter3>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action8<TParameter1, TParameter2, in TParameter3>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action9<in TParameter1, in TParameter2, TParameter3>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action10<TParameter1, in TParameter2, TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action11<TParameter1, in TParameter2, TParameter3>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action12<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action13<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action14<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action15<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action16<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action17<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action18<in TParameter1, in TParameter2, TParameter3>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action19<TParameter1, in TParameter2, TParameter3>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action20<TParameter1, in TParameter2, TParameter3>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action21<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action22<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action23<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action24<in TParameter1, TParameter2, TParameter3>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action25<TParameter1, TParameter2, TParameter3>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    public delegate void Out3Action26<TParameter1, TParameter2, TParameter3>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3);

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
    public delegate void Out4Action1<TParameter1, in TParameter2, in TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action2<TParameter1, in TParameter2, in TParameter3, in TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action3<in TParameter1, TParameter2, in TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action4<TParameter1, TParameter2, in TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action5<TParameter1, TParameter2, in TParameter3, in TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action6<in TParameter1, TParameter2, in TParameter3, in TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action7<TParameter1, TParameter2, in TParameter3, in TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action8<TParameter1, TParameter2, in TParameter3, in TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action9<in TParameter1, in TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action10<TParameter1, in TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action11<TParameter1, in TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action12<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action13<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action14<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action15<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action16<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action17<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action18<in TParameter1, in TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action19<TParameter1, in TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action20<TParameter1, in TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action21<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action22<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action23<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action24<in TParameter1, TParameter2, TParameter3, in TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action25<TParameter1, TParameter2, TParameter3, in TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action26<TParameter1, TParameter2, TParameter3, in TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4);

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
    public delegate void Out4Action27<in TParameter1, in TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action28<TParameter1, in TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action29<TParameter1, in TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action30<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action31<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action32<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action33<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action34<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action35<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action36<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action37<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action38<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action39<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action40<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action41<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action42<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action43<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action44<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action45<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action46<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action47<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action48<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action49<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action50<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action51<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action52<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action53<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4);

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
    public delegate void Out4Action54<in TParameter1, in TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action55<TParameter1, in TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action56<TParameter1, in TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action57<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action58<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action59<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action60<in TParameter1, TParameter2, in TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action61<TParameter1, TParameter2, in TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action62<TParameter1, TParameter2, in TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action63<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action64<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action65<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action66<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action67<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action68<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action69<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action70<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action71<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action72<in TParameter1, in TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action73<TParameter1, in TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action74<TParameter1, in TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action75<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action76<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action77<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action78<in TParameter1, TParameter2, TParameter3, TParameter4>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action79<TParameter1, TParameter2, TParameter3, TParameter4>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

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
    public delegate void Out4Action80<TParameter1, TParameter2, TParameter3, TParameter4>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action1<TParameter1, in TParameter2, in TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action2<TParameter1, in TParameter2, in TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action3<in TParameter1, TParameter2, in TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action4<TParameter1, TParameter2, in TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action5<TParameter1, TParameter2, in TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action6<in TParameter1, TParameter2, in TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action7<TParameter1, TParameter2, in TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action8<TParameter1, TParameter2, in TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action9<in TParameter1, in TParameter2, TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action10<TParameter1, in TParameter2, TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action11<TParameter1, in TParameter2, TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action12<in TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action13<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action14<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action15<in TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action16<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action17<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action18<in TParameter1, in TParameter2, TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action19<TParameter1, in TParameter2, TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action20<TParameter1, in TParameter2, TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action21<in TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action22<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action23<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action24<in TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action25<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action26<TParameter1, TParameter2, TParameter3, in TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action27<in TParameter1, in TParameter2, in TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action28<TParameter1, in TParameter2, in TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action29<TParameter1, in TParameter2, in TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action30<in TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action31<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action32<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action33<in TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action34<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action35<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action36<in TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action37<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action38<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action39<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action40<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action41<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action42<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action43<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action44<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action45<in TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action46<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action47<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action48<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action49<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action50<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action51<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action52<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action53<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action54<in TParameter1, in TParameter2, in TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action55<TParameter1, in TParameter2, in TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action56<TParameter1, in TParameter2, in TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action57<in TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action58<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action59<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action60<in TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action61<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action62<TParameter1, TParameter2, in TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action63<in TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action64<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action65<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action66<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action67<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action68<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action69<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action70<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action71<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action72<in TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action73<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action74<TParameter1, in TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action75<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action76<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action77<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action78<in TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action79<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action80<TParameter1, TParameter2, TParameter3, TParameter4, in TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action81<in TParameter1, in TParameter2, in TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action82<TParameter1, in TParameter2, in TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action83<TParameter1, in TParameter2, in TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action84<in TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action85<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action86<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action87<in TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action88<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action89<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action90<in TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action91<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action92<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action93<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action94<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action95<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action96<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action97<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action98<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action99<in TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action100<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action101<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action102<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action103<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action104<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action105<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action106<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action107<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action108<in TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action109<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action110<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action111<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action112<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action113<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action114<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action115<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action116<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action117<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action118<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action119<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action120<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action121<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action122<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action123<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action124<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action125<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action126<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action127<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action128<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action129<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action130<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action131<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action132<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action133<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action134<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action135<in TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action136<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action137<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action138<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action139<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action140<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action141<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action142<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action143<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action144<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action145<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action146<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action147<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action148<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action149<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action150<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action151<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action152<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action153<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action154<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action155<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action156<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action157<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action158<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action159<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action160<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action161<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, out TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action162<in TParameter1, in TParameter2, in TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action163<TParameter1, in TParameter2, in TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action164<TParameter1, in TParameter2, in TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action165<in TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action166<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action167<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action168<in TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action169<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action170<TParameter1, TParameter2, in TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action171<in TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action172<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action173<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action174<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action175<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action176<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action177<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action178<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action179<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action180<in TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action181<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action182<TParameter1, in TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action183<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action184<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action185<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action186<in TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action187<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action188<TParameter1, TParameter2, TParameter3, in TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action189<in TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action190<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action191<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action192<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action193<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action194<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action195<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action196<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action197<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action198<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action199<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action200<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action201<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action202<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action203<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action204<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action205<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action206<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action207<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action208<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action209<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action210<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action211<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action212<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action213<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action214<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action215<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, out TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action216<in TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action217<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action218<TParameter1, in TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action219<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action220<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action221<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action222<in TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action223<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action224<TParameter1, TParameter2, in TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action225<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action226<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action227<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action228<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action229<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action230<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action231<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action232<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action233<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, out TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action234<in TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action235<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action236<TParameter1, in TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action237<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action238<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action239<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, out TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action240<in TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action241<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(out TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);

    /// <summary>
    /// The signature for a method with in and out parameters.
    /// </summary>
    /// <typeparam name="TParameter1"> The type of the 1. parameter. </typeparam>
    /// <typeparam name="TParameter2"> The type of the 2. parameter. </typeparam>
    /// <typeparam name="TParameter3"> The type of the 3. parameter. </typeparam>
    /// <typeparam name="TParameter4"> The type of the 4. parameter. </typeparam>
    /// <typeparam name="TParameter5"> The type of the 5. parameter. </typeparam>
    /// <param name="parameter1"> The 1. parameter. </param>
    /// <param name="parameter2"> The 2. parameter. </param>
    /// <param name="parameter3"> The 3. parameter. </param>
    /// <param name="parameter4"> The 4. parameter. </param>
    /// <param name="parameter5"> The 5. parameter. </param>
    public delegate void Out5Action242<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(ref TParameter1 parameter1, ref TParameter2 parameter2, ref TParameter3 parameter3, ref TParameter4 parameter4, ref TParameter5 parameter5);


    /// <summary>
    /// The mock extensions class.
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out1Action1<TParameter1> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out1Action2<TParameter1> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action1<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action2<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action3<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action4<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action5<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action6<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action7<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out2Action8<TParameter1, TParameter2> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action1<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action2<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action3<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action4<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action5<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action6<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action7<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action8<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action9<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action10<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action11<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action12<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action13<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action14<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action15<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action16<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action17<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action18<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action19<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action20<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action21<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action22<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action23<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action24<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action25<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out3Action26<TParameter1, TParameter2, TParameter3> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action1<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action2<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action3<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action4<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action5<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action6<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action7<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action8<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action9<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action10<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action11<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action12<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action13<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action14<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action15<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action16<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action17<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action18<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action19<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action20<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action21<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action22<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action23<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action24<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action25<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action26<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action27<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action28<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action29<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action30<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action31<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action32<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action33<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action34<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action35<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action36<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action37<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action38<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action39<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action40<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action41<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action42<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action43<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action44<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action45<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action46<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action47<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action48<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action49<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action50<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action51<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action52<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action53<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action54<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action55<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action56<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action57<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action58<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action59<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action60<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action61<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action62<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action63<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action64<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action65<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action66<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action67<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action68<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action69<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action70<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action71<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action72<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action73<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action74<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action75<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action76<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action77<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action78<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action79<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out4Action80<TParameter1, TParameter2, TParameter3, TParameter4> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action1<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action2<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action3<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action4<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action5<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action6<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action7<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action8<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action9<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action10<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action11<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action12<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action13<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action14<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action15<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action16<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action17<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action18<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action19<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action20<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action21<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action22<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action23<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action24<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action25<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action26<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action27<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action28<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action29<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action30<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action31<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action32<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action33<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action34<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action35<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action36<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action37<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action38<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action39<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action40<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action41<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action42<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action43<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action44<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action45<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action46<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action47<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action48<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action49<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action50<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action51<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action52<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action53<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action54<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action55<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action56<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action57<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action58<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action59<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action60<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action61<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action62<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action63<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action64<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action65<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action66<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action67<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action68<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action69<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action70<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action71<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action72<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action73<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action74<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action75<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action76<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action77<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action78<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action79<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action80<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action81<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action82<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action83<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action84<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action85<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action86<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action87<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action88<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action89<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action90<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action91<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action92<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action93<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action94<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action95<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action96<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action97<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action98<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action99<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action100<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action101<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action102<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action103<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action104<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action105<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action106<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action107<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action108<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action109<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action110<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action111<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action112<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action113<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action114<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action115<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action116<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action117<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action118<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action119<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action120<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action121<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action122<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action123<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action124<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action125<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action126<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action127<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action128<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action129<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action130<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action131<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action132<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action133<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action134<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action135<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action136<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action137<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action138<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action139<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action140<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action141<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action142<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action143<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action144<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action145<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action146<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action147<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action148<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action149<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action150<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action151<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action152<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action153<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action154<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action155<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action156<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action157<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action158<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action159<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action160<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action161<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action162<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action163<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action164<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action165<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action166<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action167<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action168<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action169<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action170<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action171<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action172<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action173<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action174<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action175<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action176<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action177<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action178<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action179<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action180<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action181<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action182<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action183<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action184<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action185<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action186<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action187<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action188<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action189<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action190<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action191<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action192<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action193<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action194<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action195<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action196<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action197<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action198<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action199<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action200<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action201<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action202<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action203<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action204<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action205<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action206<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action207<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action208<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action209<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action210<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action211<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action212<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action213<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action214<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action215<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action216<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action217<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action218<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action219<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action220<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action221<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action222<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action223<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action224<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action225<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action226<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action227<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action228<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action229<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action230<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action231<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action232<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action233<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action234<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action235<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action236<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action237<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action238<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action239<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action240<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action241<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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
        public static Mock<TMockable> WithCallback<TMockable, TParameter1, TParameter2, TParameter3, TParameter4, TParameter5>(this Mock<TMockable> mock, Expression<Action<TMockable>> memberExpression, Out5Action242<TParameter1, TParameter2, TParameter3, TParameter4, TParameter5> action)
            where TMockable : class
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