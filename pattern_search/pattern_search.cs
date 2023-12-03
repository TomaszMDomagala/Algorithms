using System;

public class PatternSearch
{
    public static void search(char[] pat, char[] text)
    {
        int M = pat.Length;
        int N = text.Length;

        for (int i = 0; i <= N - M; i++) {
            int j;

            for (j = 0; j < M; j++) {
                if (text[i + j] != pat[j]) break;
            }

            if (j == M) {
                Console.WriteLine("Pattern found at index " + i);
            }
        }
    }

    static public void Main()
    {
        char[] text = "AABAACAADAABAAABAA".ToCharArray();
        char[] pat = "AABA".ToCharArray();

        search(pat, text);
    }
}