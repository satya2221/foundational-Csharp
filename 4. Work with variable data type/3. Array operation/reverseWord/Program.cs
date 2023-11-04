string pangram = "The quick brown fox jumps over the lazy dog";
string[] wordList = pangram.Split(' ');

for(int index=0; index < wordList.Length; index++)
{
    string word = wordList[index];
    char[] letters = word.ToCharArray();
    Array.Reverse(letters);
    string reversedWord = new string(letters);
    wordList[index] = reversedWord;
}

string reversedPangram = string.Join(" ", wordList);
Console.WriteLine(reversedPangram);

