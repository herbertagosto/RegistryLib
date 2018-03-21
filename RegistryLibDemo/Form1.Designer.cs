namespace RegistryLibDemo
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
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_DeleteKey = new System.Windows.Forms.Button();
            this.btn_DeleteSubKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(35, 30);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(35, 69);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Write.TabIndex = 1;
            this.btn_Write.Text = "Write";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_DeleteKey
            // 
            this.btn_DeleteKey.Location = new System.Drawing.Point(35, 110);
            this.btn_DeleteKey.Name = "btn_DeleteKey";
            this.btn_DeleteKey.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteKey.TabIndex = 2;
            this.btn_DeleteKey.Text = "Delete Key";
            this.btn_DeleteKey.UseVisualStyleBackColor = true;
            this.btn_DeleteKey.Click += new System.EventHandler(this.btn_DeleteKey_Click);
            // 
            // btn_DeleteSubKey
            // 
            this.btn_DeleteSubKey.Location = new System.Drawing.Point(35, 152);
            this.btn_DeleteSubKey.Name = "btn_DeleteSubKey";
            this.btn_DeleteSubKey.Size = new System.Drawing.Size(101, 23);
            this.btn_DeleteSubKey.TabIndex = 3;
            this.btn_DeleteSubKey.Text = "Delete Subkey";
            this.btn_DeleteSubKey.UseVisualStyleBackColor = true;
            this.btn_DeleteSubKey.Click += new System.EventHandler(this.btn_DeleteSubKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_DeleteSubKey);
            this.Controls.Add(this.btn_DeleteKey);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_Read);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Button btn_DeleteKey;
        private System.Windows.Forms.Button btn_DeleteSubKey;
    }
}

