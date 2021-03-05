using Core.Utilities.Results;

namespace Business.Concrete
{
    internal class SuccesResult : IResult
    {
        private string productAdded;

        public SuccesResult(string productAdded)
        {
            this.productAdded = productAdded;
        }
    }
}