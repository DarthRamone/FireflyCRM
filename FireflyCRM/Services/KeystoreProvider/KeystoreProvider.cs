using System.IO;
using Newtonsoft.Json;

namespace FireflyCRM.Services.KeystoreProvider
{
  public class KeystoreProvider : IKeystoreProvider
  {
    private const string PATH = "/Users/darthramone/Projects/FireflyCRM/FireflyCRM/Resources/keys.json"; 
    
    public string SecretKey { get; }
    
    public string MerchantId { get; }

    public KeystoreProvider()
    {
      using (var file = new StreamReader(PATH))
      {
        var text = file.ReadToEnd();
        var keys = JsonConvert.DeserializeObject<Keys>(text);

        MerchantId = keys.MerchantId;
        
        #if DEBUG
        SecretKey = keys.TestSecretKey;
        #else
        SecretKey = keys.SecretKey;
        #endif
      }
    }

    private class Keys
    {
      public string MerchantId { get; set; }
      
      public string SecretKey { get; set; }
      
      public string TestSecretKey { get; set; }
    }
  }
}