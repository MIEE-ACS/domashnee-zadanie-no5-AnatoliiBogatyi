namespace Homework5
{
    partial class EmployersForm
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
            this.ItemsLV = new System.Windows.Forms.ListView();
            this.ItemsPG = new System.Windows.Forms.PropertyGrid();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.InfoLabel4 = new System.Windows.Forms.Label();
            this.InfoLabel5 = new System.Windows.Forms.Label();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.Prop1CB = new System.Windows.Forms.TextBox();
            this.Prop3CB = new System.Windows.Forms.TextBox();
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.Prop2CB = new System.Windows.Forms.TextBox();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.ChangeEmployeeButton = new System.Windows.Forms.Button();
            this.MoreInfoButton = new System.Windows.Forms.Button();
            this.Prop4CB = new System.Windows.Forms.TextBox();
            this.Prop5CB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ItemsLV
            // 
            this.ItemsLV.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ItemsLV.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemsLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLV.HideSelection = false;
            this.ItemsLV.Location = new System.Drawing.Point(0, 0);
            this.ItemsLV.Name = "ItemsLV";
            this.ItemsLV.Size = new System.Drawing.Size(358, 641);
            this.ItemsLV.TabIndex = 0;
            this.ItemsLV.UseCompatibleStateImageBehavior = false;
            this.ItemsLV.View = System.Windows.Forms.View.List;
            // 
            // ItemsPG
            // 
            this.ItemsPG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemsPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsPG.Location = new System.Drawing.Point(358, 319);
            this.ItemsPG.Name = "ItemsPG";
            this.ItemsPG.Size = new System.Drawing.Size(610, 322);
            this.ItemsPG.TabIndex = 1;
            this.ItemsPG.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ItemsPG_PropertyValueChanged);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployeeButton.Location = new System.Drawing.Point(809, 9);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(145, 70);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Добавить организацию:";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // InfoLabel4
            // 
            this.InfoLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel4.AutoSize = true;
            this.InfoLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel4.Location = new System.Drawing.Point(364, 146);
            this.InfoLabel4.Name = "InfoLabel4";
            this.InfoLabel4.Size = new System.Drawing.Size(191, 33);
            this.InfoLabel4.TabIndex = 4;
            this.InfoLabel4.Text = "Номер дома:";
            // 
            // InfoLabel5
            // 
            this.InfoLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel5.AutoSize = true;
            this.InfoLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel5.Location = new System.Drawing.Point(364, 188);
            this.InfoLabel5.Name = "InfoLabel5";
            this.InfoLabel5.Size = new System.Drawing.Size(123, 33);
            this.InfoLabel5.TabIndex = 6;
            this.InfoLabel5.Text = "Индекс:";
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel1.Location = new System.Drawing.Point(364, 14);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(121, 33);
            this.InfoLabel1.TabIndex = 7;
            this.InfoLabel1.Text = "Страна:";
            // 
            // Prop1CB
            // 
            this.Prop1CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Prop1CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prop1CB.Location = new System.Drawing.Point(556, 12);
            this.Prop1CB.Name = "Prop1CB";
            this.Prop1CB.Size = new System.Drawing.Size(234, 38);
            this.Prop1CB.TabIndex = 8;
            this.Prop1CB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prop3CB
            // 
            this.Prop3CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Prop3CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prop3CB.Location = new System.Drawing.Point(556, 100);
            this.Prop3CB.Name = "Prop3CB";
            this.Prop3CB.Size = new System.Drawing.Size(234, 38);
            this.Prop3CB.TabIndex = 10;
            this.Prop3CB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel3.Location = new System.Drawing.Point(364, 99);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(104, 33);
            this.InfoLabel3.TabIndex = 9;
            this.InfoLabel3.Text = "Город:";
            // 
            // Prop2CB
            // 
            this.Prop2CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Prop2CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prop2CB.Location = new System.Drawing.Point(556, 56);
            this.Prop2CB.Name = "Prop2CB";
            this.Prop2CB.Size = new System.Drawing.Size(234, 38);
            this.Prop2CB.TabIndex = 12;
            this.Prop2CB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel2.Location = new System.Drawing.Point(364, 58);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(139, 33);
            this.InfoLabel2.TabIndex = 11;
            this.InfoLabel2.Text = "Область:";
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(809, 84);
            this.DeleteEmployeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(145, 70);
            this.DeleteEmployeeButton.TabIndex = 13;
            this.DeleteEmployeeButton.Text = "Убрать организацию";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // ChangeEmployeeButton
            // 
            this.ChangeEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeEmployeeButton.Location = new System.Drawing.Point(809, 159);
            this.ChangeEmployeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ChangeEmployeeButton.Name = "ChangeEmployeeButton";
            this.ChangeEmployeeButton.Size = new System.Drawing.Size(145, 70);
            this.ChangeEmployeeButton.TabIndex = 14;
            this.ChangeEmployeeButton.Text = "Изменить организацию";
            this.ChangeEmployeeButton.UseVisualStyleBackColor = true;
            this.ChangeEmployeeButton.Click += new System.EventHandler(this.ChangeItemButton_Click);
            // 
            // MoreInfoButton
            // 
            this.MoreInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreInfoButton.Location = new System.Drawing.Point(361, 241);
            this.MoreInfoButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.MoreInfoButton.Name = "MoreInfoButton";
            this.MoreInfoButton.Size = new System.Drawing.Size(593, 70);
            this.MoreInfoButton.TabIndex = 15;
            this.MoreInfoButton.Text = "Показать подробную информацию";
            this.MoreInfoButton.UseVisualStyleBackColor = true;
            this.MoreInfoButton.Click += new System.EventHandler(this.MoreInfoButton_Click);
            // 
            // Prop4CB
            // 
            this.Prop4CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Prop4CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prop4CB.Location = new System.Drawing.Point(556, 144);
            this.Prop4CB.Name = "Prop4CB";
            this.Prop4CB.Size = new System.Drawing.Size(234, 38);
            this.Prop4CB.TabIndex = 16;
            this.Prop4CB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prop5CB
            // 
            this.Prop5CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Prop5CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prop5CB.Location = new System.Drawing.Point(556, 188);
            this.Prop5CB.Name = "Prop5CB";
            this.Prop5CB.Size = new System.Drawing.Size(234, 38);
            this.Prop5CB.TabIndex = 17;
            this.Prop5CB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmployersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 641);
            this.Controls.Add(this.Prop5CB);
            this.Controls.Add(this.Prop4CB);
            this.Controls.Add(this.MoreInfoButton);
            this.Controls.Add(this.ChangeEmployeeButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.Prop2CB);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.Prop3CB);
            this.Controls.Add(this.InfoLabel3);
            this.Controls.Add(this.Prop1CB);
            this.Controls.Add(this.InfoLabel1);
            this.Controls.Add(this.InfoLabel5);
            this.Controls.Add(this.InfoLabel4);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.ItemsPG);
            this.Controls.Add(this.ItemsLV);
            this.Name = "EmployersForm";
            this.ShowIcon = false;
            this.Text = "ДЗ №5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ItemsLV;
        private System.Windows.Forms.PropertyGrid ItemsPG;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Label InfoLabel4;
        private System.Windows.Forms.Label InfoLabel5;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.TextBox Prop1CB;
        private System.Windows.Forms.TextBox Prop3CB;
        private System.Windows.Forms.Label InfoLabel3;
        private System.Windows.Forms.TextBox Prop2CB;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button ChangeEmployeeButton;
        private System.Windows.Forms.Button MoreInfoButton;
        private System.Windows.Forms.TextBox Prop4CB;
        private System.Windows.Forms.TextBox Prop5CB;
    }
}

