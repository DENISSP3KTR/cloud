
namespace laba10
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рандомныйКругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.концентрическиеКругиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругиНаОтрезкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.насыщенностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеШумовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисованиеToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.новоеToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // новоеToolStripMenuItem
            // 
            this.новоеToolStripMenuItem.Name = "новоеToolStripMenuItem";
            this.новоеToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.новоеToolStripMenuItem.Text = "Новое";
            this.новоеToolStripMenuItem.Click += new System.EventHandler(this.новоеToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // рисованиеToolStripMenuItem
            // 
            this.рисованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рандомныйКругToolStripMenuItem,
            this.концентрическиеКругиToolStripMenuItem,
            this.кругиНаОтрезкеToolStripMenuItem});
            this.рисованиеToolStripMenuItem.Name = "рисованиеToolStripMenuItem";
            this.рисованиеToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.рисованиеToolStripMenuItem.Text = "Рисование";
            this.рисованиеToolStripMenuItem.Click += new System.EventHandler(this.рисованиеToolStripMenuItem_Click);
            // 
            // рандомныйКругToolStripMenuItem
            // 
            this.рандомныйКругToolStripMenuItem.Name = "рандомныйКругToolStripMenuItem";
            this.рандомныйКругToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.рандомныйКругToolStripMenuItem.Text = "Рандомный круг";
            this.рандомныйКругToolStripMenuItem.Click += new System.EventHandler(this.рандомныйКругToolStripMenuItem_Click);
            // 
            // концентрическиеКругиToolStripMenuItem
            // 
            this.концентрическиеКругиToolStripMenuItem.Name = "концентрическиеКругиToolStripMenuItem";
            this.концентрическиеКругиToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.концентрическиеКругиToolStripMenuItem.Text = "Концентрические круги";
            this.концентрическиеКругиToolStripMenuItem.Click += new System.EventHandler(this.концентрическиеКругиToolStripMenuItem_Click);
            // 
            // кругиНаОтрезкеToolStripMenuItem
            // 
            this.кругиНаОтрезкеToolStripMenuItem.Name = "кругиНаОтрезкеToolStripMenuItem";
            this.кругиНаОтрезкеToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.кругиНаОтрезкеToolStripMenuItem.Text = "Круги на отрезке";
            this.кругиНаОтрезкеToolStripMenuItem.Click += new System.EventHandler(this.кругиНаОтрезкеToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.яркостьToolStripMenuItem,
            this.контрастToolStripMenuItem,
            this.насыщенностьToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.удалениеШумовToolStripMenuItem,
            this.размерToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.яркостьToolStripMenuItem.Text = "Яркость";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.яркостьToolStripMenuItem_Click);
            // 
            // контрастToolStripMenuItem
            // 
            this.контрастToolStripMenuItem.Name = "контрастToolStripMenuItem";
            this.контрастToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.контрастToolStripMenuItem.Text = "Контраст";
            this.контрастToolStripMenuItem.Click += new System.EventHandler(this.контрастToolStripMenuItem_Click);
            // 
            // насыщенностьToolStripMenuItem
            // 
            this.насыщенностьToolStripMenuItem.Name = "насыщенностьToolStripMenuItem";
            this.насыщенностьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.насыщенностьToolStripMenuItem.Text = "Насыщенность";
            this.насыщенностьToolStripMenuItem.Click += new System.EventHandler(this.насыщенностьToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // удалениеШумовToolStripMenuItem
            // 
            this.удалениеШумовToolStripMenuItem.Name = "удалениеШумовToolStripMenuItem";
            this.удалениеШумовToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.удалениеШумовToolStripMenuItem.Text = "Удаление шумов";
            this.удалениеШумовToolStripMenuItem.Click += new System.EventHandler(this.удалениеШумовToolStripMenuItem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.размерToolStripMenuItem.Text = "Размер";
            this.размерToolStripMenuItem.Click += new System.EventHandler(this.размерToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown3);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Size = new System.Drawing.Size(1197, 568);
            this.splitContainer1.SplitterDistance = 1086;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 564);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(17, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3.Location = new System.Drawing.Point(16, 217);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(76, 31);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(16, 149);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 31);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(17, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 31);
            this.numericUpDown1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1197, 592);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рандомныйКругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem концентрическиеКругиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругиНаОтрезкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрастToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem насыщенностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеШумовToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
    }
}

