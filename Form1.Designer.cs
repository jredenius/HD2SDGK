namespace HD2SDGK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            lbEvents = new Label();
            lbSDinfo = new Label();
            lbConfig = new Label();
            lbStratimages = new Label();
            lbStratcombos = new Label();
            lbWebInterface = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Logtb = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lbEvents);
            groupBox1.Controls.Add(lbSDinfo);
            groupBox1.Controls.Add(lbConfig);
            groupBox1.Controls.Add(lbStratimages);
            groupBox1.Controls.Add(lbStratcombos);
            groupBox1.Controls.Add(lbWebInterface);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // lbEvents
            // 
            lbEvents.AutoSize = true;
            lbEvents.Location = new Point(156, 126);
            lbEvents.Name = "lbEvents";
            lbEvents.Size = new Size(58, 20);
            lbEvents.TabIndex = 11;
            lbEvents.Text = "Adding";
            // 
            // lbSDinfo
            // 
            lbSDinfo.AutoSize = true;
            lbSDinfo.Location = new Point(156, 106);
            lbSDinfo.Name = "lbSDinfo";
            lbSDinfo.Size = new Size(66, 20);
            lbSDinfo.TabIndex = 10;
            lbSDinfo.Text = "Locating";
            // 
            // lbConfig
            // 
            lbConfig.AutoSize = true;
            lbConfig.Location = new Point(156, 86);
            lbConfig.Name = "lbConfig";
            lbConfig.Size = new Size(64, 20);
            lbConfig.TabIndex = 9;
            lbConfig.Text = "Working";
            // 
            // lbStratimages
            // 
            lbStratimages.AutoSize = true;
            lbStratimages.Location = new Point(156, 66);
            lbStratimages.Name = "lbStratimages";
            lbStratimages.Size = new Size(63, 20);
            lbStratimages.TabIndex = 8;
            lbStratimages.Text = "Loading";
            // 
            // lbStratcombos
            // 
            lbStratcombos.AutoSize = true;
            lbStratcombos.Location = new Point(156, 46);
            lbStratcombos.Name = "lbStratcombos";
            lbStratcombos.Size = new Size(63, 20);
            lbStratcombos.TabIndex = 7;
            lbStratcombos.Text = "Loading";
            // 
            // lbWebInterface
            // 
            lbWebInterface.AutoSize = true;
            lbWebInterface.Location = new Point(156, 26);
            lbWebInterface.Name = "lbWebInterface";
            lbWebInterface.Size = new Size(63, 20);
            lbWebInterface.TabIndex = 6;
            lbWebInterface.Text = "Loading";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 126);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 5;
            label6.Text = "Commands.......................";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 106);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 4;
            label5.Text = "Stream Deck Info..........";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 3;
            label4.Text = "Configuration..................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 2;
            label3.Text = "Stratagem Images........";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 1;
            label2.Text = "Web Interface..................";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Stratagem Combos......";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(Logtb);
            groupBox2.Location = new Point(260, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log";
            // 
            // Logtb
            // 
            Logtb.Dock = DockStyle.Fill;
            Logtb.Location = new Point(3, 23);
            Logtb.Multiline = true;
            Logtb.Name = "Logtb";
            Logtb.ReadOnly = true;
            Logtb.ScrollBars = ScrollBars.Vertical;
            Logtb.Size = new Size(293, 132);
            Logtb.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 182);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "HD2SDGK";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox Logtb;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lbStratimages;
        private Label lbStratcombos;
        private Label lbWebInterface;
        private Label label6;
        private Label lbEvents;
        private Label lbSDinfo;
        private Label lbConfig;
    }
}