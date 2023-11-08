namespace SqlViewer.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            twServer = new TreeView();
            toolStrip1 = new ToolStrip();
            tsbSelect = new ToolStripButton();
            tsbXML = new ToolStripButton();
            tsbExecute = new ToolStripButton();
            tbContent = new TextBox();
            lblError = new Label();
            tbResults = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // twServer
            // 
            twServer.Location = new Point(22, 73);
            twServer.Margin = new Padding(1);
            twServer.Name = "twServer";
            twServer.Size = new Size(396, 823);
            twServer.TabIndex = 0;
            twServer.AfterCollapse += TwServer_AfterCollapse;
            twServer.BeforeExpand += TwServer_BeforeExpand;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbSelect, tsbXML, tsbExecute });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(1114, 47);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelect
            // 
            tsbSelect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSelect.Image = (Image)resources.GetObject("tsbSelect.Image");
            tsbSelect.ImageTransparentColor = Color.Magenta;
            tsbSelect.Name = "tsbSelect";
            tsbSelect.Size = new Size(44, 44);
            tsbSelect.Text = "Select";
            tsbSelect.Click += TsbSelect_Click;
            // 
            // tsbXML
            // 
            tsbXML.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbXML.Image = (Image)resources.GetObject("tsbXML.Image");
            tsbXML.ImageTransparentColor = Color.Magenta;
            tsbXML.Name = "tsbXML";
            tsbXML.Size = new Size(44, 44);
            tsbXML.Text = "XML";
            tsbXML.Click += TsbXML_Click;
            // 
            // tsbExecute
            // 
            tsbExecute.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbExecute.Image = (Image)resources.GetObject("tsbExecute.Image");
            tsbExecute.ImageTransparentColor = Color.Magenta;
            tsbExecute.Name = "tsbExecute";
            tsbExecute.Size = new Size(44, 44);
            tsbExecute.Text = "tsbExecute";
            tsbExecute.Click += TsbExecute_Click;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(444, 104);
            tbContent.Margin = new Padding(1);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(660, 344);
            tbContent.TabIndex = 2;
            tbContent.KeyDown += tbContent_KeyDown;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(453, 674);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 31);
            lblError.TabIndex = 3;
            // 
            // tbResults
            // 
            tbResults.Location = new Point(444, 480);
            tbResults.Margin = new Padding(1);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.ScrollBars = ScrollBars.Both;
            tbResults.Size = new Size(660, 344);
            tbResults.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 928);
            Controls.Add(tbResults);
            Controls.Add(lblError);
            Controls.Add(tbContent);
            Controls.Add(toolStrip1);
            Controls.Add(twServer);
            Margin = new Padding(1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSMS";
            FormClosed += MainForm_FormClosed;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView twServer;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbSelect;
        private ToolStripButton tsbXML;
        private TextBox tbContent;
        private ToolStripButton tsbExecute;
        private Label lblError;
        private TextBox tbResults;
    }
}