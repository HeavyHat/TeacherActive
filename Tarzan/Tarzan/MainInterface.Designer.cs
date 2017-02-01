namespace Tarzan
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.candidatesPage = new System.Windows.Forms.TabPage();
            this.schoolsPage = new System.Windows.Forms.TabPage();
            this.mainTableLayout.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.mainTabSelector, 0, 0);
            this.mainTableLayout.Controls.Add(this.mainTabControl, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 64);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(800, 536);
            this.mainTableLayout.TabIndex = 0;
            // 
            // mainTabSelector
            // 
            this.mainTabSelector.BaseTabControl = this.mainTabControl;
            this.mainTabSelector.Depth = 0;
            this.mainTabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabSelector.Location = new System.Drawing.Point(0, 0);
            this.mainTabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabSelector.Name = "mainTabSelector";
            this.mainTabSelector.Size = new System.Drawing.Size(800, 50);
            this.mainTabSelector.TabIndex = 0;
            this.mainTabSelector.Text = "materialTabSelector1";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.candidatesPage);
            this.mainTabControl.Controls.Add(this.schoolsPage);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 50);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 486);
            this.mainTabControl.TabIndex = 1;
            // 
            // candidatesPage
            // 
            this.candidatesPage.Location = new System.Drawing.Point(4, 25);
            this.candidatesPage.Name = "candidatesPage";
            this.candidatesPage.Padding = new System.Windows.Forms.Padding(3);
            this.candidatesPage.Size = new System.Drawing.Size(792, 457);
            this.candidatesPage.TabIndex = 0;
            this.candidatesPage.Text = "Candidates";
            this.candidatesPage.UseVisualStyleBackColor = true;
            // 
            // schoolsPage
            // 
            this.schoolsPage.Location = new System.Drawing.Point(4, 25);
            this.schoolsPage.Name = "schoolsPage";
            this.schoolsPage.Padding = new System.Windows.Forms.Padding(3);
            this.schoolsPage.Size = new System.Drawing.Size(792, 457);
            this.schoolsPage.TabIndex = 1;
            this.schoolsPage.Text = "Schools";
            this.schoolsPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainTableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Text = "Teacher Active";
            this.mainTableLayout.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private MaterialSkin.Controls.MaterialTabSelector mainTabSelector;
        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage candidatesPage;
        private System.Windows.Forms.TabPage schoolsPage;
    }
}

