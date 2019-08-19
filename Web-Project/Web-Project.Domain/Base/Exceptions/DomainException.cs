using System;

namespace Web_Project.Domain.Base.Exceptions
{
    public abstract class DomainException : Exception
    {
        private string v;

        public DomainException(CodigosDeErro codigosDeErro, string message) : base(message)
        {
            CodigosDeErro = codigosDeErro;
        }

        protected DomainException(string v)
        {
            this.v = v;
        }

        public CodigosDeErro CodigosDeErro { get; }
    }
}
