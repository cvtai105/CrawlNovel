using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Url
    {
        public string Value { get; private set; } = string.Empty;
        public Url(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Url cannot be empty");
            }
            Value = value;
        }

        public string GetData()
        {
            return string.Empty;
        }
    }
}