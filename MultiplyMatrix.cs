using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MultiplyMatrix
{
    public partial class MultiplyMatrix : Form
    {
        public MultiplyMatrix()
        {
            InitializeComponent();
            ArrayPowerOfTwo();
        }

        int rowsA = 0, columnsA = 0, last_columnA = 0;
        int rowsB = 0, columnsB = 0, last_columnB = 0;
        int rowsC = 0, columnsC = 0, last_columnC = 0;

        //  Проміжні змінні
        bool enter_SetA = false;            //  -   Матриця А заповнена
        bool enter_SetB = false;            //  -   Матриця В заповнена

        int[,] matrixA;                     //  -   Матриця А
        int[,] matrixB;                     //  -   Матриця В
        int[,] matrixC;                     //  -   Матриця С
        int[] arrayPowerOfTwo;              //  -   Масив степеня двійки


        long time;
        static Stopwatch stopwatch = new Stopwatch();


        private void btn_Set(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Button? clikedButton = sender as Button;

            if (clikedButton.Name == btn_SetA.Name)
            {
                int to_number_A = Convert.ToInt16(txtBox_to_A.Text);

                rowsA = Convert.ToInt16(rowA.Text);
                columnsA = Convert.ToInt16(columnA.Text);

                matrixA = new int[rowsA, columnsA];
                HeaderColumn_Filling(dataTable, columnsA, last_columnA);
                Random_Filling(matrixA, rowsA, columnsA, to_number_A);

                DataTable_Filling(dataTable, matrixA, rowsA, columnsA);
                DataGV_Filling(dataTable, dataGV_mxA, rowsA, columnsA);

                enter_SetA = true;
            }
            else if (clikedButton.Name == btn_SetB.Name)
            {
                int to_number_B = Convert.ToInt16(txtBox_to_B.Text);

                rowsB = Convert.ToInt16(rowB.Text);
                columnsB = Convert.ToInt16(columnB.Text);

                matrixB = new int[rowsB, columnsB];
                HeaderColumn_Filling(dataTable, columnsB, last_columnB);
                Random_Filling(matrixB, rowsB, columnsB, to_number_B);


                DataTable_Filling(dataTable, matrixB, rowsB, columnsB);
                DataGV_Filling(dataTable, dataGV_mxB, rowsB, columnsB);

                enter_SetB = true;
            }
            else if (clikedButton.Name == btn_Result_mxC.Name)
            {
                string execution_time = "Час виконання:\n";
                if (enter_SetA && enter_SetB)
                {
                    if (rowsA == columnsB)
                    {
                        rowsC = rowsA;
                        columnsC = columnsB;

                        lbl_size_result.Text = Convert.ToString(rowsC) + " x " + Convert.ToString(columnsC);

                        matrixC = new int[rowsC, columnsC];

                        HeaderColumn_Filling(dataTable, columnsC, last_columnC);

                        if (SeachElementInArrayPower(rowsC) && SquareMatrix(rowsA, columnsA, rowsB, columnsB))
                        {
                            stopwatch.Start();
                            matrixC = Strassen(matrixA, matrixB);
                            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                            execution_time += "Алгоритм Штрассена: " + Convert.ToString(time) + " мк\n";
                        }
                        else
                        {
                            int indexTemp = MaxSizeValueMatrix();
                            int index = SetSizeSquareWithArray_PowerTwo(indexTemp);

                            int[,] array_matrix_squareA = new int[index, index];
                            int[,] array_matrix_squareB = new int[index, index];
                            int[,] array_matrix_squareC = new int[index, index];

                            ArrayMatrix_Up_ToSquare(array_matrix_squareA, array_matrix_squareB, index);

                            Print_Array(array_matrix_squareA, "MatrixA_Temp:");
                            Print_Array(array_matrix_squareB, "MatrixB_Temp:");

                            stopwatch.Start();
                            array_matrix_squareC = Strassen(array_matrix_squareA, array_matrix_squareB);
                            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

                            Print_Array(array_matrix_squareC, "MatrixC_Temp:");

                            execution_time += "Алгоритм Штрассена: " + Convert.ToString(time) + " мк\n";

                            int[,] result = new int[rowsC, columnsC];
                            result = ArrayMatrix_Down_ToSquare(array_matrix_squareC);

                            Print_Array(result, "Result:\n");
                        }
                        
                        stopwatch.Start();
                        Result_Multiplication();
                        stopwatch.Stop();
                        time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                        execution_time += "Алгоритм Стандартний: " + Convert.ToString(time) + " мк";

                        DataTable_Filling(dataTable, matrixC, rowsC, columnsC);
                        DataGV_Filling(dataTable, dataGV_mxC, rowsC, columnsC);

                        MessageBox.Show(execution_time);
                    }
                    else
                    {
                        MessageBox.Show("Рядок матриці А не рівний стовпцю матриці В");
                        dataGV_mxC.DataSource = dataTable;
                    }
                }
            }
        }

        //  Заповнення і правильне відображення матриці в DataGridView
        private void DataGV_Filling(DataTable matrix, DataGridView dataGV, int rowsCount, int columnsCount)
        {
            dataGV.DataSource = matrix;                 //  Джерело даних
            dataGV.RowHeadersVisible = false;           //  Відображення рядка заголовків
            dataGV.ColumnHeadersVisible = false;        //  Відображення стовпця заголовків
            dataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGV.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            dataGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGV.ReadOnly = true;

            if (columnsCount > 12)
            {
                dataGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                //  Рівномірне розподілення простору для стовпців
                int x = dataGV.Width % columnsCount - 3;
                dataGV.Width -= x;
                dataGV.Location = new Point(dataGV.Location.X + x / 2, dataGV.Location.Y);

                foreach (DataGridViewColumn column in dataGV.Columns)
                {
                    column.Width = dataGV.Width / columnsCount;
                }
            }

            if (rowsCount < 17)
            {
                //  Рівномірне розподілення простору для рядків
                int y = dataGV.Height % rowsCount - 3;
                dataGV.Height -= y;
                dataGV.Location = new Point(dataGV.Location.X, dataGV.Location.Y + y / 2);

                foreach (DataGridViewRow row in dataGV.Rows)
                {
                    row.Height = dataGV.Height / rowsCount;
                }
            }
            else
            {
                dataGV.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }
        }
        
        //  Автозаповнення матриці
        private void Random_Filling(int[,] matrix, int rowsCount, int columnsCount, int to_number)
        {
            Random random = new Random();
            try
            {
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        matrix[i, j] = random.Next(to_number);
                    }
                }
            }
            catch (Exception exp) { MessageBox.Show($"Error {exp}"); }
        }

        //  Додавання/Видалення заголовків
        private void HeaderColumn_Filling(DataTable matrix, int columnsCount, int last_columns)
        {
            if (last_columns < columnsCount)
            {
                //  Додавання
                for (int column = last_columns; column < columnsCount; column++)
                {
                    matrix.Columns.Add($"Column{column + 1}", typeof(int));
                }
            }
            else if (last_columns > columnsCount)
            {
                //  Видалення
                for (int column = last_columns; column > columnsCount; column--)
                {
                    matrix.Columns.RemoveAt(column - 1);
                }
            }
        }

        //  Заповнення DataTable матриці
        private void DataTable_Filling(DataTable dataTable, int[,] matrix, int rowsCount, int columnsCount)
        {
            try
            {
                for (int i = 0; i < rowsCount; i++)
                {
                    DataRow dr = dataTable.NewRow();
                    for (int j = 0; j < columnsCount; j++)
                    {
                        dr[j] = matrix[i, j];
                    }
                    dataTable.Rows.Add(dr);
                }
            }
            catch (Exception exp) { MessageBox.Show($"Error {exp}"); }
        }

        //  Результат множення матриць
        private void Result_Multiplication()
        {
            try
            {
                for (int i = 0; i < rowsC; i++)
                {
                    for (int j = 0; j < columnsC; j++)
                    {
                        for (int k = 0; k < columnsA; k++)
                        {
                            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                    }
                }
            }
            catch (Exception exp) { MessageBox.Show($"Error {exp}"); }
        }

        //  Вибрати все при натиску на вибране поле
        private void SelectAll_TextBox(object sender, EventArgs e)
        {
            TextBox clickedTextBox = sender as TextBox;
            clickedTextBox.SelectAll();
        }

        //  Обробка коректністі текстбоксів
        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (!IsValidData(textBox.Text))
            {
                MessageBox.Show("Тільки число");
                textBox.Text = "8";
            }

            if (Convert.ToInt16(textBox.Text) <= 0)
            {
                textBox.Text = "8";
                MessageBox.Show("Тільки число більше від 0");
            }
            textBox.SelectAll();
        }

        //  Перевірка коректності
        private bool IsValidData(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        //  Функція додавання матриць
        static int[,] AddMatrix(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = A[i, j] + B[i, j];
                }
            }
            return result;
        }

        //  Функція віднімання матриць
        static int[,] SubtractMatrix(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = A[i, j] - B[i, j];
                }
            }
            return result;
        }

        //  Функція множення матриць алгоритмом Штарассена
        static int[,] Strassen(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);

            //  Якщо розмір матриці дорівнює 1
            if (n == 1)
            {
                int[,] result = new int[1, 1];
                result[0, 0] = A[0, 0] * B[0, 0];
                return result;
            }
            else
            {
                int newSize = n / 2;

                //  Розбивання матриці на підматриці
                int[,] A11 = new int[newSize, newSize];
                int[,] A12 = new int[newSize, newSize];
                int[,] A21 = new int[newSize, newSize];
                int[,] A22 = new int[newSize, newSize];
                int[,] B11 = new int[newSize, newSize];
                int[,] B12 = new int[newSize, newSize];
                int[,] B21 = new int[newSize, newSize];
                int[,] B22 = new int[newSize, newSize];

                //  Заповнення матриць
                for (int i = 0; i < newSize; i++)
                {
                    for (int j = 0; j < newSize; j++)
                    {
                        A11[i, j] = A[i, j];
                        A12[i, j] = A[i, j + newSize];
                        A21[i, j] = A[i + newSize, j];
                        A22[i, j] = A[i + newSize, j + newSize];

                        B11[i, j] = B[i, j];
                        B12[i, j] = B[i, j + newSize];
                        B21[i, j] = B[i + newSize, j];
                        B22[i, j] = B[i + newSize, j + newSize];
                    }
                }

                //  Обрахунок проміжних матриць
                int[,] M1 = Strassen(AddMatrix(A11, A22), AddMatrix(B11, B22));
                int[,] M2 = Strassen(AddMatrix(A21, A22), B11);
                int[,] M3 = Strassen(A11, SubtractMatrix(B12, B22));
                int[,] M4 = Strassen(A22, SubtractMatrix(B21, B11));
                int[,] M5 = Strassen(AddMatrix(A11, A12), B22);
                int[,] M6 = Strassen(SubtractMatrix(A21, A11), AddMatrix(B11, B12));
                int[,] M7 = Strassen(SubtractMatrix(A12, A22), AddMatrix(B21, B22));

                //  Обрахунок результатів
                int[,] C11 = AddMatrix(SubtractMatrix(AddMatrix(M1, M4), M5), M7);
                int[,] C12 = AddMatrix(M3, M5);
                int[,] C21 = AddMatrix(M2, M4);
                int[,] C22 = AddMatrix(SubtractMatrix(AddMatrix(M1, M3), M2), M6);

                //  Зібрання результатів із підматриць
                int[,] result = new int[n, n];
                for (int i = 0; i < newSize; i++)
                {
                    for (int j = 0; j < newSize; j++)
                    {
                        result[i, j] = C11[i, j];
                        result[i, j + newSize] = C12[i, j];
                        result[i + newSize, j] = C21[i, j];
                        result[i + newSize, j + newSize] = C22[i, j];
                    }
                }
                stopwatch.Stop();
                return result;
            }
        }

        //  Заповнення масиву степеня двійки
        private void ArrayPowerOfTwo()
        {
            const int N = 20;
            arrayPowerOfTwo = new int[N];
            for (int i = 0; i < N; i++)
            {
                arrayPowerOfTwo[i] = Convert.ToInt32(Math.Pow(2, i));
            }
        }

        //  Перевірка на наявність числа в масиві степеня двійки
        private bool SeachElementInArrayPower(int num_search)
        {
            foreach (int num in arrayPowerOfTwo)
            {
                if (num == num_search) return true;
            }
            return false;
        }

        //  Пошук в масиві степеня більшого або рівного максимальній розмірності матриць
        private int SetSizeSquareWithArray_PowerTwo(int num_min)
        {
            int number = num_min;
            foreach (int num in arrayPowerOfTwo)
            {
                if (num >= num_min)
                {
                    return num;
                }
                else
                    number = num;
            }
            return number;
        }

        //  Перевірка на рівні квадратичні матриці А і В
        private bool SquareMatrix(int rowA, int columnA, int rowB, int columnB)
        {
            return (rowA == columnA && rowB == columnB) ? true : false;
        }

        //  Приведення не квадратних матриць множення до квадратних
        private void ArrayMatrix_Up_ToSquare(int[,] matrix_1, int[,] matrix_2, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (rowsA > i && columnsA > j)
                        matrix_1[i, j] = matrixA[i, j];
                    else
                        matrix_1[i, j] = 0;

                    if (rowsB > i && columnsB > j)
                        matrix_2[i, j] = matrixB[i, j];
                    else
                        matrix_2[i, j] = 0;
                }
            }
        }

        //  Максимальний розмір матриці
        private int MaxSizeValueMatrix()
        {
            //  if ( rowsA >= columnsA && rowsA >= columnsB )
            //  { return rowsA; }
            //  else if (columnsA >= columnsB)
            //  { return rowsA; }
            //  else { return columnsB; }
            return (rowsA >= columnsA && rowsA >= columnsB) ? rowsA : (columnsA >= columnsB) ? columnsA : columnsB;
        }

        //  Приведення матриці до розміру квадратної при початковому -> (rowsA == columnsB)
        private int[,] ArrayMatrix_Down_ToSquare(int[,] matrix)
        {
            int[,] result = new int[rowsC, columnsC];
            for (int i = 0, m = 0; i < matrix.GetLength(0); i++)
            {
                if (SeachZeroRow(matrix, i, 0, matrix.GetLength(0)))
                    continue;
                for (int j = 0, n = 0; j < matrix.GetLength(1); j++)
                {
                    if (SeachZeroColumn(matrix, 0, j, matrix.GetLength(1)))
                        continue;

                    result[m, n] = matrix[i, j];
                    n++;
                }
                m++;
            }
            return result;
        }

        //  Пошук нульового рядка
        private bool SeachZeroRow(int[,] matrix, int index_x, int index_y, int length)
        {
            for (int i = index_y; i < length; i++)
            {
                    if (matrix[index_x, i] != 0)
                        return false;
            }
            return true;
        }

        //  Пошук нульового стовпця
        private bool SeachZeroColumn(int[,] matrix, int index_x, int index_y, int length)
        {
                for (int j = index_x; j < length; j++)
                {
                    if (matrix[j, index_y] != 0)
                        return false;
                }
            return true;
        }
    
        //  Виведення масивів на екран
        private void Print_Array(int[,] matrix, string name)
        {
            string result = $"Масив {name}\n";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 10)
                        result += ' ';
                    if (matrix[i, j] < 100)
                        result += ' ';
                    result +=  matrix[i, j].ToString() + ' ';
                }
                result += '\n';
            }
            MessageBox.Show(result);
        }
    }
}
