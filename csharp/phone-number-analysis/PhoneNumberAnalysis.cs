using System;
using System.Security.Cryptography.X509Certificates;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string prefix = phoneNumber[..3];
        bool IsNewYork = prefix == "212";

        string mid = phoneNumber[4..7];
        bool IsFake = mid == "555";

        var phoneNumberInfo = (IsNewYork, IsFake, phoneNumber[8..]);
        return phoneNumberInfo;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
