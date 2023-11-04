namespace Factory
{
    public class FactoryUps : FactoryResolveLatestShippingStatus
    {
        /// <summary>
        ///         
        /// </summary>
        public override string ResolveLatestShippingStatus(string aTN)
        {
            return $"Resolved shipping status for UPS package: {aTN}";
        }
    }
}
