namespace Menu
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
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.ButtonAddMenu = new System.Windows.Forms.Button();
            this.ButtonSubMenu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(12, 69);
            this.TopLevelMenu.Multiline = true;
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(362, 43);
            this.TopLevelMenu.TabIndex = 0;
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(12, 146);
            this.SubItem.Multiline = true;
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(362, 43);
            this.SubItem.TabIndex = 1;
            // 
            // ButtonAddMenu
            // 
            this.ButtonAddMenu.Location = new System.Drawing.Point(12, 443);
            this.ButtonAddMenu.Name = "ButtonAddMenu";
            this.ButtonAddMenu.Size = new System.Drawing.Size(92, 37);
            this.ButtonAddMenu.TabIndex = 2;
            this.ButtonAddMenu.Text = "Add menu item";
            this.ButtonAddMenu.UseVisualStyleBackColor = true;
            this.ButtonAddMenu.Click += new System.EventHandler(this.ButtonAddMenu_Click);
            // 
            // ButtonSubMenu
            // 
            this.ButtonSubMenu.Location = new System.Drawing.Point(282, 443);
            this.ButtonSubMenu.Name = "ButtonSubMenu";
            this.ButtonSubMenu.Size = new System.Drawing.Size(92, 37);
            this.ButtonSubMenu.TabIndex = 3;
            this.ButtonSubMenu.Text = "Add submenu";
            this.ButtonSubMenu.UseVisualStyleBackColor = true;
            this.ButtonSubMenu.Click += new System.EventHandler(this.ButtonSubMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "SubMenu text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(386, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSubMenu);
            this.Controls.Add(this.ButtonAddMenu);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.Button ButtonAddMenu;
        private System.Windows.Forms.Button ButtonSubMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

