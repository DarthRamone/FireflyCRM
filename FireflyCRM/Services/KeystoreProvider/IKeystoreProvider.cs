namespace FireflyCRM.Services.KeystoreProvider
{
  public interface IKeystoreProvider
  {
    string SecretKey { get; }
    
    string MerchantId { get; }
  }
}