namespace ComputerGraphicAlgorithm
{
    partial class frmConvas
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
            this.Container = new System.Windows.Forms.SplitContainer();
            this.gpCircleDrawing = new System.Windows.Forms.GroupBox();
            this.btnRandomCircle = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.lblRadiusValue = new System.Windows.Forms.Label();
            this.trackRaduis = new System.Windows.Forms.TrackBar();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblYcValue = new System.Windows.Forms.Label();
            this.lblXcValue = new System.Windows.Forms.Label();
            this.trackYc = new System.Windows.Forms.TrackBar();
            this.lblYc = new System.Windows.Forms.Label();
            this.trackXc = new System.Windows.Forms.TrackBar();
            this.lblXc = new System.Windows.Forms.Label();
            this.gpLineDrawing = new System.Windows.Forms.GroupBox();
            this.btnRandomLine = new System.Windows.Forms.Button();
            this.btnDDA = new System.Windows.Forms.Button();
            this.btnBersenham = new System.Windows.Forms.Button();
            this.lblY2Value = new System.Windows.Forms.Label();
            this.lblX2Value = new System.Windows.Forms.Label();
            this.lblY1Value = new System.Windows.Forms.Label();
            this.lblX1Value = new System.Windows.Forms.Label();
            this.trackY2 = new System.Windows.Forms.TrackBar();
            this.lblY2 = new System.Windows.Forms.Label();
            this.trackX2 = new System.Windows.Forms.TrackBar();
            this.lblX2 = new System.Windows.Forms.Label();
            this.trackY1 = new System.Windows.Forms.TrackBar();
            this.lblY1 = new System.Windows.Forms.Label();
            this.trackX1 = new System.Windows.Forms.TrackBar();
            this.lblX1 = new System.Windows.Forms.Label();
            this.Convas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            this.Container.Panel1.SuspendLayout();
            this.Container.Panel2.SuspendLayout();
            this.Container.SuspendLayout();
            this.gpCircleDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRaduis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackYc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackXc)).BeginInit();
            this.gpLineDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Convas)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.Container.ForeColor = System.Drawing.Color.White;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Container.Panel1
            // 
            this.Container.Panel1.BackColor = System.Drawing.Color.Purple;
            this.Container.Panel1.Controls.Add(this.gpCircleDrawing);
            this.Container.Panel1.Controls.Add(this.gpLineDrawing);
            this.Container.Panel1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Container.Panel1.ForeColor = System.Drawing.Color.White;
            this.Container.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // Container.Panel2
            // 
            this.Container.Panel2.BackColor = System.Drawing.Color.White;
            this.Container.Panel2.Controls.Add(this.Convas);
            this.Container.Size = new System.Drawing.Size(984, 961);
            this.Container.SplitterDistance = 200;
            this.Container.SplitterWidth = 1;
            this.Container.TabIndex = 0;
            // 
            // gpCircleDrawing
            // 
            this.gpCircleDrawing.Controls.Add(this.btnRandomCircle);
            this.gpCircleDrawing.Controls.Add(this.btnDrawCircle);
            this.gpCircleDrawing.Controls.Add(this.lblRadiusValue);
            this.gpCircleDrawing.Controls.Add(this.trackRaduis);
            this.gpCircleDrawing.Controls.Add(this.lblRadius);
            this.gpCircleDrawing.Controls.Add(this.lblYcValue);
            this.gpCircleDrawing.Controls.Add(this.lblXcValue);
            this.gpCircleDrawing.Controls.Add(this.trackYc);
            this.gpCircleDrawing.Controls.Add(this.lblYc);
            this.gpCircleDrawing.Controls.Add(this.trackXc);
            this.gpCircleDrawing.Controls.Add(this.lblXc);
            this.gpCircleDrawing.ForeColor = System.Drawing.Color.White;
            this.gpCircleDrawing.Location = new System.Drawing.Point(12, 0);
            this.gpCircleDrawing.Name = "gpCircleDrawing";
            this.gpCircleDrawing.Size = new System.Drawing.Size(432, 197);
            this.gpCircleDrawing.TabIndex = 1;
            this.gpCircleDrawing.TabStop = false;
            this.gpCircleDrawing.Text = "رسم دایره";
            // 
            // btnRandomCircle
            // 
            this.btnRandomCircle.BackColor = System.Drawing.SystemColors.Control;
            this.btnRandomCircle.ForeColor = System.Drawing.Color.Black;
            this.btnRandomCircle.Location = new System.Drawing.Point(37, 128);
            this.btnRandomCircle.Name = "btnRandomCircle";
            this.btnRandomCircle.Size = new System.Drawing.Size(186, 40);
            this.btnRandomCircle.TabIndex = 18;
            this.btnRandomCircle.Text = "رسم تصادفی دایره";
            this.btnRandomCircle.UseVisualStyleBackColor = false;
            this.btnRandomCircle.Click += new System.EventHandler(this.btnRandomCircle_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.BackColor = System.Drawing.SystemColors.Control;
            this.btnDrawCircle.ForeColor = System.Drawing.Color.Black;
            this.btnDrawCircle.Location = new System.Drawing.Point(37, 85);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(186, 40);
            this.btnDrawCircle.TabIndex = 22;
            this.btnDrawCircle.Text = "رسم دایره";
            this.btnDrawCircle.UseVisualStyleBackColor = false;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // lblRadiusValue
            // 
            this.lblRadiusValue.AutoSize = true;
            this.lblRadiusValue.Location = new System.Drawing.Point(250, 162);
            this.lblRadiusValue.Name = "lblRadiusValue";
            this.lblRadiusValue.Size = new System.Drawing.Size(39, 28);
            this.lblRadiusValue.TabIndex = 21;
            this.lblRadiusValue.Text = "100";
            // 
            // trackRaduis
            // 
            this.trackRaduis.Location = new System.Drawing.Point(245, 61);
            this.trackRaduis.Maximum = 500;
            this.trackRaduis.Minimum = 1;
            this.trackRaduis.Name = "trackRaduis";
            this.trackRaduis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackRaduis.Size = new System.Drawing.Size(45, 107);
            this.trackRaduis.TabIndex = 20;
            this.trackRaduis.TickFrequency = 50;
            this.trackRaduis.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackRaduis.Value = 100;
            this.trackRaduis.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(246, 30);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(42, 28);
            this.lblRadius.TabIndex = 19;
            this.lblRadius.Text = "شعاع";
            // 
            // lblYcValue
            // 
            this.lblYcValue.AutoSize = true;
            this.lblYcValue.Location = new System.Drawing.Point(306, 162);
            this.lblYcValue.Name = "lblYcValue";
            this.lblYcValue.Size = new System.Drawing.Size(39, 28);
            this.lblYcValue.TabIndex = 18;
            this.lblYcValue.Text = "100";
            // 
            // lblXcValue
            // 
            this.lblXcValue.AutoSize = true;
            this.lblXcValue.Location = new System.Drawing.Point(370, 162);
            this.lblXcValue.Name = "lblXcValue";
            this.lblXcValue.Size = new System.Drawing.Size(39, 28);
            this.lblXcValue.TabIndex = 17;
            this.lblXcValue.Text = "100";
            // 
            // trackYc
            // 
            this.trackYc.Location = new System.Drawing.Point(303, 61);
            this.trackYc.Maximum = 984;
            this.trackYc.Minimum = 1;
            this.trackYc.Name = "trackYc";
            this.trackYc.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackYc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackYc.Size = new System.Drawing.Size(45, 107);
            this.trackYc.TabIndex = 16;
            this.trackYc.TickFrequency = 50;
            this.trackYc.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackYc.Value = 100;
            this.trackYc.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblYc
            // 
            this.lblYc.AutoSize = true;
            this.lblYc.Location = new System.Drawing.Point(309, 32);
            this.lblYc.Name = "lblYc";
            this.lblYc.Size = new System.Drawing.Size(34, 28);
            this.lblYc.TabIndex = 15;
            this.lblYc.Text = "Yc";
            // 
            // trackXc
            // 
            this.trackXc.Location = new System.Drawing.Point(365, 61);
            this.trackXc.Maximum = 760;
            this.trackXc.Minimum = 1;
            this.trackXc.Name = "trackXc";
            this.trackXc.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackXc.Size = new System.Drawing.Size(45, 107);
            this.trackXc.TabIndex = 14;
            this.trackXc.TickFrequency = 50;
            this.trackXc.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackXc.Value = 100;
            this.trackXc.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblXc
            // 
            this.lblXc.AutoSize = true;
            this.lblXc.Location = new System.Drawing.Point(371, 32);
            this.lblXc.Name = "lblXc";
            this.lblXc.Size = new System.Drawing.Size(36, 28);
            this.lblXc.TabIndex = 13;
            this.lblXc.Text = "Xc";
            // 
            // gpLineDrawing
            // 
            this.gpLineDrawing.Controls.Add(this.btnRandomLine);
            this.gpLineDrawing.Controls.Add(this.btnDDA);
            this.gpLineDrawing.Controls.Add(this.btnBersenham);
            this.gpLineDrawing.Controls.Add(this.lblY2Value);
            this.gpLineDrawing.Controls.Add(this.lblX2Value);
            this.gpLineDrawing.Controls.Add(this.lblY1Value);
            this.gpLineDrawing.Controls.Add(this.lblX1Value);
            this.gpLineDrawing.Controls.Add(this.trackY2);
            this.gpLineDrawing.Controls.Add(this.lblY2);
            this.gpLineDrawing.Controls.Add(this.trackX2);
            this.gpLineDrawing.Controls.Add(this.lblX2);
            this.gpLineDrawing.Controls.Add(this.trackY1);
            this.gpLineDrawing.Controls.Add(this.lblY1);
            this.gpLineDrawing.Controls.Add(this.trackX1);
            this.gpLineDrawing.Controls.Add(this.lblX1);
            this.gpLineDrawing.ForeColor = System.Drawing.Color.White;
            this.gpLineDrawing.Location = new System.Drawing.Point(476, 0);
            this.gpLineDrawing.Name = "gpLineDrawing";
            this.gpLineDrawing.Size = new System.Drawing.Size(497, 197);
            this.gpLineDrawing.TabIndex = 0;
            this.gpLineDrawing.TabStop = false;
            this.gpLineDrawing.Text = "رسم خط";
            // 
            // btnRandomLine
            // 
            this.btnRandomLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnRandomLine.ForeColor = System.Drawing.Color.Black;
            this.btnRandomLine.Location = new System.Drawing.Point(18, 143);
            this.btnRandomLine.Name = "btnRandomLine";
            this.btnRandomLine.Size = new System.Drawing.Size(181, 40);
            this.btnRandomLine.TabIndex = 17;
            this.btnRandomLine.Text = "رسم تصادفی خط";
            this.btnRandomLine.UseVisualStyleBackColor = false;
            this.btnRandomLine.Click += new System.EventHandler(this.btnRandomLine_Click);
            // 
            // btnDDA
            // 
            this.btnDDA.BackColor = System.Drawing.SystemColors.Control;
            this.btnDDA.ForeColor = System.Drawing.Color.Black;
            this.btnDDA.Location = new System.Drawing.Point(18, 102);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(181, 40);
            this.btnDDA.TabIndex = 16;
            this.btnDDA.Text = "رسم با الگوریتم دی دی ای";
            this.btnDDA.UseVisualStyleBackColor = false;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // btnBersenham
            // 
            this.btnBersenham.BackColor = System.Drawing.SystemColors.Control;
            this.btnBersenham.ForeColor = System.Drawing.Color.Black;
            this.btnBersenham.Location = new System.Drawing.Point(18, 61);
            this.btnBersenham.Name = "btnBersenham";
            this.btnBersenham.Size = new System.Drawing.Size(181, 40);
            this.btnBersenham.TabIndex = 15;
            this.btnBersenham.Text = "رسم با الگوریتم برزنهام";
            this.btnBersenham.UseVisualStyleBackColor = false;
            this.btnBersenham.Click += new System.EventHandler(this.btnBersenham_Click);
            // 
            // lblY2Value
            // 
            this.lblY2Value.AutoSize = true;
            this.lblY2Value.Location = new System.Drawing.Point(227, 162);
            this.lblY2Value.Name = "lblY2Value";
            this.lblY2Value.Size = new System.Drawing.Size(39, 28);
            this.lblY2Value.TabIndex = 14;
            this.lblY2Value.Text = "300";
            // 
            // lblX2Value
            // 
            this.lblX2Value.AutoSize = true;
            this.lblX2Value.Location = new System.Drawing.Point(293, 162);
            this.lblX2Value.Name = "lblX2Value";
            this.lblX2Value.Size = new System.Drawing.Size(38, 28);
            this.lblX2Value.TabIndex = 13;
            this.lblX2Value.Text = "600";
            // 
            // lblY1Value
            // 
            this.lblY1Value.AutoSize = true;
            this.lblY1Value.Location = new System.Drawing.Point(362, 162);
            this.lblY1Value.Name = "lblY1Value";
            this.lblY1Value.Size = new System.Drawing.Size(39, 28);
            this.lblY1Value.TabIndex = 12;
            this.lblY1Value.Text = "100";
            // 
            // lblX1Value
            // 
            this.lblX1Value.AutoSize = true;
            this.lblX1Value.Location = new System.Drawing.Point(426, 162);
            this.lblX1Value.Name = "lblX1Value";
            this.lblX1Value.Size = new System.Drawing.Size(39, 28);
            this.lblX1Value.TabIndex = 11;
            this.lblX1Value.Text = "100";
            // 
            // trackY2
            // 
            this.trackY2.Location = new System.Drawing.Point(226, 61);
            this.trackY2.Maximum = 984;
            this.trackY2.Minimum = 1;
            this.trackY2.Name = "trackY2";
            this.trackY2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackY2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackY2.Size = new System.Drawing.Size(45, 107);
            this.trackY2.TabIndex = 10;
            this.trackY2.TickFrequency = 50;
            this.trackY2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackY2.Value = 300;
            this.trackY2.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(222, 30);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(52, 28);
            this.lblY2.TabIndex = 9;
            this.lblY2.Text = "پایان y";
            // 
            // trackX2
            // 
            this.trackX2.Location = new System.Drawing.Point(291, 61);
            this.trackX2.Maximum = 760;
            this.trackX2.Minimum = 1;
            this.trackX2.Name = "trackX2";
            this.trackX2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackX2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackX2.Size = new System.Drawing.Size(45, 107);
            this.trackX2.TabIndex = 8;
            this.trackX2.TickFrequency = 50;
            this.trackX2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackX2.Value = 600;
            this.trackX2.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(287, 30);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(53, 28);
            this.lblX2.TabIndex = 7;
            this.lblX2.Text = "پایان x";
            // 
            // trackY1
            // 
            this.trackY1.Location = new System.Drawing.Point(359, 61);
            this.trackY1.Maximum = 984;
            this.trackY1.Minimum = 1;
            this.trackY1.Name = "trackY1";
            this.trackY1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackY1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackY1.Size = new System.Drawing.Size(45, 107);
            this.trackY1.TabIndex = 6;
            this.trackY1.TickFrequency = 50;
            this.trackY1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackY1.Value = 100;
            this.trackY1.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(352, 30);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(58, 28);
            this.lblY1.TabIndex = 5;
            this.lblY1.Text = "شروع y";
            // 
            // trackX1
            // 
            this.trackX1.Location = new System.Drawing.Point(421, 61);
            this.trackX1.Maximum = 760;
            this.trackX1.Minimum = 1;
            this.trackX1.Name = "trackX1";
            this.trackX1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackX1.Size = new System.Drawing.Size(45, 107);
            this.trackX1.TabIndex = 4;
            this.trackX1.TickFrequency = 50;
            this.trackX1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackX1.Value = 100;
            this.trackX1.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(412, 30);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(59, 28);
            this.lblX1.TabIndex = 0;
            this.lblX1.Text = "شروع x";
            // 
            // Convas
            // 
            this.Convas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Convas.Location = new System.Drawing.Point(0, 0);
            this.Convas.Name = "Convas";
            this.Convas.Size = new System.Drawing.Size(984, 760);
            this.Convas.TabIndex = 0;
            this.Convas.TabStop = false;
            // 
            // frmConvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.Container);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConvas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Computer Graphic Algorithms - Rasoul Nazari Yekta";
            this.Container.Panel1.ResumeLayout(false);
            this.Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
            this.Container.ResumeLayout(false);
            this.gpCircleDrawing.ResumeLayout(false);
            this.gpCircleDrawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRaduis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackYc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackXc)).EndInit();
            this.gpLineDrawing.ResumeLayout(false);
            this.gpLineDrawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Convas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Container;
        private System.Windows.Forms.GroupBox gpCircleDrawing;
        private System.Windows.Forms.GroupBox gpLineDrawing;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TrackBar trackY2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.TrackBar trackX2;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TrackBar trackY1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.TrackBar trackX1;
        private System.Windows.Forms.Label lblY2Value;
        private System.Windows.Forms.Label lblX2Value;
        private System.Windows.Forms.Label lblY1Value;
        private System.Windows.Forms.Label lblX1Value;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Button btnBersenham;
        private System.Windows.Forms.Label lblRadiusValue;
        private System.Windows.Forms.TrackBar trackRaduis;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblYcValue;
        private System.Windows.Forms.Label lblXcValue;
        private System.Windows.Forms.TrackBar trackYc;
        private System.Windows.Forms.Label lblYc;
        private System.Windows.Forms.TrackBar trackXc;
        private System.Windows.Forms.Label lblXc;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button btnRandomCircle;
        private System.Windows.Forms.Button btnRandomLine;
        private System.Windows.Forms.PictureBox Convas;
    }
}

