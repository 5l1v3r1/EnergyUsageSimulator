namespace EnergyUsageSimulator
{
    partial class NodeForm
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
            this.verticalSeperator1 = new EnergyUsageSimulator.Controls.VerticalSeperator();
            this.SuspendLayout();
            // 
            // verticalSeperator1
            // 
            this.verticalSeperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalSeperator1.Location = new System.Drawing.Point(383, 22);
            this.verticalSeperator1.MaximumSize = new System.Drawing.Size(2, 2147483647);
            this.verticalSeperator1.MinimumSize = new System.Drawing.Size(2, 1);
            this.verticalSeperator1.Name = "verticalSeperator1";
            this.verticalSeperator1.Size = new System.Drawing.Size(2, 390);
            this.verticalSeperator1.TabIndex = 1;
            // 
            // NodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 438);
            this.Controls.Add(this.verticalSeperator1);
            this.Name = "NodeForm";
            this.Text = "NodeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.VerticalSeperator verticalSeperator1;

    }
}