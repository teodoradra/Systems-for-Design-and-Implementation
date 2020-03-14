namespace Practical_Work_1
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
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.CID_add = new System.Windows.Forms.TextBox();
            this.SID_add = new System.Windows.Forms.TextBox();
            this.EmID_add = new System.Windows.Forms.TextBox();
            this.TyID_add = new System.Windows.Forms.TextBox();
            this.AtID_add = new System.Windows.Forms.TextBox();
            this.Date_add = new System.Windows.Forms.TextBox();
            this.Price_add = new System.Windows.Forms.TextBox();
            this.Duration_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Duration_delete = new System.Windows.Forms.TextBox();
            this.Price_delete = new System.Windows.Forms.TextBox();
            this.AtID_delete = new System.Windows.Forms.TextBox();
            this.TyID_Delete = new System.Windows.Forms.TextBox();
            this.EmID_delete = new System.Windows.Forms.TextBox();
            this.SID_delete = new System.Windows.Forms.TextBox();
            this.CID_delete = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Date_delete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(10, 26);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowTemplate.Height = 40;
            this.dgvClient.Size = new System.Drawing.Size(1639, 592);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(2308, 12);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowTemplate.Height = 40;
            this.dgvAppointment.Size = new System.Drawing.Size(1678, 657);
            this.dgvAppointment.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1702, 237);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(559, 142);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update DB";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1086, 954);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(563, 147);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(2403, 947);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(563, 147);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CID_add
            // 
            this.CID_add.Location = new System.Drawing.Point(391, 763);
            this.CID_add.Name = "CID_add";
            this.CID_add.Size = new System.Drawing.Size(386, 38);
            this.CID_add.TabIndex = 5;
            // 
            // SID_add
            // 
            this.SID_add.Location = new System.Drawing.Point(391, 845);
            this.SID_add.Name = "SID_add";
            this.SID_add.Size = new System.Drawing.Size(386, 38);
            this.SID_add.TabIndex = 6;
            // 
            // EmID_add
            // 
            this.EmID_add.Location = new System.Drawing.Point(391, 915);
            this.EmID_add.Name = "EmID_add";
            this.EmID_add.Size = new System.Drawing.Size(386, 38);
            this.EmID_add.TabIndex = 7;
            // 
            // TyID_add
            // 
            this.TyID_add.Location = new System.Drawing.Point(391, 991);
            this.TyID_add.Name = "TyID_add";
            this.TyID_add.Size = new System.Drawing.Size(386, 38);
            this.TyID_add.TabIndex = 8;
            // 
            // AtID_add
            // 
            this.AtID_add.Location = new System.Drawing.Point(391, 1066);
            this.AtID_add.Name = "AtID_add";
            this.AtID_add.Size = new System.Drawing.Size(386, 38);
            this.AtID_add.TabIndex = 9;
            // 
            // Date_add
            // 
            this.Date_add.Location = new System.Drawing.Point(391, 1315);
            this.Date_add.Name = "Date_add";
            this.Date_add.Size = new System.Drawing.Size(386, 38);
            this.Date_add.TabIndex = 10;
            // 
            // Price_add
            // 
            this.Price_add.Location = new System.Drawing.Point(391, 1238);
            this.Price_add.Name = "Price_add";
            this.Price_add.Size = new System.Drawing.Size(386, 38);
            this.Price_add.TabIndex = 11;
            // 
            // Duration_add
            // 
            this.Duration_add.Location = new System.Drawing.Point(391, 1150);
            this.Duration_add.Name = "Duration_add";
            this.Duration_add.Size = new System.Drawing.Size(386, 38);
            this.Duration_add.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 763);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "CID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 845);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "SID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 915);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "EmID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 991);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "TyID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 1066);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "AtID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 1150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 1238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 1321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3268, 1255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3268, 1164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3268, 1080);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 32);
            this.label12.TabIndex = 25;
            this.label12.Text = "AtID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3262, 1005);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 32);
            this.label13.TabIndex = 24;
            this.label13.Text = "TyID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3262, 929);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 32);
            this.label14.TabIndex = 23;
            this.label14.Text = "EmID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3262, 859);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 32);
            this.label15.TabIndex = 22;
            this.label15.Text = "SID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3262, 777);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 32);
            this.label16.TabIndex = 21;
            this.label16.Text = "CID";
            // 
            // Duration_delete
            // 
            this.Duration_delete.Location = new System.Drawing.Point(3441, 1164);
            this.Duration_delete.Name = "Duration_delete";
            this.Duration_delete.Size = new System.Drawing.Size(386, 38);
            this.Duration_delete.TabIndex = 36;
            // 
            // Price_delete
            // 
            this.Price_delete.Location = new System.Drawing.Point(3441, 1252);
            this.Price_delete.Name = "Price_delete";
            this.Price_delete.Size = new System.Drawing.Size(386, 38);
            this.Price_delete.TabIndex = 35;
            // 
            // AtID_delete
            // 
            this.AtID_delete.Location = new System.Drawing.Point(3441, 1080);
            this.AtID_delete.Name = "AtID_delete";
            this.AtID_delete.Size = new System.Drawing.Size(386, 38);
            this.AtID_delete.TabIndex = 33;
            // 
            // TyID_Delete
            // 
            this.TyID_Delete.Location = new System.Drawing.Point(3441, 1005);
            this.TyID_Delete.Name = "TyID_Delete";
            this.TyID_Delete.Size = new System.Drawing.Size(386, 38);
            this.TyID_Delete.TabIndex = 32;
            // 
            // EmID_delete
            // 
            this.EmID_delete.Location = new System.Drawing.Point(3441, 929);
            this.EmID_delete.Name = "EmID_delete";
            this.EmID_delete.Size = new System.Drawing.Size(386, 38);
            this.EmID_delete.TabIndex = 31;
            // 
            // SID_delete
            // 
            this.SID_delete.Location = new System.Drawing.Point(3441, 859);
            this.SID_delete.Name = "SID_delete";
            this.SID_delete.Size = new System.Drawing.Size(386, 38);
            this.SID_delete.TabIndex = 30;
            // 
            // CID_delete
            // 
            this.CID_delete.Location = new System.Drawing.Point(3441, 777);
            this.CID_delete.Name = "CID_delete";
            this.CID_delete.Size = new System.Drawing.Size(386, 38);
            this.CID_delete.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3268, 1334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 32);
            this.label17.TabIndex = 38;
            this.label17.Text = "Date";
            // 
            // Date_delete
            // 
            this.Date_delete.Location = new System.Drawing.Point(3440, 1331);
            this.Date_delete.Name = "Date_delete";
            this.Date_delete.Size = new System.Drawing.Size(386, 38);
            this.Date_delete.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(4050, 1599);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Date_delete);
            this.Controls.Add(this.Duration_delete);
            this.Controls.Add(this.Price_delete);
            this.Controls.Add(this.AtID_delete);
            this.Controls.Add(this.TyID_Delete);
            this.Controls.Add(this.EmID_delete);
            this.Controls.Add(this.SID_delete);
            this.Controls.Add(this.CID_delete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Duration_add);
            this.Controls.Add(this.Price_add);
            this.Controls.Add(this.Date_add);
            this.Controls.Add(this.AtID_add);
            this.Controls.Add(this.TyID_add);
            this.Controls.Add(this.EmID_add);
            this.Controls.Add(this.SID_add);
            this.Controls.Add(this.CID_add);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.dgvClient);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox CID_add;
        private System.Windows.Forms.TextBox SID_add;
        private System.Windows.Forms.TextBox EmID_add;
        private System.Windows.Forms.TextBox TyID_add;
        private System.Windows.Forms.TextBox AtID_add;
        private System.Windows.Forms.TextBox Date_add;
        private System.Windows.Forms.TextBox Price_add;
        private System.Windows.Forms.TextBox Duration_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Duration_delete;
        private System.Windows.Forms.TextBox Price_delete;
        private System.Windows.Forms.TextBox AtID_delete;
        private System.Windows.Forms.TextBox TyID_Delete;
        private System.Windows.Forms.TextBox EmID_delete;
        private System.Windows.Forms.TextBox SID_delete;
        private System.Windows.Forms.TextBox CID_delete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Date_delete;
    }
}

