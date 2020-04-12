// Example program
#include <iostream>

int strcmp(const char *s1, const char *s2) {
// return 1 if s1 is greater, -1 if s2 is greater, 0 if equal

    int i = 0;
    bool next = true;
    while (next) {
        // If equal, continue comparing each character
        if (!s1[i] || s1[i] < s2[i]) {
            return -1;
        }
        else if (!s2[i] || s1[i] > s2[i]) {
            return 1;
        }
        if (!s1[i+1] && !s2[i+1]) {
            next = false;
        }
        i++;
    }
    return 0;
}

int main()
{
   std::cout << strcmp("lol", "loll");
}