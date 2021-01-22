using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] numbers;
        

        public MyDictionary()
        {
            numbers = new T[0];
            
        }

        public void Add(T number)
        {
            T[] tempArray = numbers;
            

            numbers = new T[numbers.Length+1];
            

            for (int i = 0; i < tempArray.Length; i++)
            {
                numbers[i] = tempArray[i];
                
            }

            numbers[numbers.Length - 1] = number;
            
        }

        public int Lenght
        {
            get { return numbers.Length; }
        }

        public T[] Numbers
        {
            get { return numbers; }
        }

      

    }


    

    
}
