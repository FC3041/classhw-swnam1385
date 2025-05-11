#include <iostream>
#include <cstdlib>

using namespace std;

class MyStr 
{
public:
    int m_size;
    char* m_PChars;

    MyStr() : m_size(0), m_PChars(nullptr) {}

    MyStr(const char* chars) 
    {
        int i;
        for (i = 0; chars[i] != '\0'; i++);
        m_size = i;

        m_PChars = new char[m_size + 1];
        for (i = 0; i <= m_size; i++) 
        {
            m_PChars[i] = chars[i];
        }
    }

    MyStr(const char* chars, int start, int count) : m_size(count) 
    {
        m_PChars = new char[m_size + 1];

        for (int i = 0; i < m_size; i++) 
        {
            m_PChars[i] = chars[start + i];
        }
        m_PChars[count] = '\0';
    }

    ~MyStr() {
        delete[] m_PChars;
    }

    void printStr() 
    {
        cout << m_PChars << endl;
    }

    int len() 
    {
        int len = 0;
        while (m_PChars[len] != '\0') 
        {
            len++;
        }
        return len;
    }

    int leng(const char* str) 
    {
        int len = 0;
        while (str[len] != '\0') 
        {
            len++;
        }
        return len;
    }

    bool checksubstr(const char* str) 
    {
        int len = leng(str);
        int ty = len();
        for (int i = 0; i <= ty - len; i++) 
        {
            bool found = true;
            for (int s = 0; s < len; s++) {
                if (str[s] != m_PChars[i + s]) 
                {
                    found = false;
                    break;
                }
            }
            if (found) 
            {
                return true;
            }
        }
        return false;
    }

    void test(const char* str) 
    {
        if (checksubstr(str)) 
        {
            cout << "second exist in first" << endl;
        } else 
        {
            cout << "second doesnt exist in first" << endl;
        }
    }

    void add(const MyStr& other) 
    {
        int newsize = m_size + other.len();
        char* chars = new char[newsize + 1];
        for (int i = 0; i < m_size; i++) 
        {
            chars[i] = m_PChars[i];
        }
        for (int i = 0; i < other.len(); i++) 
        {
            chars[i + m_size] = other.m_PChars[i];
        }
        chars[newsize] = '\0';
        delete[] m_PChars;
        m_PChars = chars;
        m_size = newsize;
    }
};

int main() 
{
    MyStr s1("ezafe kon ino be s2");
    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();
    s1.add(s2);
    s1.printStr();
    s2.len();
    return 0;
}