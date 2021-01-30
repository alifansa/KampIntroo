using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    //Burda kendi sınıfımızı oluşturarak Collectionsları yazdık. Collectionsların mantığı bu şekilde.
    class MyList<T> //T =optional ancak T genel yazım
    {
        T[] items;
        
        //Constructor yaptı
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // yukarda T olarak tanımlanan tür (string,int vs.olabilir.)
        {
            T[] tempArray = items;  //Öğeler tempArray'e tutturuldu.Referansım ucmasın diye referansımı tutuyorum
            items = new T[items.Length + 1];//Dizinin şuan ki değeri (0) +1 denmiş oldu.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];// tempArray'a tutturulan öğeler geri items'a  alındı.Items eski değerlerini geri aldı yani.
            }

            items[items.Length - 1] = item;//Eklemek için yer açılan öğe eklendi.For döngüsünün dışında yazılacak.

            
        }

        public int Length
        {
            get { return items.Length; }
        }
    }
}
