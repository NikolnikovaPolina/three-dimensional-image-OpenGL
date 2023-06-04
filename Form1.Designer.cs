namespace _3ebba
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цвет = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLightUp = new System.Windows.Forms.Button();
            this.cone = new System.Windows.Forms.GroupBox();
            this.trasparency = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.radius = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.cone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trasparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnT.Location = new System.Drawing.Point(0, 0);
            this.AnT.Margin = new System.Windows.Forms.Padding(4);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(1384, 693);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.Цвет});
            this.dataGridView1.Location = new System.Drawing.Point(13, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(299, 223);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 40;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 40;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.MinimumWidth = 6;
            this.Z.Name = "Z";
            this.Z.Width = 40;
            // 
            // Цвет
            // 
            this.Цвет.HeaderText = "Цвет";
            this.Цвет.MinimumWidth = 6;
            this.Цвет.Name = "Цвет";
            this.Цвет.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Цвет.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Цвет.Text = "Цвет...";
            this.Цвет.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLightUp);
            this.panel1.Controls.Add(this.cone);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1050, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 693);
            this.panel1.TabIndex = 9;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // buttonLightUp
            // 
            this.buttonLightUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLightUp.Location = new System.Drawing.Point(115, 462);
            this.buttonLightUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLightUp.Name = "buttonLightUp";
            this.buttonLightUp.Size = new System.Drawing.Size(85, 28);
            this.buttonLightUp.TabIndex = 12;
            this.buttonLightUp.Text = "Осветить";
            this.buttonLightUp.UseVisualStyleBackColor = true;
            this.buttonLightUp.Click += new System.EventHandler(this.buttonLightUp_Click);
            // 
            // cone
            // 
            this.cone.Controls.Add(this.trasparency);
            this.cone.Controls.Add(this.label1);
            this.cone.Controls.Add(this.label5);
            this.cone.Controls.Add(this.label4);
            this.cone.Controls.Add(this.height);
            this.cone.Controls.Add(this.radius);
            this.cone.Location = new System.Drawing.Point(13, 13);
            this.cone.Margin = new System.Windows.Forms.Padding(4);
            this.cone.Name = "cone";
            this.cone.Padding = new System.Windows.Forms.Padding(4);
            this.cone.Size = new System.Drawing.Size(187, 193);
            this.cone.TabIndex = 11;
            this.cone.TabStop = false;
            this.cone.Text = "Конус";
            // 
            // trasparency
            // 
            this.trasparency.DecimalPlaces = 1;
            this.trasparency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trasparency.Location = new System.Drawing.Point(12, 159);
            this.trasparency.Margin = new System.Windows.Forms.Padding(4);
            this.trasparency.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trasparency.Name = "trasparency";
            this.trasparency.Size = new System.Drawing.Size(160, 22);
            this.trasparency.TabIndex = 10;
            this.trasparency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Прозрачность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Радиус основания";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(12, 102);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(160, 22);
            this.height.TabIndex = 7;
            this.height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(11, 46);
            this.radius.Margin = new System.Windows.Forms.Padding(4);
            this.radius.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.radius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(160, 22);
            this.radius.TabIndex = 6;
            this.radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Конус";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.cone.ResumeLayout(false);
            this.cone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trasparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewButtonColumn Цвет;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLightUp;
        private System.Windows.Forms.GroupBox cone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.NumericUpDown trasparency;
        private System.Windows.Forms.Label label1;
    }
}
