namespace AnimalPark.Food
{
    partial class FoodItemForm
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
            this.label_Foodname = new System.Windows.Forms.Label();
            this.textBox_Foodname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.textBox_ingedient = new System.Windows.Forms.TextBox();
            this.label_ingredient = new System.Windows.Forms.Label();
            this.RB_Recipe = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Foodname
            // 
            this.label_Foodname.AutoSize = true;
            this.label_Foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Foodname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Foodname.Location = new System.Drawing.Point(17, 31);
            this.label_Foodname.Name = "label_Foodname";
            this.label_Foodname.Size = new System.Drawing.Size(74, 25);
            this.label_Foodname.TabIndex = 1;
            this.label_Foodname.Text = "Name:";
            // 
            // textBox_Foodname
            // 
            this.textBox_Foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Foodname.Location = new System.Drawing.Point(97, 27);
            this.textBox_Foodname.Name = "textBox_Foodname";
            this.textBox_Foodname.Size = new System.Drawing.Size(229, 26);
            this.textBox_Foodname.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Recipe);
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.button_change);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.textBox_ingedient);
            this.groupBox1.Controls.Add(this.label_ingredient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.groupBox1.Size = new System.Drawing.Size(325, 275);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add ingredient";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.LightGray;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_cancel.Location = new System.Drawing.Point(173, 232);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 31);
            this.button_cancel.TabIndex = 36;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.LightGray;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ok.Location = new System.Drawing.Point(27, 232);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(124, 31);
            this.button_ok.TabIndex = 35;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.Color.LightGray;
            this.button_change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_change.Location = new System.Drawing.Point(13, 123);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(84, 31);
            this.button_change.TabIndex = 33;
            this.button_change.Text = "Change";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightGray;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_delete.Location = new System.Drawing.Point(13, 175);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(84, 31);
            this.button_delete.TabIndex = 32;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.LightGray;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_button.Location = new System.Drawing.Point(13, 72);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(84, 31);
            this.add_button.TabIndex = 31;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // textBox_ingedient
            // 
            this.textBox_ingedient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ingedient.Location = new System.Drawing.Point(114, 28);
            this.textBox_ingedient.Name = "textBox_ingedient";
            this.textBox_ingedient.Size = new System.Drawing.Size(196, 26);
            this.textBox_ingedient.TabIndex = 6;
            // 
            // label_ingredient
            // 
            this.label_ingredient.AutoSize = true;
            this.label_ingredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingredient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_ingredient.Location = new System.Drawing.Point(9, 33);
            this.label_ingredient.Name = "label_ingredient";
            this.label_ingredient.Size = new System.Drawing.Size(99, 24);
            this.label_ingredient.TabIndex = 6;
            this.label_ingredient.Text = "Ingredient:";
            // 
            // RB_Recipe
            // 
            this.RB_Recipe.FormattingEnabled = true;
            this.RB_Recipe.ItemHeight = 24;
            this.RB_Recipe.Location = new System.Drawing.Point(114, 72);
            this.RB_Recipe.Name = "RB_Recipe";
            this.RB_Recipe.Size = new System.Drawing.Size(196, 148);
            this.RB_Recipe.TabIndex = 37;
            // 
            // FoodItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Foodname);
            this.Controls.Add(this.label_Foodname);
            this.Name = "FoodItemForm";
            this.Text = "Add Food";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Foodname;
        private System.Windows.Forms.TextBox textBox_Foodname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ingedient;
        private System.Windows.Forms.Label label_ingredient;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.ListBox RB_Recipe;
    }
}