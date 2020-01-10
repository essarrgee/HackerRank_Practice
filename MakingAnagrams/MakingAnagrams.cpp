#include <bits/stdc++.h>

using namespace std;

// Complete the makeAnagram function below.
int makeAnagram(string a, string b) {

    int deletion = 0;
    map<char, int> aCount;
    map<char, int> bCount;

    for (int i=0; i<a.length(); i++) {
        aCount[a[i]]++;
    }

    for (int i=0; i<b.length(); i++) {
        bCount[b[i]]++;
    }

    for (int i=0; i<a.length(); i++) {
        if (aCount[a[i]] > bCount[a[i]]) {
            aCount[a[i]]--;
            //a[i] = ' ';
            deletion++;
        }
    }
    //cout << a << endl;

    for (int i=0; i<b.length(); i++) {
        if (bCount[b[i]] > aCount[b[i]]) {
            bCount[b[i]]--;
            //b[i] = ' ';
            deletion++;
        }
    }
    //cout << b << endl;

    return deletion;

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string a;
    getline(cin, a);

    string b;
    getline(cin, b);

    int res = makeAnagram(a, b);

    fout << res << "\n";

    fout.close();

    return 0;
}
