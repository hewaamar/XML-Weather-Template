
namespace XMLWeather
{
    partial class SearchScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchInput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(26, 70);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(260, 26);
            this.searchInput.TabIndex = 1;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchInput);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(373, 612);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox searchInput;
    }
}
