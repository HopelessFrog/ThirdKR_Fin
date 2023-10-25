using System.Windows.Forms;

namespace ThirdKR
{
    partial class AppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            textBoxRightBorder = new TextBox();
            textBoxA = new TextBox();
            textBoxStep = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            textBoxLeftBorder = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            chart = new ScottPlot.FormsPlot();
            toolStrip1 = new ToolStrip();
            toolStripButtonTryDraw = new ToolStripDropDownButton();
            drawToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButtonGreet = new ToolStripSplitButton();
            enableToolStripMenuItem = new ToolStripMenuItem();
            disableToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            buttonDraw = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            XColumn = new DataGridViewTextBoxColumn();
            YColumn = new DataGridViewTextBoxColumn();
            buttonClear = new Button();
            toolStripButton1 = new ToolStripButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxRightBorder
            // 
            textBoxRightBorder.Location = new Point(169, 188);
            textBoxRightBorder.Multiline = true;
            textBoxRightBorder.Name = "textBoxRightBorder";
            textBoxRightBorder.Size = new Size(90, 56);
            textBoxRightBorder.TabIndex = 3;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(169, 250);
            textBoxA.Multiline = true;
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(90, 56);
            textBoxA.TabIndex = 4;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(169, 310);
            textBoxStep.Multiline = true;
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(90, 56);
            textBoxStep.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 56);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 29);
            label1.TabIndex = 0;
            label1.Text = "Function";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(14, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 56);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1, 10);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 0;
            label2.Text = "Enter a";
            // 
            // textBoxLeftBorder
            // 
            textBoxLeftBorder.Location = new Point(169, 127);
            textBoxLeftBorder.Multiline = true;
            textBoxLeftBorder.Name = "textBoxLeftBorder";
            textBoxLeftBorder.Size = new Size(90, 56);
            textBoxLeftBorder.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(14, 310);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 56);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1, 11);
            label3.Name = "label3";
            label3.Size = new Size(125, 29);
            label3.TabIndex = 0;
            label3.Text = "Enter steps";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(14, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 56);
            panel4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Palatino Linotype", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 2);
            label4.Name = "label4";
            label4.Size = new Size(115, 54);
            label4.TabIndex = 0;
            label4.Text = "Enter right \r\nborder";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label5);
            panel5.Location = new Point(14, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 56);
            panel5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Palatino Linotype", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(2, 2);
            label5.Name = "label5";
            label5.Size = new Size(108, 54);
            label5.TabIndex = 0;
            label5.Text = "Enter \r\nleft border";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 53);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(169, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(90, 56);
            panel6.TabIndex = 12;
            // 
            // chart
            // 
            chart.Font = new Font("Palatino Linotype", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            chart.Location = new Point(315, 10);
            chart.Margin = new Padding(4, 3, 4, 3);
            chart.Name = "chart";
            chart.Size = new Size(744, 462);
            chart.TabIndex = 13;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonTryDraw, toolStripSplitButton1, toolStripSplitButtonGreet, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1321, 27);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonTryDraw
            // 
            toolStripButtonTryDraw.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonTryDraw.DropDownItems.AddRange(new ToolStripItem[] { drawToolStripMenuItem, clearToolStripMenuItem, removeToolStripMenuItem });
            toolStripButtonTryDraw.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButtonTryDraw.ImageTransparentColor = Color.Magenta;
            toolStripButtonTryDraw.Name = "toolStripButtonTryDraw";
            toolStripButtonTryDraw.Size = new Size(51, 24);
            toolStripButtonTryDraw.Text = "Tools";
            // 
            // drawToolStripMenuItem
            // 
            drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            drawToolStripMenuItem.Size = new Size(123, 22);
            drawToolStripMenuItem.Text = "Draw";
            drawToolStripMenuItem.Click += drawToolStripMenuItem_Click_1;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(123, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(123, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveDataToolStripMenuItem });
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(41, 24);
            toolStripSplitButton1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open File";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // saveDataToolStripMenuItem
            // 
            saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            saveDataToolStripMenuItem.Size = new Size(180, 22);
            saveDataToolStripMenuItem.Text = "Save data";
            saveDataToolStripMenuItem.Click += saveDataToolStripMenuItem_Click;
            // 
            // toolStripSplitButtonGreet
            // 
            toolStripSplitButtonGreet.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonGreet.DropDownItems.AddRange(new ToolStripItem[] { enableToolStripMenuItem, disableToolStripMenuItem, showToolStripMenuItem });
            toolStripSplitButtonGreet.Image = (Image)resources.GetObject("toolStripSplitButtonGreet.Image");
            toolStripSplitButtonGreet.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonGreet.Name = "toolStripSplitButtonGreet";
            toolStripSplitButtonGreet.Size = new Size(73, 24);
            toolStripSplitButtonGreet.Text = "Greetings";
            // 
            // enableToolStripMenuItem
            // 
            enableToolStripMenuItem.CheckOnClick = true;
            enableToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            enableToolStripMenuItem.Size = new Size(180, 22);
            enableToolStripMenuItem.Text = "Enable";
            enableToolStripMenuItem.Click += enableToolStripMenuItem_Click;
            // 
            // disableToolStripMenuItem
            // 
            disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            disableToolStripMenuItem.Size = new Size(180, 22);
            disableToolStripMenuItem.Text = "Disable";
            disableToolStripMenuItem.Click += disbaleToolStripMenuItem_Click;
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(180, 22);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // buttonDraw
            // 
            buttonDraw.BackColor = Color.White;
            buttonDraw.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDraw.Location = new Point(14, 389);
            buttonDraw.Margin = new Padding(3, 2, 3, 2);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(150, 55);
            buttonDraw.TabIndex = 15;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = false;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(14, 448);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(242, 55);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Delete Last";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { XColumn, YColumn });
            dataGridView1.Location = new Point(1053, 148);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(269, 201);
            dataGridView1.TabIndex = 19;
            // 
            // XColumn
            // 
            XColumn.HeaderText = "X";
            XColumn.MinimumWidth = 6;
            XColumn.Name = "XColumn";
            XColumn.Width = 125;
            // 
            // YColumn
            // 
            YColumn.HeaderText = "Y";
            YColumn.MinimumWidth = 6;
            YColumn.Name = "YColumn";
            YColumn.Width = 125;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.White;
            buttonClear.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Image = (Image)resources.GetObject("buttonClear.Image");
            buttonClear.Location = new Point(169, 389);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(88, 55);
            buttonClear.TabIndex = 20;
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(24, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1321, 505);
            Controls.Add(buttonClear);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonDraw);
            Controls.Add(toolStrip1);
            Controls.Add(chart);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(textBoxLeftBorder);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBoxStep);
            Controls.Add(textBoxA);
            Controls.Add(textBoxRightBorder);
            Name = "AppForm";
            Text = "App";
            Load += AppForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private PictureBox formula;
        private System.Windows.Forms.TextBox textBoxRightBorder;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxStep;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox textBoxLeftBorder;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel6;
        private ScottPlot.FormsPlot chart;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripButtonTryDraw;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveDataToolStripMenuItem;
        private Button buttonDraw;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn XColumn;
        private DataGridViewTextBoxColumn YColumn;
        private Button buttonClear;
        private ToolStripSplitButton toolStripSplitButtonGreet;
        private ToolStripMenuItem enableToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripButton toolStripButton1;
    }
}

