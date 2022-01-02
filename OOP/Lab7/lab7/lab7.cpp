
#include "ArithmeticExpression.h"
using namespace std;

int main()
{
    cout << "Olha Pavlushchenko, IS-02" << endl;
    cout << "Enter the number of elements in array: ";
    int num;
    cin >> num;
    ArithmeticExpression* array = new ArithmeticExpression[num];                       //array of objects
    for (int i = 0; i < num; i++)
    {
        double a, b, c, d;
        cout << i + 1 << " array:" << endl;
        cout << "Enter a:";
        cin >> a;
        cout << "Enter b:";
        cin >> b;
        cout << "Enter c:";
        cin >> c;
        cout << "Enter d:";
        cin >> d;
        array[i] = ArithmeticExpression(a, b, c, d);
        cout << endl;
    }
    
        for (int i = 0; i < num; i++)
        {
            try
            {
                array[i].ExpressionValue();
                cout << array[i].GetResult() << endl;
            }
            catch (overflow_error err)
            {
                cout << "Error:" << err.what() << endl;
            }
            catch (underflow_error e)
            {
                cout << "Error:" << e.what() << endl;
            }
        }   
    
}