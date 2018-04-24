using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    /*
     * - Interfaces in C# provide a way to achieve run-time polymorphism.
     * - An Interface is defined as a syntactical contract that all the 
     *   classes inheriting the interface should follow.
     * - The interface defines the 'WHAT' part of the syntactical contract
     *   and the deriving classes define the 'HOW' part.
     * - Interfaces define properties, methods, and events which are members
     *   of the interface
     * - Interfaces are the ultimate abstraction.
     * /
    internal interface IDataMapper<T>
    {
        /*
         * T in <T>
         * A generic type parameter allows you to specify an 
         * arbitrary type "T" to a method a compile-time, without
         * specifying a concrete type in the method or class
         * declaration
         * 
         */

        List<T> Select();
        List<T> Find(string LastName);
    }
}
