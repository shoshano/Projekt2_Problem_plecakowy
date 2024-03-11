namespace GUI_Problem_plecakowy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_number_of_items = new TextBox();
            textBox_seed = new TextBox();
            textBox_capacity = new TextBox();
            label_number_of_items = new Label();
            label_seed = new Label();
            label_capacity = new Label();
            buttom_start = new Button();
            textBox_list_of_items = new TextBox();
            textBox_items_in_backpack = new TextBox();
            label_list_of_items = new Label();
            label_backpack = new Label();
            label_title = new Label();
            SuspendLayout();
            // 
            // textBox_number_of_items
            // 
            textBox_number_of_items.Location = new Point(81, 110);
            textBox_number_of_items.Name = "textBox_number_of_items";
            textBox_number_of_items.Size = new Size(140, 23);
            textBox_number_of_items.TabIndex = 0;
            textBox_number_of_items.TextChanged += textBox_number_of_items_TextChanged;
            // 
            // textBox_seed
            // 
            textBox_seed.Location = new Point(81, 179);
            textBox_seed.Name = "textBox_seed";
            textBox_seed.Size = new Size(140, 23);
            textBox_seed.TabIndex = 1;
            textBox_seed.TextChanged += textBox_seed_TextChanged;
            // 
            // textBox_capacity
            // 
            textBox_capacity.Location = new Point(81, 256);
            textBox_capacity.Name = "textBox_capacity";
            textBox_capacity.Size = new Size(140, 23);
            textBox_capacity.TabIndex = 2;
            textBox_capacity.TextChanged += textBox_capacity_TextChanged;
            // 
            // label_number_of_items
            // 
            label_number_of_items.AutoSize = true;
            label_number_of_items.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_number_of_items.Location = new Point(70, 88);
            label_number_of_items.Name = "label_number_of_items";
            label_number_of_items.Size = new Size(176, 19);
            label_number_of_items.TabIndex = 3;
            label_number_of_items.Text = "Liczba przedmiotów";
            // 
            // label_seed
            // 
            label_seed.AutoSize = true;
            label_seed.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_seed.Location = new Point(70, 157);
            label_seed.Name = "label_seed";
            label_seed.Size = new Size(157, 19);
            label_seed.TabIndex = 4;
            label_seed.Text = "Ziarno losowania";
            // 
            // label_capacity
            // 
            label_capacity.AutoSize = true;
            label_capacity.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_capacity.Location = new Point(70, 234);
            label_capacity.Name = "label_capacity";
            label_capacity.Size = new Size(151, 19);
            label_capacity.TabIndex = 5;
            label_capacity.Text = "Rozmiar plecaka";
            // 
            // buttom_start
            // 
            buttom_start.BackColor = Color.Plum;
            buttom_start.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttom_start.ForeColor = SystemColors.ControlText;
            buttom_start.Location = new Point(70, 306);
            buttom_start.Name = "buttom_start";
            buttom_start.Size = new Size(168, 61);
            buttom_start.TabIndex = 6;
            buttom_start.Text = "START";
            buttom_start.UseVisualStyleBackColor = false;
            buttom_start.Click += buttom_start_Click;
            // 
            // textBox_list_of_items
            // 
            textBox_list_of_items.Location = new Point(317, 123);
            textBox_list_of_items.Multiline = true;
            textBox_list_of_items.Name = "textBox_list_of_items";
            textBox_list_of_items.ReadOnly = true;
            textBox_list_of_items.Size = new Size(248, 567);
            textBox_list_of_items.TabIndex = 7;
            // 
            // textBox_items_in_backpack
            // 
            textBox_items_in_backpack.Location = new Point(40, 452);
            textBox_items_in_backpack.Multiline = true;
            textBox_items_in_backpack.Name = "textBox_items_in_backpack";
            textBox_items_in_backpack.ReadOnly = true;
            textBox_items_in_backpack.Size = new Size(249, 238);
            textBox_items_in_backpack.TabIndex = 8;
            // 
            // label_list_of_items
            // 
            label_list_of_items.AutoSize = true;
            label_list_of_items.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_list_of_items.Location = new Point(317, 87);
            label_list_of_items.Name = "label_list_of_items";
            label_list_of_items.Size = new Size(167, 19);
            label_list_of_items.TabIndex = 9;
            label_list_of_items.Text = "Lista przedmiotów";
            // 
            // label_backpack
            // 
            label_backpack.AutoSize = true;
            label_backpack.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_backpack.Location = new Point(40, 420);
            label_backpack.Name = "label_backpack";
            label_backpack.Size = new Size(155, 19);
            label_backpack.TabIndex = 10;
            label_backpack.Text = "Rzeczy w plecaku";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Stencil", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_title.Location = new Point(116, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(352, 38);
            label_title.TabIndex = 11;
            label_title.Text = "Problem Plecakowy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(601, 718);
            Controls.Add(label_title);
            Controls.Add(label_backpack);
            Controls.Add(label_list_of_items);
            Controls.Add(textBox_items_in_backpack);
            Controls.Add(textBox_list_of_items);
            Controls.Add(buttom_start);
            Controls.Add(label_capacity);
            Controls.Add(label_seed);
            Controls.Add(label_number_of_items);
            Controls.Add(textBox_capacity);
            Controls.Add(textBox_seed);
            Controls.Add(textBox_number_of_items);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_number_of_items;
        private TextBox textBox_seed;
        private TextBox textBox_capacity;
        private Label label_number_of_items;
        private Label label_seed;
        private Label label_capacity;
        private Button buttom_start;
        private TextBox textBox_list_of_items;
        private TextBox textBox_items_in_backpack;
        private Label label_list_of_items;
        private Label label_backpack;
        private Label label_title;
    }
}
