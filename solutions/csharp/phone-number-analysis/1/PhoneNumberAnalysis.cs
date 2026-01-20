public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        // Should return 3 pieces of data: isNewYork, Check if fake, and the last 4 digits.
        // Extract the parts
        string areaCode = phoneNumber.Substring(0, 3);
        string prefix = phoneNumber.Substring(4, 3);
        string localNumber = phoneNumber.Substring(8, 4);
        
        // Check conditions
        bool isNewYork = areaCode == "212";
        bool isFake = prefix == "555";
        
        // Return as a tuple
        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
