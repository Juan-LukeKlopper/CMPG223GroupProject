namespace _223Project
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.modelDataSet = new _223Project.ModelDataSet();
            this.librarianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarianTableAdapter = new _223Project.ModelDataSetTableAdapters.LibrarianTableAdapter();
            this.tableAdapterManager = new _223Project.ModelDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvLibrarian = new System.Windows.Forms.DataGridView();
            this.librarianIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfHireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbIDp = new System.Windows.Forms.TextBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your action below.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 578);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.lbText);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.tbConfirm);
            this.tabPage1.Controls.Add(this.tbNew);
            this.tabPage1.Controls.Add(this.tbCurrent);
            this.tabPage1.Controls.Add(this.tbIDp);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvLibrarian);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbPassword);
            this.tabPage2.Controls.Add(this.tbLName);
            this.tabPage2.Controls.Add(this.tbID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hire new Librarian";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.dgvDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(879, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fire Librarian";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librarianBindingSource
            // 
            this.librarianBindingSource.DataMember = "Librarian";
            this.librarianBindingSource.DataSource = this.modelDataSet;
            // 
            // librarianTableAdapter
            // 
            this.librarianTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibrarianTableAdapter = this.librarianTableAdapter;
            this.tableAdapterManager.UpdateOrder = _223Project.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Librarian ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Librarian Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(182, 335);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(181, 22);
            this.tbID.TabIndex = 5;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(182, 377);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(181, 22);
            this.tbLName.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(182, 419);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(181, 22);
            this.tbPassword.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Add new Librarian:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(369, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "(Librarian ID must be 8 didgets long)";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(369, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "(Password must contain 6 - 30 characters) ";
            this.label7.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add new Librarian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 49);
            this.button2.TabIndex = 12;
            this.button2.Text = "Exit program";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(369, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "(ID, Name or password field must have values)";
            this.label8.Visible = false;
            // 
            // dgvLibrarian
            // 
            this.dgvLibrarian.AutoGenerateColumns = false;
            this.dgvLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrarian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.librarianIDDataGridViewTextBoxColumn,
            this.librarianNameDataGridViewTextBoxColumn,
            this.librarianPasswordDataGridViewTextBoxColumn,
            this.dateOfHireDataGridViewTextBoxColumn});
            this.dgvLibrarian.DataSource = this.librarianBindingSource;
            this.dgvLibrarian.Location = new System.Drawing.Point(17, 20);
            this.dgvLibrarian.Name = "dgvLibrarian";
            this.dgvLibrarian.RowHeadersWidth = 51;
            this.dgvLibrarian.RowTemplate.Height = 24;
            this.dgvLibrarian.Size = new System.Drawing.Size(773, 249);
            this.dgvLibrarian.TabIndex = 14;
            // 
            // librarianIDDataGridViewTextBoxColumn
            // 
            this.librarianIDDataGridViewTextBoxColumn.DataPropertyName = "Librarian_ID";
            this.librarianIDDataGridViewTextBoxColumn.HeaderText = "Librarian_ID";
            this.librarianIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.librarianIDDataGridViewTextBoxColumn.Name = "librarianIDDataGridViewTextBoxColumn";
            this.librarianIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // librarianNameDataGridViewTextBoxColumn
            // 
            this.librarianNameDataGridViewTextBoxColumn.DataPropertyName = "Librarian_Name";
            this.librarianNameDataGridViewTextBoxColumn.HeaderText = "Librarian_Name";
            this.librarianNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.librarianNameDataGridViewTextBoxColumn.Name = "librarianNameDataGridViewTextBoxColumn";
            this.librarianNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // librarianPasswordDataGridViewTextBoxColumn
            // 
            this.librarianPasswordDataGridViewTextBoxColumn.DataPropertyName = "Librarian_Password";
            this.librarianPasswordDataGridViewTextBoxColumn.HeaderText = "Librarian_Password";
            this.librarianPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.librarianPasswordDataGridViewTextBoxColumn.Name = "librarianPasswordDataGridViewTextBoxColumn";
            this.librarianPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfHireDataGridViewTextBoxColumn
            // 
            this.dateOfHireDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Hire";
            this.dateOfHireDataGridViewTextBoxColumn.HeaderText = "Date_Of_Hire";
            this.dateOfHireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfHireDataGridViewTextBoxColumn.Name = "dateOfHireDataGridViewTextBoxColumn";
            this.dateOfHireDataGridViewTextBoxColumn.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Change password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Your ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Current Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "New password:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Confirm password:";
            // 
            // tbIDp
            // 
            this.tbIDp.Location = new System.Drawing.Point(233, 91);
            this.tbIDp.Name = "tbIDp";
            this.tbIDp.Size = new System.Drawing.Size(214, 30);
            this.tbIDp.TabIndex = 5;
            this.tbIDp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDp_KeyPress);
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(233, 140);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(214, 30);
            this.tbCurrent.TabIndex = 6;
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(233, 197);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(214, 30);
            this.tbNew.TabIndex = 7;
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(233, 247);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(214, 30);
            this.tbConfirm.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(474, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "Change password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(474, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 51);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit program";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(100, 305);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 25);
            this.lbText.TabIndex = 11;
            this.lbText.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(453, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "(ID can only be numbers)";
            // 
            // dgvDelete
            // 
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Location = new System.Drawing.Point(14, 16);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.RowHeadersWidth = 51;
            this.dgvDelete.RowTemplate.Height = 24;
            this.dgvDelete.Size = new System.Drawing.Size(755, 335);
            this.dgvDelete.TabIndex = 0;
            this.dgvDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelete_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(838, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Select the person you wish to fire by selecting any cell in that row:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 463);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 43);
            this.button6.TabIndex = 3;
            this.button6.Text = "Exit program";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(253, 25);
            this.label16.TabIndex = 5;
            this.label16.Text = "Make sure it is the right row:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 424);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(648, 25);
            this.label17.TabIndex = 6;
            this.label17.Text = "Once a cell is selected a message will pop up asking if you want to delete:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 634);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource librarianBindingSource;
        private ModelDataSetTableAdapters.LibrarianTableAdapter librarianTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvLibrarian;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfHireDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbIDp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

