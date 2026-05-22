namespace Banking
{
    partial class Analytics
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
            chart1 = new FastReport.DataVisualization.Charting.Chart();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnSearch = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Location = new Point(14, 12);
            chart1.Name = "chart1";
            chart1.Size = new Size(422, 375);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(506, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(506, 91);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(281, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Lato Black", 10.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(561, 169);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 47);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Lato Black", 10.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(727, 340);
            button1.Name = "button1";
            button1.Size = new Size(161, 47);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(chart1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "Analytics";
            Text = "Analytics";
            Load += Analytics_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FastReport.DataVisualization.Charting.Chart chart1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnSearch;
        private Button button1;
    }
}