namespace Inventory_Manager
{
    partial class Таблица_производителей
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnProducer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица производителей";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(67, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 41);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Меню >>>";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProducer_name,
            this.ColumnProducer_ID});
            this.dataGridView1.Location = new System.Drawing.Point(67, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(605, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnProducer_name
            // 
            this.ColumnProducer_name.HeaderText = "Имя производителя";
            this.ColumnProducer_name.MinimumWidth = 12;
            this.ColumnProducer_name.Name = "ColumnProducer_name";
            this.ColumnProducer_name.ReadOnly = true;
            this.ColumnProducer_name.Width = 250;
            // 
            // ColumnProducer_ID
            // 
            this.ColumnProducer_ID.HeaderText = "ID производителя";
            this.ColumnProducer_ID.MinimumWidth = 12;
            this.ColumnProducer_ID.Name = "ColumnProducer_ID";
            this.ColumnProducer_ID.ReadOnly = true;
            this.ColumnProducer_ID.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(605, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Таблица_производителей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(771, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Таблица_производителей";
            this.Text = "Таблица_производителей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnProducer_name;
        private DataGridViewTextBoxColumn ColumnProducer_ID;
        private Button button1;
        private NotifyIcon notifyIcon1;
    }
}