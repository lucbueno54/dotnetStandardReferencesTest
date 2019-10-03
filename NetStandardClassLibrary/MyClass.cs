using AnotherStandardClassLibrary;
using FrameworkClassLibrary;
using System;

namespace NetStandardClassLibrary
{
    public class MyClass : BaseClass
    {
        public DateTime MyDate { get; set; }
        public AnotherClass MyProperty { get; set; }
    }
}
