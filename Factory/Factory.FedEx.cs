namespace Factory
{
    public class FactoryFedEx : FactoryResolveLatestShippingStatus
    {
        /// <summary>
        ///         
        /// </summary>
        public override string ResolveLatestShippingStatus(string aTN)
        {
            return $"Resolved shipping status for FedEx package: {aTN}";
        }
    }
}
