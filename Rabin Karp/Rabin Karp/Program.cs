using System;

class RabinKarp
{
    static readonly int PRIME = 101; 

    static int Search(string text, string pattern)
    {
        int m = pattern.Length;
        int n = text.Length;
        int patternHash = 0, textHash = 0, h = 1;

        // The value of h would be "pow(d, m-1) % PRIME"
        for (int i = 0; i < m - 1; i++)
            h = (h * 256) % PRIME;

        // Calculate initial hash for pattern and first window of text
        for (int i = 0; i < m; i++)
        {
            patternHash = (256 * patternHash + pattern[i]) % PRIME;
            textHash = (256 * textHash + text[i]) % PRIME;
        }

        // Slide over the text
        for (int i = 0; i <= n - m; i++)
        {
            // Check if hash matches
            if (patternHash == textHash)
            {
                bool match = true;
                for (int j = 0; j < m; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i; // Match found, return index
            }

            // Compute next hash (Rolling Hash)
            if (i < n - m)
            {
                textHash = (256 * (textHash - text[i] * h) + text[i + m]) % PRIME;

                // Ensure positive hash value
                if (textHash < 0)
                    textHash += PRIME;
            }
        }
        return -1; // Pattern not found
    }

    static void Main()
    {
        string text = "ABABDABACDABABCABAB";
        string pattern = "ABABCABAB";

        int index = Search(text, pattern);
        Console.WriteLine(index != -1 ? $"Pattern found at index {index}" : "Pattern not found");
    }
}
