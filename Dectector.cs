public bool CheckIfBTCAddress()
{
    var clipText = Clipboard.GetText();
    // Checks if clipText length is 26-35 characters long.
    if (Enumerable.Range(26, 35).Contains(clipText.Length) &&
        // If it is within that length, checks if it starts with either 1,3, or b.
        (clipText.StartsWith("1")) || (clipText.StartsWith("3")) || (clipText.ToLower().StartsWith("b")))
    {
        // Since each crypto address is extremely unique, these are all you need to properly identify most if not any btc address.
        return true;
    }
    else
        return false;
}
