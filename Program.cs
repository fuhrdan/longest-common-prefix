// My original program was similar to this, but I declared my own variable instead of using the strs variable.
// When I submitted it to Leetcode it had errors I could not overcome.
//  So I looked up what others did.
// It did not occur to me to use the string passed into the function, so I did learn something valuable.

char* longestCommonPrefix(char** strs, int strsSize) {
    int i = 0;
    int n = 0;
    char c;

    if (strsSize == 0) return "";

    while(c = strs[0][n])
    {
        for(i = 1; i < strsSize; i++)
        {
            if(strs[i][n] != c)
            {
                strs[0][n] = 0;
                return strs[0];
            }
        }
        n++;
    }
    strs[0][n] = 0;
    return strs[0];
}