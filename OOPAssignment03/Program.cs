using System.Text;

namespace OOPAssignment03
{    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // (A) Overloading: Same method name, but different parameters in the same class.
            //      Overriding: A child class changes the method of the parent class.

            // (B) Static Binding: The method to call is decided at compile time.
            //      Dynamic Binding: The method to call is decided at runtime.
            #endregion

            #region Question02
            // (A) sealed on a class prevents any other class from inheriting from it.


            // (B) A sealed class blocks inheritance from the entire class. A sealed method only blocks that specific overridden method from being overridden again further down the hierarchy — the class itself can still be inherited


            //  (C)  No, it cannot be overridden again. Once a method is marked sealed override, it stops the override chain — no further derived class can override it.
            #endregion
        }
    }
}   