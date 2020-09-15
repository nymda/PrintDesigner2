namespace PrintDesignerMK2
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
            this.components = new System.ComponentModel.Container();
            this._dispCanvas = new System.Windows.Forms.PictureBox();
            this._layers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setShade4 = new System.Windows.Forms.PictureBox();
            this.setShade3 = new System.Windows.Forms.PictureBox();
            this.setShade2 = new System.Windows.Forms.PictureBox();
            this.setShade1 = new System.Windows.Forms.PictureBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemSize_X = new System.Windows.Forms.NumericUpDown();
            this.addItemSize_Y = new System.Windows.Forms.NumericUpDown();
            this.addItemSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbResize = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this._control_MoveLayer = new System.Windows.Forms.PictureBox();
            this.manipulationTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLayerUp = new System.Windows.Forms.Button();
            this.btnLayerDown = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnPrintFinalImg = new System.Windows.Forms.Button();
            this.clrButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dispCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setShade4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShade3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShade2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShade1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemSize_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemSize_Y)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._control_MoveLayer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dispCanvas
            // 
            this._dispCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._dispCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._dispCanvas.Location = new System.Drawing.Point(12, 12);
            this._dispCanvas.Name = "_dispCanvas";
            this._dispCanvas.Size = new System.Drawing.Size(181, 544);
            this._dispCanvas.TabIndex = 8;
            this._dispCanvas.TabStop = false;
            // 
            // _layers
            // 
            this._layers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._layers.FormattingEnabled = true;
            this._layers.Location = new System.Drawing.Point(6, 19);
            this._layers.Name = "_layers";
            this._layers.Size = new System.Drawing.Size(166, 134);
            this._layers.TabIndex = 9;
            this._layers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.layersLbDrawItem);
            this._layers.SelectedIndexChanged += new System.EventHandler(this._layers_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setShade4);
            this.groupBox1.Controls.Add(this.setShade3);
            this.groupBox1.Controls.Add(this.setShade2);
            this.groupBox1.Controls.Add(this.setShade1);
            this.groupBox1.Controls.Add(this.addItemBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addItemSize_X);
            this.groupBox1.Controls.Add(this.addItemSize_Y);
            this.groupBox1.Controls.Add(this.addItemSelect);
            this.groupBox1.Location = new System.Drawing.Point(199, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add items";
            // 
            // setShade4
            // 
            this.setShade4.Location = new System.Drawing.Point(152, 72);
            this.setShade4.Name = "setShade4";
            this.setShade4.Size = new System.Drawing.Size(20, 20);
            this.setShade4.TabIndex = 24;
            this.setShade4.TabStop = false;
            this.setShade4.Click += new System.EventHandler(this.shadeSelect_Click);
            // 
            // setShade3
            // 
            this.setShade3.Location = new System.Drawing.Point(126, 72);
            this.setShade3.Name = "setShade3";
            this.setShade3.Size = new System.Drawing.Size(20, 20);
            this.setShade3.TabIndex = 23;
            this.setShade3.TabStop = false;
            this.setShade3.Click += new System.EventHandler(this.shadeSelect_Click);
            // 
            // setShade2
            // 
            this.setShade2.Location = new System.Drawing.Point(152, 46);
            this.setShade2.Name = "setShade2";
            this.setShade2.Size = new System.Drawing.Size(20, 20);
            this.setShade2.TabIndex = 22;
            this.setShade2.TabStop = false;
            this.setShade2.Click += new System.EventHandler(this.shadeSelect_Click);
            // 
            // setShade1
            // 
            this.setShade1.Location = new System.Drawing.Point(126, 46);
            this.setShade1.Name = "setShade1";
            this.setShade1.Size = new System.Drawing.Size(20, 20);
            this.setShade1.TabIndex = 21;
            this.setShade1.TabStop = false;
            this.setShade1.Click += new System.EventHandler(this.shadeSelect_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(6, 98);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(166, 23);
            this.addItemBtn.TabIndex = 18;
            this.addItemBtn.Text = "Add item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Size-Y: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Size-X: ";
            // 
            // addItemSize_X
            // 
            this.addItemSize_X.Location = new System.Drawing.Point(57, 46);
            this.addItemSize_X.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.addItemSize_X.Name = "addItemSize_X";
            this.addItemSize_X.Size = new System.Drawing.Size(63, 20);
            this.addItemSize_X.TabIndex = 17;
            this.addItemSize_X.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // addItemSize_Y
            // 
            this.addItemSize_Y.Location = new System.Drawing.Point(57, 72);
            this.addItemSize_Y.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.addItemSize_Y.Name = "addItemSize_Y";
            this.addItemSize_Y.Size = new System.Drawing.Size(63, 20);
            this.addItemSize_Y.TabIndex = 18;
            this.addItemSize_Y.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // addItemSelect
            // 
            this.addItemSelect.FormattingEnabled = true;
            this.addItemSelect.Items.AddRange(new object[] {
            "Image",
            "String",
            "Square (transparent)",
            "Square (filled)",
            "Circle (transparent)",
            "Circle (filled)"});
            this.addItemSelect.Location = new System.Drawing.Point(6, 19);
            this.addItemSelect.Name = "addItemSelect";
            this.addItemSelect.Size = new System.Drawing.Size(166, 21);
            this.addItemSelect.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbResize);
            this.groupBox2.Controls.Add(this.rbMove);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this._control_MoveLayer);
            this.groupBox2.Location = new System.Drawing.Point(199, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 127);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manipulation";
            // 
            // rbResize
            // 
            this.rbResize.AutoSize = true;
            this.rbResize.Location = new System.Drawing.Point(112, 100);
            this.rbResize.Name = "rbResize";
            this.rbResize.Size = new System.Drawing.Size(57, 17);
            this.rbResize.TabIndex = 20;
            this.rbResize.Text = "Resize";
            this.rbResize.UseVisualStyleBackColor = true;
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Checked = true;
            this.rbMove.Location = new System.Drawing.Point(112, 77);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(52, 17);
            this.rbMove.TabIndex = 19;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(112, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Rotate R";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Rotate L";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // _control_MoveLayer
            // 
            this._control_MoveLayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._control_MoveLayer.Location = new System.Drawing.Point(6, 19);
            this._control_MoveLayer.Name = "_control_MoveLayer";
            this._control_MoveLayer.Size = new System.Drawing.Size(100, 100);
            this._control_MoveLayer.TabIndex = 16;
            this._control_MoveLayer.TabStop = false;
            this._control_MoveLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CML_Mousedown);
            this._control_MoveLayer.MouseLeave += new System.EventHandler(this.CML_Mouseleave);
            this._control_MoveLayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CML_Mousemove);
            this._control_MoveLayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CML_Mouseup);
            // 
            // manipulationTimer
            // 
            this.manipulationTimer.Interval = 50;
            this.manipulationTimer.Tick += new System.EventHandler(this.manipulationTimer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLayerUp);
            this.groupBox3.Controls.Add(this.btnLayerDown);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this._layers);
            this.groupBox3.Location = new System.Drawing.Point(199, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 224);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Layers";
            // 
            // btnLayerUp
            // 
            this.btnLayerUp.Location = new System.Drawing.Point(131, 162);
            this.btnLayerUp.Name = "btnLayerUp";
            this.btnLayerUp.Size = new System.Drawing.Size(41, 23);
            this.btnLayerUp.TabIndex = 16;
            this.btnLayerUp.Text = "/\\";
            this.btnLayerUp.UseVisualStyleBackColor = true;
            this.btnLayerUp.Click += new System.EventHandler(this.btnLayerUp_Click);
            // 
            // btnLayerDown
            // 
            this.btnLayerDown.Location = new System.Drawing.Point(131, 191);
            this.btnLayerDown.Name = "btnLayerDown";
            this.btnLayerDown.Size = new System.Drawing.Size(41, 23);
            this.btnLayerDown.TabIndex = 17;
            this.btnLayerDown.Text = "\\/";
            this.btnLayerDown.UseVisualStyleBackColor = true;
            this.btnLayerDown.Click += new System.EventHandler(this.btnLayerDown_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Delete layer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Add layer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPrintFinalImg
            // 
            this.btnPrintFinalImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintFinalImg.Location = new System.Drawing.Point(199, 509);
            this.btnPrintFinalImg.Name = "btnPrintFinalImg";
            this.btnPrintFinalImg.Size = new System.Drawing.Size(146, 47);
            this.btnPrintFinalImg.TabIndex = 14;
            this.btnPrintFinalImg.Text = "PRINT";
            this.btnPrintFinalImg.UseVisualStyleBackColor = true;
            this.btnPrintFinalImg.Click += new System.EventHandler(this.btnPrintFinalImg_Click);
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(351, 509);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(26, 47);
            this.clrButton.TabIndex = 17;
            this.clrButton.Text = "C\r\nL\r\nR\r\n";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 562);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.btnPrintFinalImg);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dispCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dispCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setShade4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShade3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShade2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShade1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemSize_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemSize_Y)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._control_MoveLayer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _dispCanvas;
        private System.Windows.Forms.ListBox _layers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbResize;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox _control_MoveLayer;
        private System.Windows.Forms.Timer manipulationTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLayerUp;
        private System.Windows.Forms.Button btnLayerDown;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPrintFinalImg;
        private System.Windows.Forms.ComboBox addItemSelect;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown addItemSize_X;
        private System.Windows.Forms.NumericUpDown addItemSize_Y;
        private System.Windows.Forms.PictureBox setShade4;
        private System.Windows.Forms.PictureBox setShade3;
        private System.Windows.Forms.PictureBox setShade2;
        private System.Windows.Forms.PictureBox setShade1;
        private System.Windows.Forms.Button clrButton;
    }
}

