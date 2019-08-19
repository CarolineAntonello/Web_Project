namespace Web_Project.Domain.Base.Exceptions
{
    public class NotFoundException : DomainException
    {
        public NotFoundException() : base(CodigosDeErro.NotFound, "Registry not found") { }
    }
}
