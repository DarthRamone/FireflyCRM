using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace FireflyCRM.Services.KeystoreProvider
{
  public class KeystoreProvider : IKeystoreProvider
  { 
    public string SecretKey { get; }
    
    public string TestSecretKey { get; }
    
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
        
        SecretKey = keys.SecretKey;
        TestSecretKey = keys.TestSecretKey;
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