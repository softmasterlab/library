namespace Library
{
    partial class ManagersForm
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
            this.managersList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactsBox = new System.Windows.Forms.TextBox();
            this.addManager = new System.Windows.Forms.Button();
            this.saveManager = new System.Windows.Forms.Button();
            this.delManager = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // managersList
            // 
            this.managersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.managersList.HideSelection = false;
            this.managersList.Location = new System.Drawing.Point(12, 12);
            this.managersList.Name = "managersList";
            this.managersList.Size = new System.Drawing.Size(409, 168);
            this.managersList.TabIndex = 0;
            this.managersList.UseCompatibleStateImageBehavior = false;
            this.managersList.View = System.Windows.Forms.View.Details;
            this.managersList.SelectedIndexChanged += new System.EventHandler(this.managersList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ф.И.О:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(94, 195);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(267, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Контакты:";
            // 
            // contactsBox
            // 
            this.contactsBox.Location = new System.Drawing.Point(94, 223);
            this.contactsBox.Multiline = true;
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(267, 100);
            this.contactsBox.TabIndex = 4;
            // 
            // addManager
            // 
            this.addManager.Location = new System.Drawing.Point(38, 338);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(113, 23);
            this.addManager.TabIndex = 5;
            this.addManager.Text = "Добавить";
            this.addManager.UseVisualStyleBackColor = true;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // saveManager
            // 
            this.saveManager.Location = new System.Drawing.Point(157, 338);
            this.saveManager.Name = "saveManager";
            this.saveManager.Size = new System.Drawing.Size(114, 23);
            this.saveManager.TabIndex = 6;
            this.saveManager.Text = "Сохранить";
            this.saveManager.UseVisualStyleBackColor = true;
            this.saveManager.Click += new System.EventHandler(this.saveManager_Click);
            // 
            // delManager
            // 
            this.delManager.Location = new System.Drawing.Point(277, 338);
            this.delManager.Name = "delManager";
            this.delManager.Size = new System.Drawing.Size(118, 23);
            this.delManager.TabIndex = 7;
            this.delManager.Text = "Удалить";
            this.delManager.UseVisualStyleBackColor = true;
            this.delManager.Click += new System.EventHandler(this.delManager_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия, имя";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Контакты";
            this.columnHeader3.Width = 205;
            // 
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 383);
            this.Controls.Add(this.delManager);
            this.Controls.Add(this.saveManager);
            this.Controls.Add(this.addManager);
            this.Controls.Add(this.contactsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managersList);
            this.Name = "ManagersForm";
            this.Text = "ManagersForm";
            this.Load += new System.EventHandler(this.ManagersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView managersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactsBox;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.Button saveManager;
        private System.Windows.Forms.Button delManager;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}