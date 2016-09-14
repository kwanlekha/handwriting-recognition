namespace SimplePaint
{
    partial class Form1
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelToDraw = new System.Windows.Forms.Panel();
            this.groupBoxToDraw = new System.Windows.Forms.GroupBox();
            this.labelNumberToDraw = new System.Windows.Forms.Label();
            this.labelShowMessage = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.groupBoxShowData = new System.Windows.Forms.GroupBox();
            this.richTextBoxShowData = new System.Windows.Forms.RichTextBox();
            this.groupBoxToDraw.SuspendLayout();
            this.groupBoxShowData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(56, 438);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 39);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(14, 396);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 29);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelToDraw
            // 
            this.panelToDraw.BackColor = System.Drawing.Color.White;
            this.panelToDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelToDraw.Location = new System.Drawing.Point(14, 55);
            this.panelToDraw.Name = "panelToDraw";
            this.panelToDraw.Size = new System.Drawing.Size(160, 320);
            this.panelToDraw.TabIndex = 2;
            this.panelToDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToDraw_MouseDown);
            this.panelToDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelToDraw_MouseMove);
            this.panelToDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelToDraw_MouseUp);
            // 
            // groupBoxToDraw
            // 
            this.groupBoxToDraw.Controls.Add(this.labelNumberToDraw);
            this.groupBoxToDraw.Controls.Add(this.labelShowMessage);
            this.groupBoxToDraw.Controls.Add(this.labelDraw);
            this.groupBoxToDraw.Controls.Add(this.panelToDraw);
            this.groupBoxToDraw.Controls.Add(this.buttonSave);
            this.groupBoxToDraw.Controls.Add(this.buttonGetData);
            this.groupBoxToDraw.Controls.Add(this.buttonClear);
            this.groupBoxToDraw.Location = new System.Drawing.Point(12, 12);
            this.groupBoxToDraw.Name = "groupBoxToDraw";
            this.groupBoxToDraw.Size = new System.Drawing.Size(190, 526);
            this.groupBoxToDraw.TabIndex = 3;
            this.groupBoxToDraw.TabStop = false;
            this.groupBoxToDraw.Text = "Draw Character";
            // 
            // labelNumberToDraw
            // 
            this.labelNumberToDraw.AutoSize = true;
            this.labelNumberToDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelNumberToDraw.Location = new System.Drawing.Point(106, 25);
            this.labelNumberToDraw.Name = "labelNumberToDraw";
            this.labelNumberToDraw.Size = new System.Drawing.Size(18, 20);
            this.labelNumberToDraw.TabIndex = 8;
            this.labelNumberToDraw.Text = "0";
            // 
            // labelShowMessage
            // 
            this.labelShowMessage.AutoSize = true;
            this.labelShowMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelShowMessage.Location = new System.Drawing.Point(6, 492);
            this.labelShowMessage.Name = "labelShowMessage";
            this.labelShowMessage.Size = new System.Drawing.Size(45, 16);
            this.labelShowMessage.TabIndex = 7;
            this.labelShowMessage.Text = "label2";
            this.labelShowMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelDraw.Location = new System.Drawing.Point(63, 27);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(45, 15);
            this.labelDraw.TabIndex = 6;
            this.labelDraw.Text = "Draw : ";
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(99, 396);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(75, 29);
            this.buttonGetData.TabIndex = 4;
            this.buttonGetData.Text = "GetData";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // groupBoxShowData
            // 
            this.groupBoxShowData.Controls.Add(this.richTextBoxShowData);
            this.groupBoxShowData.Location = new System.Drawing.Point(208, 12);
            this.groupBoxShowData.Name = "groupBoxShowData";
            this.groupBoxShowData.Size = new System.Drawing.Size(801, 526);
            this.groupBoxShowData.TabIndex = 5;
            this.groupBoxShowData.TabStop = false;
            this.groupBoxShowData.Text = "Show Data";
            // 
            // richTextBoxShowData
            // 
            this.richTextBoxShowData.Font = new System.Drawing.Font("Courier New", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxShowData.Location = new System.Drawing.Point(16, 22);
            this.richTextBoxShowData.Name = "richTextBoxShowData";
            this.richTextBoxShowData.ReadOnly = true;
            this.richTextBoxShowData.Size = new System.Drawing.Size(769, 486);
            this.richTextBoxShowData.TabIndex = 5;
            this.richTextBoxShowData.Text = "";
            this.richTextBoxShowData.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 550);
            this.Controls.Add(this.groupBoxShowData);
            this.Controls.Add(this.groupBoxToDraw);
            this.Name = "Form1";
            this.Text = "Handwriting Recognition";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBoxToDraw.ResumeLayout(false);
            this.groupBoxToDraw.PerformLayout();
            this.groupBoxShowData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelToDraw;
        private System.Windows.Forms.GroupBox groupBoxToDraw;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.GroupBox groupBoxShowData;
        private System.Windows.Forms.RichTextBox richTextBoxShowData;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Label labelShowMessage;
        private System.Windows.Forms.Label labelNumberToDraw;
    }
}

