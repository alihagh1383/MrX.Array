using System.Text;

namespace MrX.Array
{
    public class Array2D<T>
    {
        public T[,] Array;
        public int Row;
        public int Column;
        public Array2D(int row, int col)
        {
            Array = new T[row, col];
            Row = row;
            Column = col;
        }
        public void ResizeArray(int rows, int cols)
        {

            T[,] newArray = new T[rows, rows];
            int mMin = Math.Min(Array.GetLength(0), newArray.GetLength(0));
            int nMin = Math.Min(Array.GetLength(1), newArray.GetLength(1));

            for (int i = 0; i < mMin; i++)
                System.Array.Copy(Array, i * Array.GetLength(1), newArray, i * newArray.GetLength(1), nMin);
            Array = newArray;
            Row = rows;
            Column = cols;
        }
        public void ResizeArrayRows(int rows)
        {
            int Cols = Array.GetLength(1);
            int minRows = Math.Min(rows, Array.GetLength(0));

            var newArray = new T[rows, Cols];
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < Cols; j++)
                    newArray[i, j] = Array[i, j];
            Array = newArray;
            Row = rows;
        }
        public void ResizeArrayCols(int cols)
        {
            int Rows = Array.GetLength(0);
            int minCols = Math.Min(cols, Array.GetLength(1));

            var newArray = new T[Rows, cols];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = Array[i, j];
            Array = newArray;
            Column = cols;
        }

    }
}
