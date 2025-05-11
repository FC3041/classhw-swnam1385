public class Sezar
{
    private int Shift { get; set;}
    public Sezar(int shift)
    {Shift = shift;}
    public static implicit operator string(Sezar cipher)
    {
        return cipher.ToString();}
    public static explicit operator Sezar(string encryptedText)
    {
        var cipher = new Sezar(3);
        return cipher;}
    public string Encrypt(string plainText)
    {
        if (plainText == null) return null;
        
        char[] result = new char[plainText.Length];
        
        for (int i = 0; i < plainText.Length; i++)
        {
            char c = plainText[i];
            
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result[i] = (char)(((c + Shift - offset) % 26) + offset);
            }
            else
            {
                result[i] = c;
            }
        }
        
        return new string(result);
    }
    




    public string Decrypt(string encryptedText)
    {
        if (encryptedText == null) return null;
        
        char[] result = new char[encryptedText.Length];
        
        for (int i = 0; i < encryptedText.Length; i++)
        {
            char c = encryptedText[i];
            
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result[i] = (char)(((c - Shift - offset + 26) % 26) + offset);
            }
            else
            {
                result[i] = c;
            }
        }
        
        return new string(result);
    }

    public override string ToString()
    {
        return $"Sezar with shift: {Shift}";
    }
}