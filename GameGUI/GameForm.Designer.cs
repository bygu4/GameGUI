namespace GameGUI
{
    partial class GameForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            UpButton = new Button();
            DownButton = new Button();
            LeftButton = new Button();
            RIghtButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(LeftButton, 0, 0);
            tableLayoutPanel1.Controls.Add(RIghtButton, 2, 0);
            tableLayoutPanel1.Location = new Point(497, 275);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(243, 137);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(UpButton, 0, 0);
            tableLayoutPanel2.Controls.Add(DownButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(72, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(97, 137);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // UpButton
            // 
            UpButton.Dock = DockStyle.Fill;
            UpButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpButton.Location = new Point(3, 3);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(91, 62);
            UpButton.TabIndex = 0;
            UpButton.Text = "^";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Dock = DockStyle.Fill;
            DownButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DownButton.Location = new Point(3, 71);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(91, 63);
            DownButton.TabIndex = 1;
            DownButton.Text = "v";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Dock = DockStyle.Fill;
            LeftButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LeftButton.Location = new Point(3, 3);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(66, 131);
            LeftButton.TabIndex = 1;
            LeftButton.Text = "<";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RIghtButton
            // 
            RIghtButton.Dock = DockStyle.Fill;
            RIghtButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RIghtButton.Location = new Point(172, 3);
            RIghtButton.Name = "RIghtButton";
            RIghtButton.Size = new Size(68, 131);
            RIghtButton.TabIndex = 2;
            RIghtButton.Text = ">";
            RIghtButton.UseVisualStyleBackColor = true;
            RIghtButton.Click += RIghtButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 459);
            Controls.Add(tableLayoutPanel1);
            Name = "GameForm";
            Text = "Game";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button UpButton;
        private Button DownButton;
        private Button LeftButton;
        private Button RIghtButton;
    }
}
