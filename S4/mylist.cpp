#include <iostream>
#include <stdlib.h>
using namespace std;

class MyList 
{
public:
    int m_size;
    int* m_Pnums;

    MyList(int size, int* nums) : m_size(size) 
    {
        m_Pnums = (int*)malloc(sizeof(int) * size);
        for (int i = 0; i < m_size; i++) 
        {
            m_Pnums[i] = nums[i];
        }
    }

    void append(int x) 
    {
        resize(m_size + 1);
        m_Pnums[m_size - 1] = x;
    }

    void remove(int y) 
    {
        int index = -1;
        for (int i = 0; i < m_size; i++) 
        {
            if (m_Pnums[i] == y) 
            {
                index = i;
            }
        }
        if (index == -1) return;

        for (int i = index; i < m_size - 1; i++) 
        {
            m_Pnums[i] = m_Pnums[i + 1];
        }

        resize(m_size - 1);
    }

    int count(int x) 
    {
        int count = 0;
        for (int i = 0; i < m_size; i++) 
        {
            if (m_Pnums[i] == x) 
            {
                count++;
            }
        }
        return count;
    }

    void print() 
    {
        for (int i = 0; i < m_size; i++) 
        {
            cout << m_Pnums[i] << " ";
        }
        cout << endl;
    }

private:
    void resize(int newsize) 
    {
        int* newMem = (int*)malloc(sizeof(int) * newsize);
        for (int i = 0; i < min(m_size, newsize); i++) 
        {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_size = newsize;
        m_Pnums = newMem;
    }
};

int main() {
    int nums[6] = {1, 2, 3, 4, 5, 3};
    MyList m(6, nums);
    m.append(3);
    m.print();

    cout << "Count of 3: " << m.count(3) << endl;
    m.remove(3);
    m.print();

    cout << "Count of 3: " << m.count(3) << endl;
}
