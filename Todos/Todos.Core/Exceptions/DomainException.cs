﻿using System;

namespace Todos.Core.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException() : base()
        {
        }

        public DomainException(string message) : base(message)
        {
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}