namespace PR_2._2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Value = new System.Windows.Forms.GroupBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.textBoxNumbersValues = new System.Windows.Forms.TextBox();
            this.Dictionary = new System.Windows.Forms.GroupBox();
            this.Cubing = new System.Windows.Forms.Button();
            this.Generation = new System.Windows.Forms.Button();
            this.textBoxNumbersKeys = new System.Windows.Forms.TextBox();
            this.Task = new System.Windows.Forms.GroupBox();
            this.pictureTask = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationCubing = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationMultiply = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Value.SuspendLayout();
            this.Dictionary.SuspendLayout();
            this.Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Value.Controls.Add(this.Multiply);
            this.Value.Controls.Add(this.textBoxNumbersValues);
            this.Value.Location = new System.Drawing.Point(257, 125);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(209, 95);
            this.Value.TabIndex = 14;
            this.Value.TabStop = false;
            this.Value.Text = "Значения (^3):";
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Multiply.Location = new System.Drawing.Point(45, 52);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(118, 35);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "Перемножить";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // textBoxNumbersValues
            // 
            this.textBoxNumbersValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxNumbersValues.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersValues.Name = "textBoxNumbersValues";
            this.textBoxNumbersValues.ReadOnly = true;
            this.textBoxNumbersValues.Size = new System.Drawing.Size(197, 27);
            this.textBoxNumbersValues.TabIndex = 6;
            // 
            // Dictionary
            // 
            this.Dictionary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Dictionary.Controls.Add(this.Cubing);
            this.Dictionary.Controls.Add(this.Generation);
            this.Dictionary.Controls.Add(this.textBoxNumbersKeys);
            this.Dictionary.Location = new System.Drawing.Point(12, 125);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(239, 125);
            this.Dictionary.TabIndex = 11;
            this.Dictionary.TabStop = false;
            this.Dictionary.Text = "Словарь генераций:";
            // 
            // Cubing
            // 
            this.Cubing.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cubing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cubing.Location = new System.Drawing.Point(6, 89);
            this.Cubing.Name = "Cubing";
            this.Cubing.Size = new System.Drawing.Size(125, 32);
            this.Cubing.TabIndex = 8;
            this.Cubing.Text = "Возвести в куб";
            this.Cubing.UseVisualStyleBackColor = false;
            this.Cubing.Click += new System.EventHandler(this.Cubing_Click);
            // 
            // Generation
            // 
            this.Generation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Generation.Location = new System.Drawing.Point(6, 48);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(192, 35);
            this.Generation.TabIndex = 7;
            this.Generation.Text = "Сгенерировать ключи (x5)";
            this.Generation.UseVisualStyleBackColor = false;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // textBoxNumbersKeys
            // 
            this.textBoxNumbersKeys.Location = new System.Drawing.Point(6, 19);
            this.textBoxNumbersKeys.Name = "textBoxNumbersKeys";
            this.textBoxNumbersKeys.Size = new System.Drawing.Size(204, 20);
            this.textBoxNumbersKeys.TabIndex = 6;
            this.textBoxNumbersKeys.TextChanged += new System.EventHandler(this.textBoxNumbersKeys_TextChanged);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Task.Controls.Add(this.pictureTask);
            this.Task.Location = new System.Drawing.Point(12, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(681, 92);
            this.Task.TabIndex = 10;
            this.Task.TabStop = false;
            this.Task.Text = "Задание:";
            // 
            // pictureTask
            // 
            this.pictureTask.Image = global::PR_2._2.Properties.Resources._2;
            this.pictureTask.Location = new System.Drawing.Point(19, 19);
            this.pictureTask.Name = "pictureTask";
            this.pictureTask.Size = new System.Drawing.Size(645, 63);
            this.pictureTask.TabIndex = 0;
            this.pictureTask.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.Reference});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(698, 24);
            this.Menu.TabIndex = 9;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.ClearMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "файл";
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationGeneration,
            this.ApplicationCubing,
            this.ApplicationMultiply});
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(146, 22);
            this.Applications.Text = "Приложения";
            // 
            // ApplicationGeneration
            // 
            this.ApplicationGeneration.Name = "ApplicationGeneration";
            this.ApplicationGeneration.Size = new System.Drawing.Size(242, 22);
            this.ApplicationGeneration.Text = "Приложение \"Сгенерировать\"";
            this.ApplicationGeneration.Click += new System.EventHandler(this.ApplicationGeneration_Click);
            // 
            // ApplicationCubing
            // 
            this.ApplicationCubing.Name = "ApplicationCubing";
            this.ApplicationCubing.Size = new System.Drawing.Size(242, 22);
            this.ApplicationCubing.Text = "Приложение \"Возвести в куб\"";
            this.ApplicationCubing.Click += new System.EventHandler(this.ApplicationCubing_Click);
            // 
            // ApplicationMultiply
            // 
            this.ApplicationMultiply.Name = "ApplicationMultiply";
            this.ApplicationMultiply.Size = new System.Drawing.Size(242, 22);
            this.ApplicationMultiply.Text = "Приложение \"Перемножить\"";
            this.ApplicationMultiply.Click += new System.EventHandler(this.ApplicationMultiply_Click);
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(146, 22);
            this.ClearMenu.Text = "Очистить";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(146, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(63, 20);
            this.Reference.Text = "справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(149, 22);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(472, 177);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 39);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выход 🚪";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.Location = new System.Drawing.Point(472, 132);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 39);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Очистить 🧹";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR_2._2.Properties.Resources.dictionary_icon_png_29;
            this.pictureBox1.Location = new System.Drawing.Point(584, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Практическая работа №2.2";
            this.Value.ResumeLayout(false);
            this.Value.PerformLayout();
            this.Dictionary.ResumeLayout(false);
            this.Dictionary.PerformLayout();
            this.Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Value;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox textBoxNumbersValues;
        private System.Windows.Forms.GroupBox Dictionary;
        private System.Windows.Forms.Button Cubing;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.TextBox textBoxNumbersKeys;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox pictureTask;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem ApplicationGeneration;
        private System.Windows.Forms.ToolStripMenuItem ApplicationMultiply;
        private System.Windows.Forms.ToolStripMenuItem ApplicationCubing;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

