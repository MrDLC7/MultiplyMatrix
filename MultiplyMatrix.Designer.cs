namespace MultiplyMatrix
{
    partial class MultiplyMatrix
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Main = new Panel();
            PrintArrayTemp = new CheckBox();
            dataGV_mxC = new DataGridView();
            dataGV_mxA = new DataGridView();
            dataGV_mxB = new DataGridView();
            txtBox_to_B = new TextBox();
            lbl_from_B = new Label();
            lbl_numbers_B = new Label();
            txtBox_to_A = new TextBox();
            lbl_from_A = new Label();
            lbl_numbers_A = new Label();
            lbl_size_result = new Label();
            btn_Result_mxC = new Button();
            lbl_Size_mxC = new Label();
            lbl_mxC = new Label();
            btn_SetB = new Button();
            lbl_xB = new Label();
            columnB = new TextBox();
            rowB = new TextBox();
            lbl_Size_mxB = new Label();
            lbl_mxB = new Label();
            btn_SetA = new Button();
            lbl_xA = new Label();
            columnA = new TextBox();
            rowA = new TextBox();
            lbl_Size_mxA = new Label();
            lbl_mxA = new Label();
            lbl_res = new Label();
            lbl_mul = new Label();
            panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV_mxC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGV_mxA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGV_mxB).BeginInit();
            SuspendLayout();
            // 
            // panel_Main
            // 
            panel_Main.Anchor = AnchorStyles.None;
            panel_Main.Controls.Add(PrintArrayTemp);
            panel_Main.Controls.Add(dataGV_mxC);
            panel_Main.Controls.Add(dataGV_mxA);
            panel_Main.Controls.Add(dataGV_mxB);
            panel_Main.Controls.Add(txtBox_to_B);
            panel_Main.Controls.Add(lbl_from_B);
            panel_Main.Controls.Add(lbl_numbers_B);
            panel_Main.Controls.Add(txtBox_to_A);
            panel_Main.Controls.Add(lbl_from_A);
            panel_Main.Controls.Add(lbl_numbers_A);
            panel_Main.Controls.Add(lbl_size_result);
            panel_Main.Controls.Add(btn_Result_mxC);
            panel_Main.Controls.Add(lbl_Size_mxC);
            panel_Main.Controls.Add(lbl_mxC);
            panel_Main.Controls.Add(btn_SetB);
            panel_Main.Controls.Add(lbl_xB);
            panel_Main.Controls.Add(columnB);
            panel_Main.Controls.Add(rowB);
            panel_Main.Controls.Add(lbl_Size_mxB);
            panel_Main.Controls.Add(lbl_mxB);
            panel_Main.Controls.Add(btn_SetA);
            panel_Main.Controls.Add(lbl_xA);
            panel_Main.Controls.Add(columnA);
            panel_Main.Controls.Add(rowA);
            panel_Main.Controls.Add(lbl_Size_mxA);
            panel_Main.Controls.Add(lbl_mxA);
            panel_Main.Controls.Add(lbl_res);
            panel_Main.Controls.Add(lbl_mul);
            panel_Main.Location = new Point(3, 2);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1179, 550);
            panel_Main.TabIndex = 0;
            // 
            // PrintArrayTemp
            // 
            PrintArrayTemp.AutoSize = true;
            PrintArrayTemp.CheckAlign = ContentAlignment.MiddleCenter;
            PrintArrayTemp.Location = new Point(1158, 530);
            PrintArrayTemp.Name = "PrintArrayTemp";
            PrintArrayTemp.Size = new Size(18, 17);
            PrintArrayTemp.TabIndex = 36;
            PrintArrayTemp.TextAlign = ContentAlignment.MiddleCenter;
            PrintArrayTemp.TextImageRelation = TextImageRelation.TextBeforeImage;
            PrintArrayTemp.UseVisualStyleBackColor = true;
            // 
            // dataGV_mxC
            // 
            dataGV_mxC.AllowUserToAddRows = false;
            dataGV_mxC.AllowUserToDeleteRows = false;
            dataGV_mxC.AllowUserToResizeColumns = false;
            dataGV_mxC.AllowUserToResizeRows = false;
            dataGV_mxC.BorderStyle = BorderStyle.None;
            dataGV_mxC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV_mxC.Location = new Point(801, 167);
            dataGV_mxC.Name = "dataGV_mxC";
            dataGV_mxC.RowHeadersWidth = 51;
            dataGV_mxC.Size = new Size(350, 350);
            dataGV_mxC.TabIndex = 200;
            dataGV_mxC.TabStop = false;
            // 
            // dataGV_mxA
            // 
            dataGV_mxA.AllowUserToAddRows = false;
            dataGV_mxA.AllowUserToDeleteRows = false;
            dataGV_mxA.AllowUserToResizeColumns = false;
            dataGV_mxA.AllowUserToResizeRows = false;
            dataGV_mxA.BorderStyle = BorderStyle.None;
            dataGV_mxA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV_mxA.Location = new Point(26, 167);
            dataGV_mxA.Name = "dataGV_mxA";
            dataGV_mxA.RowHeadersWidth = 51;
            dataGV_mxA.Size = new Size(350, 350);
            dataGV_mxA.TabIndex = 60;
            dataGV_mxA.TabStop = false;
            // 
            // dataGV_mxB
            // 
            dataGV_mxB.AllowUserToAddRows = false;
            dataGV_mxB.AllowUserToDeleteRows = false;
            dataGV_mxB.AllowUserToResizeColumns = false;
            dataGV_mxB.AllowUserToResizeRows = false;
            dataGV_mxB.BorderStyle = BorderStyle.None;
            dataGV_mxB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV_mxB.Location = new Point(414, 167);
            dataGV_mxB.Name = "dataGV_mxB";
            dataGV_mxB.RowHeadersWidth = 51;
            dataGV_mxB.Size = new Size(350, 350);
            dataGV_mxB.TabIndex = 130;
            dataGV_mxB.TabStop = false;
            // 
            // txtBox_to_B
            // 
            txtBox_to_B.Location = new Point(651, 90);
            txtBox_to_B.Name = "txtBox_to_B";
            txtBox_to_B.Size = new Size(34, 27);
            txtBox_to_B.TabIndex = 8;
            txtBox_to_B.Text = "25";
            txtBox_to_B.TextAlign = HorizontalAlignment.Center;
            txtBox_to_B.Click += SelectAll_TextBox;
            txtBox_to_B.Enter += SelectAll_TextBox;
            txtBox_to_B.Validating += TextBox_Validating;
            // 
            // lbl_from_B
            // 
            lbl_from_B.AutoSize = true;
            lbl_from_B.Location = new Point(589, 93);
            lbl_from_B.Name = "lbl_from_B";
            lbl_from_B.Size = new Size(56, 20);
            lbl_from_B.TabIndex = 330;
            lbl_from_B.Text = "0     до";
            // 
            // lbl_numbers_B
            // 
            lbl_numbers_B.AutoSize = true;
            lbl_numbers_B.Location = new Point(491, 93);
            lbl_numbers_B.Name = "lbl_numbers_B";
            lbl_numbers_B.Size = new Size(83, 20);
            lbl_numbers_B.TabIndex = 320;
            lbl_numbers_B.Text = "Числа від:";
            // 
            // txtBox_to_A
            // 
            txtBox_to_A.Location = new Point(262, 90);
            txtBox_to_A.Name = "txtBox_to_A";
            txtBox_to_A.Size = new Size(34, 27);
            txtBox_to_A.TabIndex = 4;
            txtBox_to_A.Text = "25";
            txtBox_to_A.TextAlign = HorizontalAlignment.Center;
            txtBox_to_A.Click += SelectAll_TextBox;
            txtBox_to_A.Enter += SelectAll_TextBox;
            txtBox_to_A.Validating += TextBox_Validating;
            // 
            // lbl_from_A
            // 
            lbl_from_A.AutoSize = true;
            lbl_from_A.Location = new Point(198, 93);
            lbl_from_A.Name = "lbl_from_A";
            lbl_from_A.Size = new Size(56, 20);
            lbl_from_A.TabIndex = 25;
            lbl_from_A.Text = "0     до";
            // 
            // lbl_numbers_A
            // 
            lbl_numbers_A.AutoSize = true;
            lbl_numbers_A.Location = new Point(102, 93);
            lbl_numbers_A.Name = "lbl_numbers_A";
            lbl_numbers_A.Size = new Size(83, 20);
            lbl_numbers_A.TabIndex = 24;
            lbl_numbers_A.Text = "Числа від:";
            // 
            // lbl_size_result
            // 
            lbl_size_result.Location = new Point(947, 54);
            lbl_size_result.Name = "lbl_size_result";
            lbl_size_result.Size = new Size(125, 25);
            lbl_size_result.TabIndex = 210;
            lbl_size_result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Result_mxC
            // 
            btn_Result_mxC.Location = new Point(878, 121);
            btn_Result_mxC.Name = "btn_Result_mxC";
            btn_Result_mxC.Size = new Size(194, 33);
            btn_Result_mxC.TabIndex = 10;
            btn_Result_mxC.Text = "Результат";
            btn_Result_mxC.UseVisualStyleBackColor = true;
            btn_Result_mxC.Click += btn_Set;
            // 
            // lbl_Size_mxC
            // 
            lbl_Size_mxC.AutoSize = true;
            lbl_Size_mxC.Location = new Point(878, 56);
            lbl_Size_mxC.Name = "lbl_Size_mxC";
            lbl_Size_mxC.Size = new Size(63, 20);
            lbl_Size_mxC.TabIndex = 150;
            lbl_Size_mxC.Text = "Розмір:";
            // 
            // lbl_mxC
            // 
            lbl_mxC.AutoSize = true;
            lbl_mxC.Location = new Point(945, 18);
            lbl_mxC.Name = "lbl_mxC";
            lbl_mxC.Size = new Size(88, 20);
            lbl_mxC.TabIndex = 140;
            lbl_mxC.Text = "Матриця C";
            // 
            // btn_SetB
            // 
            btn_SetB.Location = new Point(491, 121);
            btn_SetB.Name = "btn_SetB";
            btn_SetB.Size = new Size(194, 33);
            btn_SetB.TabIndex = 9;
            btn_SetB.Text = "Заповнити";
            btn_SetB.UseVisualStyleBackColor = true;
            btn_SetB.Click += btn_Set;
            // 
            // lbl_xB
            // 
            lbl_xB.AutoSize = true;
            lbl_xB.Location = new Point(624, 56);
            lbl_xB.Name = "lbl_xB";
            lbl_xB.Size = new Size(17, 20);
            lbl_xB.TabIndex = 110;
            lbl_xB.Text = "x";
            lbl_xB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // columnB
            // 
            columnB.Location = new Point(651, 53);
            columnB.Name = "columnB";
            columnB.Size = new Size(34, 27);
            columnB.TabIndex = 7;
            columnB.Text = "8";
            columnB.TextAlign = HorizontalAlignment.Center;
            columnB.Click += SelectAll_TextBox;
            columnB.Enter += SelectAll_TextBox;
            columnB.Validating += TextBox_Validating;
            // 
            // rowB
            // 
            rowB.Location = new Point(580, 53);
            rowB.Name = "rowB";
            rowB.Size = new Size(34, 27);
            rowB.TabIndex = 6;
            rowB.Text = "8";
            rowB.TextAlign = HorizontalAlignment.Center;
            rowB.Click += SelectAll_TextBox;
            rowB.Enter += SelectAll_TextBox;
            rowB.Validating += TextBox_Validating;
            // 
            // lbl_Size_mxB
            // 
            lbl_Size_mxB.AutoSize = true;
            lbl_Size_mxB.Location = new Point(491, 54);
            lbl_Size_mxB.Name = "lbl_Size_mxB";
            lbl_Size_mxB.Size = new Size(63, 20);
            lbl_Size_mxB.TabIndex = 82;
            lbl_Size_mxB.Text = "Розмір:";
            // 
            // lbl_mxB
            // 
            lbl_mxB.AutoSize = true;
            lbl_mxB.Location = new Point(558, 18);
            lbl_mxB.Name = "lbl_mxB";
            lbl_mxB.Size = new Size(89, 20);
            lbl_mxB.TabIndex = 70;
            lbl_mxB.Text = "Матриця B";
            // 
            // btn_SetA
            // 
            btn_SetA.Location = new Point(102, 121);
            btn_SetA.Name = "btn_SetA";
            btn_SetA.Size = new Size(194, 33);
            btn_SetA.TabIndex = 5;
            btn_SetA.Text = "Заповнити";
            btn_SetA.UseVisualStyleBackColor = true;
            btn_SetA.Click += btn_Set;
            // 
            // lbl_xA
            // 
            lbl_xA.AutoSize = true;
            lbl_xA.Location = new Point(235, 56);
            lbl_xA.Name = "lbl_xA";
            lbl_xA.Size = new Size(17, 20);
            lbl_xA.TabIndex = 40;
            lbl_xA.Text = "x";
            lbl_xA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // columnA
            // 
            columnA.Location = new Point(262, 53);
            columnA.Name = "columnA";
            columnA.Size = new Size(34, 27);
            columnA.TabIndex = 3;
            columnA.Text = "8";
            columnA.TextAlign = HorizontalAlignment.Center;
            columnA.Click += SelectAll_TextBox;
            columnA.Enter += SelectAll_TextBox;
            columnA.Validating += TextBox_Validating;
            // 
            // rowA
            // 
            rowA.Location = new Point(191, 53);
            rowA.Name = "rowA";
            rowA.Size = new Size(34, 27);
            rowA.TabIndex = 2;
            rowA.Text = "8";
            rowA.TextAlign = HorizontalAlignment.Center;
            rowA.Click += SelectAll_TextBox;
            rowA.Enter += SelectAll_TextBox;
            rowA.Validating += TextBox_Validating;
            // 
            // lbl_Size_mxA
            // 
            lbl_Size_mxA.AutoSize = true;
            lbl_Size_mxA.Location = new Point(102, 56);
            lbl_Size_mxA.Name = "lbl_Size_mxA";
            lbl_Size_mxA.Size = new Size(63, 20);
            lbl_Size_mxA.TabIndex = 201;
            lbl_Size_mxA.Text = "Розмір:";
            // 
            // lbl_mxA
            // 
            lbl_mxA.AutoSize = true;
            lbl_mxA.Location = new Point(169, 18);
            lbl_mxA.Name = "lbl_mxA";
            lbl_mxA.Size = new Size(90, 20);
            lbl_mxA.TabIndex = 36;
            lbl_mxA.Text = "Матриця А";
            // 
            // lbl_res
            // 
            lbl_res.AutoSize = true;
            lbl_res.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_res.Location = new Point(765, 316);
            lbl_res.Name = "lbl_res";
            lbl_res.Size = new Size(39, 41);
            lbl_res.TabIndex = 23;
            lbl_res.Text = "=";
            // 
            // lbl_mul
            // 
            lbl_mul.AutoSize = true;
            lbl_mul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mul.Location = new Point(379, 318);
            lbl_mul.Name = "lbl_mul";
            lbl_mul.Size = new Size(32, 41);
            lbl_mul.TabIndex = 22;
            lbl_mul.Text = "*";
            // 
            // MultiplyMatrix
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(panel_Main);
            MinimumSize = new Size(1200, 600);
            Name = "MultiplyMatrix";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MultiplyMatrix";
            panel_Main.ResumeLayout(false);
            panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV_mxC).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGV_mxA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGV_mxB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Main;
        private Button btn_SetA;
        private Label lbl_xA;
        private TextBox columnA;
        private TextBox rowA;
        private Label lbl_Size_mxA;
        private Label lbl_mxA;
        private DataGridView dataGV_mxC;
        private Button btn_Result_mxC;
        private Label lbl_xC;
        private Label lbl_Size_mxC;
        private Label lbl_mxC;
        private DataGridView dataGV_mxB;
        private Button btn_SetB;
        private Label lbl_xB;
        private TextBox columnB;
        private TextBox rowB;
        private Label lbl_Size_mxB;
        private Label lbl_mxB;
        private DataGridView dataGV_mxA;
        private Label columnC;
        private Label lbl_size_result;
        private Label lbl_res;
        private Label lbl_mul;
        private Label lbl_numbers_A;
        private TextBox txtBox_to_B;
        private Label lbl_from_B;
        private Label lbl_numbers_B;
        private TextBox txtBox_to_A;
        private Label lbl_from_A;
        private CheckBox PrintArrayTemp;
    }
}
