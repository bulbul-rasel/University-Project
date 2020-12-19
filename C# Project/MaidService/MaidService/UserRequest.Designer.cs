namespace MaidService
{
    partial class UserRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.GridRequestList = new System.Windows.Forms.DataGridView();
            this.Maid_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridRequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1062, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridRequestList
            // 
            this.GridRequestList.AllowUserToAddRows = false;
            this.GridRequestList.AllowUserToDeleteRows = false;
            this.GridRequestList.AllowUserToResizeRows = false;
            this.GridRequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRequestList.BackgroundColor = System.Drawing.Color.Silver;
            this.GridRequestList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridRequestList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridRequestList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRequestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridRequestList.ColumnHeadersHeight = 30;
            this.GridRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridRequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maid_Username,
            this.Maid_Name,
            this.Work_Type,
            this.User_Username,
            this.User_Name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridRequestList.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridRequestList.EnableHeadersVisualStyles = false;
            this.GridRequestList.GridColor = System.Drawing.Color.Blue;
            this.GridRequestList.Location = new System.Drawing.Point(2, 57);
            this.GridRequestList.Name = "GridRequestList";
            this.GridRequestList.ReadOnly = true;
            this.GridRequestList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRequestList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridRequestList.RowHeadersWidth = 51;
            this.GridRequestList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridRequestList.RowTemplate.Height = 24;
            this.GridRequestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridRequestList.Size = new System.Drawing.Size(678, 465);
            this.GridRequestList.TabIndex = 1;
            // 
            // Maid_Username
            // 
            this.Maid_Username.DataPropertyName = "Maid_Username";
            this.Maid_Username.HeaderText = "Maid Username";
            this.Maid_Username.MinimumWidth = 6;
            this.Maid_Username.Name = "Maid_Username";
            this.Maid_Username.ReadOnly = true;
            // 
            // Maid_Name
            // 
            this.Maid_Name.DataPropertyName = "Maid_Name";
            this.Maid_Name.HeaderText = "Maid Name";
            this.Maid_Name.MinimumWidth = 6;
            this.Maid_Name.Name = "Maid_Name";
            this.Maid_Name.ReadOnly = true;
            // 
            // Work_Type
            // 
            this.Work_Type.DataPropertyName = "Work_Type";
            this.Work_Type.HeaderText = "Work Type";
            this.Work_Type.MinimumWidth = 6;
            this.Work_Type.Name = "Work_Type";
            this.Work_Type.ReadOnly = true;
            // 
            // User_Username
            // 
            this.User_Username.DataPropertyName = "User_Username";
            this.User_Username.HeaderText = "User Username";
            this.User_Username.MinimumWidth = 6;
            this.User_Username.Name = "User_Username";
            this.User_Username.ReadOnly = true;
            // 
            // User_Name
            // 
            this.User_Name.DataPropertyName = "User_Name";
            this.User_Name.HeaderText = "User Name";
            this.User_Name.MinimumWidth = 6;
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(732, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(732, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridRequestList);
            this.Controls.Add(this.button1);
            this.Name = "UserRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRequest";
            this.Load += new System.EventHandler(this.UserRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridRequestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridRequestList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maid_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}