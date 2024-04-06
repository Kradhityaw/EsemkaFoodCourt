namespace EsemkaFoodCourt
{
    partial class FormReserveTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerEmailLabel;
            System.Windows.Forms.Label customerFirstNameLabel;
            System.Windows.Forms.Label customerLastNameLabel;
            System.Windows.Forms.Label customerPhoneNumberLabel;
            System.Windows.Forms.Label numberOfPeopleLabel;
            System.Windows.Forms.Label reservationDateLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPeopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.reservationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reservationDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menucol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            customerEmailLabel = new System.Windows.Forms.Label();
            customerFirstNameLabel = new System.Windows.Forms.Label();
            customerLastNameLabel = new System.Windows.Forms.Label();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            numberOfPeopleLabel = new System.Windows.Forms.Label();
            reservationDateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.Location = new System.Drawing.Point(22, 129);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new System.Drawing.Size(66, 25);
            customerEmailLabel.TabIndex = 5;
            customerEmailLabel.Text = "Email:";
            // 
            // customerFirstNameLabel
            // 
            customerFirstNameLabel.AutoSize = true;
            customerFirstNameLabel.Location = new System.Drawing.Point(22, 42);
            customerFirstNameLabel.Name = "customerFirstNameLabel";
            customerFirstNameLabel.Size = new System.Drawing.Size(112, 25);
            customerFirstNameLabel.TabIndex = 7;
            customerFirstNameLabel.Text = "First Name:";
            // 
            // customerLastNameLabel
            // 
            customerLastNameLabel.AutoSize = true;
            customerLastNameLabel.Location = new System.Drawing.Point(295, 42);
            customerLastNameLabel.Name = "customerLastNameLabel";
            customerLastNameLabel.Size = new System.Drawing.Size(112, 25);
            customerLastNameLabel.TabIndex = 9;
            customerLastNameLabel.Text = "Last Name:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(22, 221);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(149, 25);
            customerPhoneNumberLabel.TabIndex = 11;
            customerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // numberOfPeopleLabel
            // 
            numberOfPeopleLabel.AutoSize = true;
            numberOfPeopleLabel.Location = new System.Drawing.Point(27, 132);
            numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            numberOfPeopleLabel.Size = new System.Drawing.Size(179, 25);
            numberOfPeopleLabel.TabIndex = 13;
            numberOfPeopleLabel.Text = "Number Of People:";
            // 
            // reservationDateLabel
            // 
            reservationDateLabel.AutoSize = true;
            reservationDateLabel.Location = new System.Drawing.Point(27, 90);
            reservationDateLabel.Name = "reservationDateLabel";
            reservationDateLabel.Size = new System.Drawing.Size(59, 25);
            reservationDateLabel.TabIndex = 15;
            reservationDateLabel.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 25);
            label2.TabIndex = 19;
            label2.Text = "Choose Table:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 43);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(142, 25);
            label3.TabIndex = 22;
            label3.Text = "Choose Menu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 91);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 25);
            label4.TabIndex = 22;
            label4.Text = "Qty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reserve Table";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EsemkaFoodCourt.Reservation);
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(27, 157);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(509, 29);
            this.customerEmailTextBox.TabIndex = 6;
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(27, 70);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(238, 29);
            this.customerFirstNameTextBox.TabIndex = 8;
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Location = new System.Drawing.Point(300, 70);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(238, 29);
            this.customerLastNameTextBox.TabIndex = 10;
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(27, 249);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(509, 29);
            this.customerPhoneNumberTextBox.TabIndex = 12;
            this.customerPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerPhoneNumberTextBox_KeyPress);
            // 
            // numberOfPeopleNumericUpDown
            // 
            this.numberOfPeopleNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "NumberOfPeople", true));
            this.numberOfPeopleNumericUpDown.Location = new System.Drawing.Point(222, 132);
            this.numberOfPeopleNumericUpDown.Name = "numberOfPeopleNumericUpDown";
            this.numberOfPeopleNumericUpDown.Size = new System.Drawing.Size(372, 29);
            this.numberOfPeopleNumericUpDown.TabIndex = 14;
            // 
            // reservationDateDateTimePicker
            // 
            this.reservationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "ReservationDate", true));
            this.reservationDateDateTimePicker.Location = new System.Drawing.Point(224, 86);
            this.reservationDateDateTimePicker.Name = "reservationDateDateTimePicker";
            this.reservationDateDateTimePicker.Size = new System.Drawing.Size(370, 29);
            this.reservationDateDateTimePicker.TabIndex = 16;
            this.reservationDateDateTimePicker.ValueChanged += new System.EventHandler(this.reservationDateDateTimePicker_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(customerFirstNameLabel);
            this.groupBox1.Controls.Add(this.customerPhoneNumberTextBox);
            this.groupBox1.Controls.Add(customerPhoneNumberLabel);
            this.groupBox1.Controls.Add(this.customerEmailTextBox);
            this.groupBox1.Controls.Add(customerEmailLabel);
            this.groupBox1.Controls.Add(this.customerFirstNameTextBox);
            this.groupBox1.Controls.Add(customerLastNameLabel);
            this.groupBox1.Controls.Add(this.customerLastNameTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(32, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 303);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(32, 589);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(442, 29);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Use the same information as logged in account";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tableBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 32);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "ID";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(EsemkaFoodCourt.Table);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reservationDetailDataGridView);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Location = new System.Drawing.Point(619, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 490);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // reservationDetailDataGridView
            // 
            this.reservationDetailDataGridView.AllowUserToAddRows = false;
            this.reservationDetailDataGridView.AllowUserToDeleteRows = false;
            this.reservationDetailDataGridView.AutoGenerateColumns = false;
            this.reservationDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.menucol,
            this.dataGridViewTextBoxColumn4,
            this.pricecol,
            this.subcol,
            this.actioncol,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.reservationDetailDataGridView.DataSource = this.reservationDetailBindingSource;
            this.reservationDetailDataGridView.Location = new System.Drawing.Point(6, 142);
            this.reservationDetailDataGridView.Name = "reservationDetailDataGridView";
            this.reservationDetailDataGridView.ReadOnly = true;
            this.reservationDetailDataGridView.RowHeadersVisible = false;
            this.reservationDetailDataGridView.RowHeadersWidth = 72;
            this.reservationDetailDataGridView.RowTemplate.Height = 31;
            this.reservationDetailDataGridView.Size = new System.Drawing.Size(744, 342);
            this.reservationDetailDataGridView.TabIndex = 24;
            this.reservationDetailDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationDetailDataGridView_CellContentClick);
            this.reservationDetailDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.reservationDetailDataGridView_CellFormatting);
            this.reservationDetailDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.reservationDetailDataGridView_RowsAdded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // menucol
            // 
            this.menucol.DataPropertyName = "Menu";
            this.menucol.HeaderText = "Menu";
            this.menucol.MinimumWidth = 9;
            this.menucol.Name = "menucol";
            this.menucol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // pricecol
            // 
            this.pricecol.HeaderText = "Price";
            this.pricecol.MinimumWidth = 9;
            this.pricecol.Name = "pricecol";
            this.pricecol.ReadOnly = true;
            // 
            // subcol
            // 
            this.subcol.HeaderText = "Subtotal";
            this.subcol.MinimumWidth = 9;
            this.subcol.Name = "subcol";
            this.subcol.ReadOnly = true;
            // 
            // actioncol
            // 
            this.actioncol.HeaderText = "Action";
            this.actioncol.MinimumWidth = 9;
            this.actioncol.Name = "actioncol";
            this.actioncol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ReservationID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ReservationID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MenuID";
            this.dataGridViewTextBoxColumn3.HeaderText = "MenuID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Reservation";
            this.dataGridViewTextBoxColumn6.HeaderText = "Reservation";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // reservationDetailBindingSource
            // 
            this.reservationDetailBindingSource.DataSource = typeof(EsemkaFoodCourt.ReservationDetail);
            this.reservationDetailBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.reservationDetailBindingSource_ListChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.menuBindingSource1;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(370, 32);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "ID";
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataSource = typeof(EsemkaFoodCourt.Menu);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "NumberOfPeople", true));
            this.numericUpDown1.Location = new System.Drawing.Point(220, 91);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(372, 29);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 791);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1107, 791);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 45);
            this.button3.TabIndex = 23;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(905, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Reservation Fee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(948, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Menu Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(954, 675);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Total Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1166, 675);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1166, 631);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Menu Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1166, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Rp50.000.00";
            // 
            // FormReserveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 861);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(numberOfPeopleLabel);
            this.Controls.Add(this.numberOfPeopleNumericUpDown);
            this.Controls.Add(reservationDateLabel);
            this.Controls.Add(this.reservationDateDateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "FormReserveTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReserveTable";
            this.Load += new System.EventHandler(this.FormReserveTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.NumericUpDown numberOfPeopleNumericUpDown;
        private System.Windows.Forms.DateTimePicker reservationDateDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private System.Windows.Forms.DataGridView reservationDetailDataGridView;
        private System.Windows.Forms.BindingSource reservationDetailBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menucol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcol;
        private System.Windows.Forms.DataGridViewButtonColumn actioncol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}