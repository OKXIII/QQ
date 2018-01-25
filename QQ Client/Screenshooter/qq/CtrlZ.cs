using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;

namespace qq
{
    class CtrlZ
    {
        private Bitmap[] Image ;
        private int[] Array;
        private int countimages;

// конструктор
        public CtrlZ(int size)
        {
            countimages = 0;
            if (size == 0) size = 10;
           Image=new Bitmap[size];
            Array = new int[size];
        }

// добавление элемента
        public int Add (Bitmap Newimage)
        {
            if (countimages == Image.Length-1) Shift();
            Image[countimages] = (System.Drawing.Bitmap)Newimage.Clone();
            countimages++;
            return countimages;
        }

// получение элемента
        public Bitmap Get()
        {
            Bitmap Ret =null;
            if (countimages > 0)
            {
                countimages--;
                Ret = (System.Drawing.Bitmap)Image[countimages].Clone();
                Image[countimages] = null;
            }
            return Ret;
        }

//количество элементов в очереди
        public int Length()
        {
            return countimages;
        }

//очистка
        public void Clear()
        {
            countimages = 0;
        }

// сдвиг массива (удаление первого и освобождение последнего)
        private void Shift()
        {
            for (int i = 0; i < countimages-1; i++)
            {
                Image[i] = Image[i + 1];
            }
            countimages--;
        }




    }
}
