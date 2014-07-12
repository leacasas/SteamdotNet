using System;

namespace SteamdotNet.Exceptions
{
    /// <summary>
    /// Exception thrown when the an invalid Steam developer key
    /// is provided whenever requested.
    /// </summary>
    [Serializable]
    public sealed class InvalidDeveloperKeyException : Exception
    {
        public override string Message
        {
            get { return "The key entered is invalid."; }
        }
    }
}