using System.Windows.Forms;

namespace DbWork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.genreNameComboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genreNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.deleteFilm = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.leftDiskUpDown = new System.Windows.Forms.NumericUpDown();
            this.takenDiskUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalDiskUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.filmNameComboBox = new System.Windows.Forms.ComboBox();
            this.editFilm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.genreNameComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.genreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addFilm = new System.Windows.Forms.Button();
            this.totalDiskUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.genreNameLabel = new System.Windows.Forms.Label();
            this.filmNameTextBox = new System.Windows.Forms.TextBox();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.genreKeyRB = new System.Windows.Forms.RadioButton();
            this.genreRB = new System.Windows.Forms.RadioButton();
            this.popularityRB = new System.Windows.Forms.RadioButton();
            this.ratingRB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.diskLeftRB = new System.Windows.Forms.RadioButton();
            this.diskTakenRB = new System.Windows.Forms.RadioButton();
            this.diskTotal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchFilm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchFilmComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDiskUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenDiskUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalDiskUpDown2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalDiskUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(11, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.genreNameComboBox2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.genreNumericUpDown2);
            this.groupBox5.Controls.Add(this.deleteFilm);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.leftDiskUpDown);
            this.groupBox5.Controls.Add(this.takenDiskUpDown);
            this.groupBox5.Controls.Add(this.totalDiskUpDown2);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.filmNameComboBox);
            this.groupBox5.Controls.Add(this.editFilm);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(404, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(509, 124);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Редактирование таблицы";
            // 
            // genreNameComboBox2
            // 
            this.genreNameComboBox2.FormattingEnabled = true;
            this.genreNameComboBox2.Location = new System.Drawing.Point(310, 41);
            this.genreNameComboBox2.Name = "genreNameComboBox2";
            this.genreNameComboBox2.Size = new System.Drawing.Size(120, 21);
            this.genreNameComboBox2.TabIndex = 29;
            this.genreNameComboBox2.DropDown += new System.EventHandler(this.genreNameComboBox2_DropDown);
            this.genreNameComboBox2.SelectedIndexChanged += new System.EventHandler(this.genreNameComboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ключ жанра";
            // 
            // genreNumericUpDown2
            // 
            this.genreNumericUpDown2.Location = new System.Drawing.Point(438, 41);
            this.genreNumericUpDown2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.genreNumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genreNumericUpDown2.Name = "genreNumericUpDown2";
            this.genreNumericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.genreNumericUpDown2.TabIndex = 27;
            this.genreNumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genreNumericUpDown2.ValueChanged += new System.EventHandler(this.genreNumericUpDown2_ValueChanged);
            // 
            // deleteFilm
            // 
            this.deleteFilm.Location = new System.Drawing.Point(410, 89);
            this.deleteFilm.Name = "deleteFilm";
            this.deleteFilm.Size = new System.Drawing.Size(93, 22);
            this.deleteFilm.TabIndex = 22;
            this.deleteFilm.Text = "Удалить из БД";
            this.deleteFilm.UseVisualStyleBackColor = true;
            this.deleteFilm.Click += new System.EventHandler(this.deleteFilm_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(205, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Сколько осталось";
            // 
            // leftDiskUpDown
            // 
            this.leftDiskUpDown.Location = new System.Drawing.Point(208, 90);
            this.leftDiskUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.leftDiskUpDown.Name = "leftDiskUpDown";
            this.leftDiskUpDown.Size = new System.Drawing.Size(97, 20);
            this.leftDiskUpDown.TabIndex = 25;
            this.leftDiskUpDown.ValueChanged += new System.EventHandler(this.leftDiskUpDown_ValueChanged);
            // 
            // takenDiskUpDown
            // 
            this.takenDiskUpDown.Location = new System.Drawing.Point(114, 90);
            this.takenDiskUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.takenDiskUpDown.Name = "takenDiskUpDown";
            this.takenDiskUpDown.Size = new System.Drawing.Size(88, 20);
            this.takenDiskUpDown.TabIndex = 23;
            this.takenDiskUpDown.ValueChanged += new System.EventHandler(this.takenDiskUpDown_ValueChanged);
            // 
            // totalDiskUpDown2
            // 
            this.totalDiskUpDown2.Location = new System.Drawing.Point(4, 90);
            this.totalDiskUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.totalDiskUpDown2.Name = "totalDiskUpDown2";
            this.totalDiskUpDown2.Size = new System.Drawing.Size(104, 20);
            this.totalDiskUpDown2.TabIndex = 15;
            this.totalDiskUpDown2.ValueChanged += new System.EventHandler(this.totalDiskUpDown2_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Сколько отдали";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Название фильма";
            // 
            // filmNameComboBox
            // 
            this.filmNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmNameComboBox.FormattingEnabled = true;
            this.filmNameComboBox.Location = new System.Drawing.Point(4, 41);
            this.filmNameComboBox.Name = "filmNameComboBox";
            this.filmNameComboBox.Size = new System.Drawing.Size(301, 21);
            this.filmNameComboBox.TabIndex = 12;
            this.filmNameComboBox.DropDown += new System.EventHandler(this.filmNameComboBox_DropDown);
            this.filmNameComboBox.SelectedIndexChanged += new System.EventHandler(this.filmNameComboBox_SelectedIndexChanged);
            // 
            // editFilm
            // 
            this.editFilm.Location = new System.Drawing.Point(310, 89);
            this.editFilm.Name = "editFilm";
            this.editFilm.Size = new System.Drawing.Size(93, 22);
            this.editFilm.TabIndex = 11;
            this.editFilm.Text = "Изменить";
            this.editFilm.UseVisualStyleBackColor = true;
            this.editFilm.Click += new System.EventHandler(this.editFilm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Количество дисков";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Жанр";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.genreNameComboBox);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.genreNumericUpDown);
            this.groupBox4.Controls.Add(this.addFilm);
            this.groupBox4.Controls.Add(this.totalDiskUpDown);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.genreNameLabel);
            this.groupBox4.Controls.Add(this.filmNameTextBox);
            this.groupBox4.Controls.Add(this.filmNameLabel);
            this.groupBox4.Location = new System.Drawing.Point(11, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 124);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Наполнение таблицы";
            // 
            // genreNameComboBox
            // 
            this.genreNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreNameComboBox.FormattingEnabled = true;
            this.genreNameComboBox.Location = new System.Drawing.Point(9, 90);
            this.genreNameComboBox.Name = "genreNameComboBox";
            this.genreNameComboBox.Size = new System.Drawing.Size(193, 21);
            this.genreNameComboBox.TabIndex = 17;
            this.genreNameComboBox.DropDown += new System.EventHandler(this.genreNameComboBox_DropDown);
            this.genreNameComboBox.SelectedIndexChanged += new System.EventHandler(this.genreNameComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(205, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Ключ жанра";
            // 
            // genreNumericUpDown
            // 
            this.genreNumericUpDown.Location = new System.Drawing.Point(208, 90);
            this.genreNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.genreNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genreNumericUpDown.Name = "genreNumericUpDown";
            this.genreNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.genreNumericUpDown.TabIndex = 16;
            this.genreNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genreNumericUpDown.ValueChanged += new System.EventHandler(this.genreNumericUpDown_ValueChanged);
            // 
            // addFilm
            // 
            this.addFilm.Location = new System.Drawing.Point(279, 86);
            this.addFilm.Name = "addFilm";
            this.addFilm.Size = new System.Drawing.Size(102, 24);
            this.addFilm.TabIndex = 0;
            this.addFilm.Text = "Добавить";
            this.addFilm.UseVisualStyleBackColor = true;
            this.addFilm.Click += new System.EventHandler(this.addFilm_Click);
            // 
            // totalDiskUpDown
            // 
            this.totalDiskUpDown.Location = new System.Drawing.Point(279, 43);
            this.totalDiskUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.totalDiskUpDown.Name = "totalDiskUpDown";
            this.totalDiskUpDown.Size = new System.Drawing.Size(102, 20);
            this.totalDiskUpDown.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Количество дисков";
            // 
            // genreNameLabel
            // 
            this.genreNameLabel.AutoSize = true;
            this.genreNameLabel.Location = new System.Drawing.Point(6, 75);
            this.genreNameLabel.Name = "genreNameLabel";
            this.genreNameLabel.Size = new System.Drawing.Size(36, 13);
            this.genreNameLabel.TabIndex = 5;
            this.genreNameLabel.Text = "Жанр";
            // 
            // filmNameTextBox
            // 
            this.filmNameTextBox.Location = new System.Drawing.Point(5, 42);
            this.filmNameTextBox.Name = "filmNameTextBox";
            this.filmNameTextBox.Size = new System.Drawing.Size(268, 20);
            this.filmNameTextBox.TabIndex = 2;
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.Location = new System.Drawing.Point(2, 27);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(100, 13);
            this.filmNameLabel.TabIndex = 1;
            this.filmNameLabel.Text = "Название фильма";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.searchFilm);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.searchFilmComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(704, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 569);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 155);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(213, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.genreKeyRB);
            this.groupBox6.Controls.Add(this.genreRB);
            this.groupBox6.Controls.Add(this.popularityRB);
            this.groupBox6.Controls.Add(this.ratingRB);
            this.groupBox6.Location = new System.Drawing.Point(6, 390);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 113);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Жанры";
            // 
            // genreKeyRB
            // 
            this.genreKeyRB.AutoSize = true;
            this.genreKeyRB.Location = new System.Drawing.Point(6, 18);
            this.genreKeyRB.Name = "genreKeyRB";
            this.genreKeyRB.Size = new System.Drawing.Size(86, 17);
            this.genreKeyRB.TabIndex = 3;
            this.genreKeyRB.TabStop = true;
            this.genreKeyRB.Text = "Ключ жанра";
            this.genreKeyRB.UseVisualStyleBackColor = true;
            this.genreKeyRB.CheckedChanged += new System.EventHandler(this.genreKeyRB_CheckedChanged);
            // 
            // genreRB
            // 
            this.genreRB.AutoSize = true;
            this.genreRB.Location = new System.Drawing.Point(6, 41);
            this.genreRB.Name = "genreRB";
            this.genreRB.Size = new System.Drawing.Size(54, 17);
            this.genreRB.TabIndex = 2;
            this.genreRB.TabStop = true;
            this.genreRB.Text = "Жанр";
            this.genreRB.UseVisualStyleBackColor = true;
            this.genreRB.CheckedChanged += new System.EventHandler(this.genreRB_CheckedChanged);
            // 
            // popularityRB
            // 
            this.popularityRB.AutoSize = true;
            this.popularityRB.Location = new System.Drawing.Point(6, 64);
            this.popularityRB.Name = "popularityRB";
            this.popularityRB.Size = new System.Drawing.Size(132, 17);
            this.popularityRB.TabIndex = 1;
            this.popularityRB.TabStop = true;
            this.popularityRB.Text = "Популярность жанра";
            this.popularityRB.UseVisualStyleBackColor = true;
            this.popularityRB.CheckedChanged += new System.EventHandler(this.popularityRB_CheckedChanged);
            // 
            // ratingRB
            // 
            this.ratingRB.AutoSize = true;
            this.ratingRB.Location = new System.Drawing.Point(6, 87);
            this.ratingRB.Name = "ratingRB";
            this.ratingRB.Size = new System.Drawing.Size(111, 17);
            this.ratingRB.TabIndex = 0;
            this.ratingRB.TabStop = true;
            this.ratingRB.Text = "Средний рейтинг";
            this.ratingRB.UseVisualStyleBackColor = true;
            this.ratingRB.CheckedChanged += new System.EventHandler(this.ratingRB_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.diskLeftRB);
            this.groupBox3.Controls.Add(this.diskTakenRB);
            this.groupBox3.Controls.Add(this.diskTotal);
            this.groupBox3.Location = new System.Drawing.Point(6, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 88);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильмы";
            // 
            // diskLeftRB
            // 
            this.diskLeftRB.AutoSize = true;
            this.diskLeftRB.Location = new System.Drawing.Point(6, 18);
            this.diskLeftRB.Name = "diskLeftRB";
            this.diskLeftRB.Size = new System.Drawing.Size(157, 17);
            this.diskLeftRB.TabIndex = 2;
            this.diskLeftRB.TabStop = true;
            this.diskLeftRB.Text = "Сколько осталось дисков";
            this.diskLeftRB.UseVisualStyleBackColor = true;
            this.diskLeftRB.CheckedChanged += new System.EventHandler(this.diskLeftRB_CheckedChanged);
            // 
            // diskTakenRB
            // 
            this.diskTakenRB.AutoSize = true;
            this.diskTakenRB.Location = new System.Drawing.Point(6, 39);
            this.diskTakenRB.Name = "diskTakenRB";
            this.diskTakenRB.Size = new System.Drawing.Size(145, 17);
            this.diskTakenRB.TabIndex = 1;
            this.diskTakenRB.TabStop = true;
            this.diskTakenRB.Text = "Сколько отдано дисков";
            this.diskTakenRB.UseVisualStyleBackColor = true;
            this.diskTakenRB.CheckedChanged += new System.EventHandler(this.diskTakenRB_CheckedChanged);
            // 
            // diskTotal
            // 
            this.diskTotal.AutoSize = true;
            this.diskTotal.Location = new System.Drawing.Point(6, 62);
            this.diskTotal.Name = "diskTotal";
            this.diskTotal.Size = new System.Drawing.Size(94, 17);
            this.diskTotal.TabIndex = 0;
            this.diskTotal.TabStop = true;
            this.diskTotal.Text = "Всего дисков";
            this.diskTotal.UseVisualStyleBackColor = true;
            this.diskTotal.CheckedChanged += new System.EventHandler(this.diskTotal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F);
            this.label2.Location = new System.Drawing.Point(7, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сортировать:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 522);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(214, 41);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Сбросить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchFilm
            // 
            this.searchFilm.Location = new System.Drawing.Point(5, 181);
            this.searchFilm.Name = "searchFilm";
            this.searchFilm.Size = new System.Drawing.Size(214, 41);
            this.searchFilm.TabIndex = 3;
            this.searchFilm.Text = "Поиск";
            this.searchFilm.UseVisualStyleBackColor = true;
            this.searchFilm.Click += new System.EventHandler(this.searchFilm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // searchFilmComboBox
            // 
            this.searchFilmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchFilmComboBox.FormattingEnabled = true;
            this.searchFilmComboBox.Location = new System.Drawing.Point(5, 75);
            this.searchFilmComboBox.Name = "searchFilmComboBox";
            this.searchFilmComboBox.Size = new System.Drawing.Size(214, 21);
            this.searchFilmComboBox.TabIndex = 1;
            this.searchFilmComboBox.DropDown += new System.EventHandler(this.searchFilmComboBox_DropDown);
            this.searchFilmComboBox.SelectedIndexChanged += new System.EventHandler(this.searchFilmComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.5F);
            this.label1.Location = new System.Drawing.Point(1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск фильмов по:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фильмы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(672, 521);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Жанры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(672, 521);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 166);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 553);
            this.tabControl1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(402, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "При выборе жанра в таблице показывать фильмы только с этим жанром";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 724);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDiskUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenDiskUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalDiskUpDown2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalDiskUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton diskLeftRB;
        private RadioButton diskTakenRB;
        private RadioButton diskTotal;
        private Label label2;
        private Button clearButton;
        private Button searchFilm;
        private TextBox textBox1;
        private ComboBox searchFilmComboBox;
        private Label label1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private TextBox filmNameTextBox;
        private Label filmNameLabel;
        private Button addFilm;
        private Button editFilm;
        private Label label7;
        private Label genreNameLabel;
        private Label label8;
        private ComboBox filmNameComboBox;
        private Label label9;
        private Label label12;
        private NumericUpDown totalDiskUpDown2;
        private NumericUpDown totalDiskUpDown;
        private Button deleteFilm;
        private NumericUpDown leftDiskUpDown;
        private Label label14;
        private NumericUpDown takenDiskUpDown;
        private Label label13;
        private NumericUpDown genreNumericUpDown;
        private Label label15;
        private GroupBox groupBox6;
        private RadioButton genreRB;
        private RadioButton popularityRB;
        private RadioButton ratingRB;
        private NumericUpDown genreNumericUpDown2;
        private Label label3;
        private ComboBox genreNameComboBox;
        private ComboBox genreNameComboBox2;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TabPage tabPage1;
        public DataGridView dataGridView1;
        private TabControl tabControl1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private RadioButton genreKeyRB;
    }
}