namespace AbbieGillespieA6
{
    partial class MainForm
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
            ChooseFileBtn = new Button();
            ExportDataAsCSVBtn = new Button();
            ExportDataAsJSONBtn = new Button();
            ObjectCountTxtBox = new TextBox();
            SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            ChooseFileBtn.Location = new Point(12, 12);
            ChooseFileBtn.Name = "ChooseFileBtn";
            ChooseFileBtn.Size = new Size(112, 34);
            ChooseFileBtn.TabIndex = 0;
            ChooseFileBtn.Text = "Choose File";
            ChooseFileBtn.UseVisualStyleBackColor = true;
            ChooseFileBtn.Click += ChooseFileBtn_Click;
            // 
            // ExportDataAsCSVBtn
            // 
            ExportDataAsCSVBtn.Location = new Point(157, 12);
            ExportDataAsCSVBtn.Name = "ExportDataAsCSVBtn";
            ExportDataAsCSVBtn.Size = new Size(187, 34);
            ExportDataAsCSVBtn.TabIndex = 1;
            ExportDataAsCSVBtn.Text = "Export Data as CSV";
            ExportDataAsCSVBtn.UseVisualStyleBackColor = true;
            // 
            // ExportDataAsJSONBtn
            // 
            ExportDataAsJSONBtn.Location = new Point(157, 52);
            ExportDataAsJSONBtn.Name = "ExportDataAsJSONBtn";
            ExportDataAsJSONBtn.Size = new Size(187, 34);
            ExportDataAsJSONBtn.TabIndex = 2;
            ExportDataAsJSONBtn.Text = "Export Data as JSON";
            ExportDataAsJSONBtn.UseVisualStyleBackColor = true;
            // 
            // ObjectCountTxtBox
            // 
            ObjectCountTxtBox.Location = new Point(12, 127);
            ObjectCountTxtBox.Multiline = true;
            ObjectCountTxtBox.Name = "ObjectCountTxtBox";
            ObjectCountTxtBox.ReadOnly = true;
            ObjectCountTxtBox.Size = new Size(228, 221);
            ObjectCountTxtBox.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ObjectCountTxtBox);
            Controls.Add(ExportDataAsJSONBtn);
            Controls.Add(ExportDataAsCSVBtn);
            Controls.Add(ChooseFileBtn);
            Name = "MainForm";
            Text = "Abbie Gillespie Assignment 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChooseFileBtn;
        private Button ExportDataAsCSVBtn;
        private Button ExportDataAsJSONBtn;
        private TextBox ObjectCountTxtBox;
    }
}
