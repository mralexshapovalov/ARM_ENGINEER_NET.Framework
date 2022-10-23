namespace ARM_Engineer.Catalog_Parts
{
    partial class New_entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Load_type_textBox = new System.Windows.Forms.TextBox();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.Supplier_textBox = new System.Windows.Forms.TextBox();
            this.Cost_textBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Колличество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поставщик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена:";
            // 
            // Load_type_textBox
            // 
            this.Load_type_textBox.Location = new System.Drawing.Point(239, 161);
            this.Load_type_textBox.Name = "Load_type_textBox";
            this.Load_type_textBox.Size = new System.Drawing.Size(195, 20);
            this.Load_type_textBox.TabIndex = 4;
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(239, 199);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(195, 20);
            this.Quantity_textBox.TabIndex = 5;
            // 
            // Supplier_textBox
            // 
            this.Supplier_textBox.Location = new System.Drawing.Point(239, 234);
            this.Supplier_textBox.Name = "Supplier_textBox";
            this.Supplier_textBox.Size = new System.Drawing.Size(195, 20);
            this.Supplier_textBox.TabIndex = 6;
            // 
            // Cost_textBox
            // 
            this.Cost_textBox.Location = new System.Drawing.Point(239, 268);
            this.Cost_textBox.Name = "Cost_textBox";
            this.Cost_textBox.Size = new System.Drawing.Size(195, 20);
            this.Cost_textBox.TabIndex = 7;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(311, 375);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(123, 42);
            this.Save_button.TabIndex = 8;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // New_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Cost_textBox);
            this.Controls.Add(this.Supplier_textBox);
            this.Controls.Add(this.Quantity_textBox);
            this.Controls.Add(this.Load_type_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_entry";
            this.Text = "New_entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Load_type_textBox;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.TextBox Supplier_textBox;
        private System.Windows.Forms.TextBox Cost_textBox;
        private System.Windows.Forms.Button Save_button;
    }
}