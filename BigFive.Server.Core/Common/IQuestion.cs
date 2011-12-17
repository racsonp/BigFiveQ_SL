namespace BigFive.Server.Core.Common
{
    public interface IQuestion
    {
        int Index { get; set; }
        string Statement { get; set; }
        
    }
}