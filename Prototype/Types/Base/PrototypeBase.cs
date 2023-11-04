namespace Prototype.Types.Base
{
    public interface IPrototypeBase
    {
        PrototypeBase Clone();
    }

    public abstract class PrototypeBase : IPrototypeBase
    {
        /// <summary>
        ///     Prorotype implementation
        /// </summary>
        public PrototypeBase Clone()
        {
            return (PrototypeBase)MemberwiseClone();
        }
    }
}
