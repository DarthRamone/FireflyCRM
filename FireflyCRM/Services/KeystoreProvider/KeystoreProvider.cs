using System;
using System.IO;
using System.Linq;
using System.Reflection;
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
      var assembly = typeof(KeystoreProvider).GetTypeInfo().Assembly;

      var resourcesFiles = assembly.GetManifestResourceNames().ToList();
            
      var keysPath = resourcesFiles.FirstOrDefault(path => path.EndsWith("keys.json", StringComparison.InvariantCulture));

      
      using (var file = assembly.GetManifestResourceStream(keysPath))
      using (var reader = new StreamReader(file))
      {
        var text = reader.ReadToEnd();
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