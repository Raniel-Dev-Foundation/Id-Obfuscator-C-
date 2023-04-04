using HashidsNet;

public class IdObfuscator : IIdObfuscator
{
  private static readonly Hashids _hashIds = new Hashids(salt: "ID-SALT-STRING", minHashLength: 5);
  
  public string Encode (int id)
  {
    return _hashIds.Encode(id);
  }
  
  public int Decode(string encodedId)
  {
    var decoded = _hashIds.Decode(encodedId);
    return decoded[0];
  }
}
