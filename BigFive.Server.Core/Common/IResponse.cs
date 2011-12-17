namespace BigFive.Server.Core.Common
{
    public interface IResponse
    {
      
        string Statement { get; set; }
        int Value { get; set; }
    }
}