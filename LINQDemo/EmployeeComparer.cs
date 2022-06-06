using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LINQDemo
{
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        bool IEqualityComparer<Employee>.Equals(Employee x, Employee y)
        {
            return x.Id == y.Id && x.Name == y.Name;
        }

        int IEqualityComparer<Employee>.GetHashCode(Employee obj)
        {
            return obj.Id.GetHashCode() ^ obj.Name.GetHashCode();
        }
    }
}
