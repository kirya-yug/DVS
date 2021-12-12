
namespace DVSK
{
    partial class WatchCalendar
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
            this.dVSDataSet19 = new DVSK.DVSDataSet19();
            this.exitCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVSDataSet20 = new DVSK.DVSDataSet20();
            this.calendarTableAdapter = new DVSK.DVSDataSet20TableAdapters.CalendarTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dVSDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitCalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVSDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // dVSDataSet19
            // 
            this.dVSDataSet19.DataSetName = "DVSDataSet19";
            this.dVSDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exitCalendarBindingSource
            // 
            this.exitCalendarBindingSource.DataMember = "Exit.Calendar";
            this.exitCalendarBindingSource.DataSource = this.dVSDataSet19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataMember = "Calendar";
            this.calendarBindingSource.DataSource = this.dVSDataSet20;
            // 
            // dVSDataSet20
            // 
            this.dVSDataSet20.DataSetName = "DVSDataSet20";
            this.dVSDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarTableAdapter
            // 
            this.calendarTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Отметить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // WatchCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "WatchCalendar";
            this.Text = "WatchCalendar";
            this.Load += new System.EventHandler(this.WatchCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVSDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitCalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVSDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource exitCalendarBindingSource;
        private DVSDataSet19 dVSDataSet19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DVSDataSet20 dVSDataSet20;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private DVSDataSet20TableAdapters.CalendarTableAdapter calendarTableAdapter;
        private System.Windows.Forms.Button button4;
    }
}