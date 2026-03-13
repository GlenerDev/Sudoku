namespace Sudokku_corrigido
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
        public void InitializeComponent()
        {
            TlpMenu = new TableLayoutPanel();
            btnDificil = new Button();
            btnMedio = new Button();
            btnFacil = new Button();
            tplRoud = new TableLayoutPanel();
            pnlDiigits = new Panel();
            button90 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            lbTrySudokku = new Label();
            tlpMatrix = new TableLayoutPanel();
            button89 = new Button();
            button88 = new Button();
            button87 = new Button();
            button86 = new Button();
            button85 = new Button();
            button84 = new Button();
            button83 = new Button();
            button82 = new Button();
            button81 = new Button();
            button80 = new Button();
            button79 = new Button();
            button78 = new Button();
            button77 = new Button();
            button76 = new Button();
            button75 = new Button();
            button74 = new Button();
            button73 = new Button();
            button72 = new Button();
            button71 = new Button();
            button70 = new Button();
            button69 = new Button();
            button68 = new Button();
            button67 = new Button();
            button66 = new Button();
            button65 = new Button();
            button64 = new Button();
            button63 = new Button();
            button62 = new Button();
            button61 = new Button();
            button60 = new Button();
            button59 = new Button();
            button58 = new Button();
            button57 = new Button();
            button56 = new Button();
            button55 = new Button();
            button54 = new Button();
            button53 = new Button();
            button52 = new Button();
            button51 = new Button();
            button50 = new Button();
            button49 = new Button();
            button48 = new Button();
            button47 = new Button();
            button46 = new Button();
            button45 = new Button();
            button44 = new Button();
            button43 = new Button();
            button42 = new Button();
            button41 = new Button();
            button40 = new Button();
            button39 = new Button();
            button38 = new Button();
            button37 = new Button();
            button36 = new Button();
            button35 = new Button();
            button34 = new Button();
            button33 = new Button();
            button32 = new Button();
            button31 = new Button();
            button30 = new Button();
            button29 = new Button();
            button28 = new Button();
            button27 = new Button();
            button26 = new Button();
            button25 = new Button();
            button24 = new Button();
            button23 = new Button();
            button22 = new Button();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button6 = new Button();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnCancel = new Button();
            TlpMenu.SuspendLayout();
            tplRoud.SuspendLayout();
            pnlDiigits.SuspendLayout();
            tlpMatrix.SuspendLayout();
            SuspendLayout();
            // 
            // TlpMenu
            // 
            TlpMenu.BackColor = SystemColors.ControlLightLight;
            TlpMenu.ColumnCount = 1;
            TlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpMenu.Controls.Add(btnDificil, 0, 3);
            TlpMenu.Controls.Add(btnMedio, 0, 2);
            TlpMenu.Controls.Add(btnFacil, 0, 1);
            TlpMenu.Dock = DockStyle.Fill;
            TlpMenu.Location = new Point(0, 0);
            TlpMenu.Name = "TlpMenu";
            TlpMenu.RowCount = 5;
            TlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 28.10023F));
            TlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3353891F));
            TlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3353891F));
            TlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5980921F));
            TlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6309052F));
            TlpMenu.Size = new Size(993, 542);
            TlpMenu.TabIndex = 0;
            // 
            // btnDificil
            // 
            btnDificil.Anchor = AnchorStyles.None;
            btnDificil.BackColor = Color.CadetBlue;
            btnDificil.FlatAppearance.BorderSize = 0;
            btnDificil.FlatStyle = FlatStyle.Flat;
            btnDificil.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDificil.Location = new Point(142, 318);
            btnDificil.Name = "btnDificil";
            btnDificil.Size = new Size(709, 60);
            btnDificil.TabIndex = 2;
            btnDificil.Text = "Dificil";
            btnDificil.UseVisualStyleBackColor = false;
            btnDificil.Click += EventBtnmenu;
            // 
            // btnMedio
            // 
            btnMedio.Anchor = AnchorStyles.None;
            btnMedio.BackColor = Color.CadetBlue;
            btnMedio.FlatAppearance.BorderSize = 0;
            btnMedio.FlatStyle = FlatStyle.Flat;
            btnMedio.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMedio.Location = new Point(142, 237);
            btnMedio.Name = "btnMedio";
            btnMedio.Size = new Size(709, 60);
            btnMedio.TabIndex = 1;
            btnMedio.Text = "Medio";
            btnMedio.UseVisualStyleBackColor = false;
            btnMedio.Click += EventBtnmenu;
            // 
            // btnFacil
            // 
            btnFacil.Anchor = AnchorStyles.None;
            btnFacil.BackColor = Color.CadetBlue;
            btnFacil.FlatAppearance.BorderSize = 0;
            btnFacil.FlatStyle = FlatStyle.Flat;
            btnFacil.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFacil.Location = new Point(142, 160);
            btnFacil.Name = "btnFacil";
            btnFacil.Size = new Size(709, 60);
            btnFacil.TabIndex = 0;
            btnFacil.Text = "Facil";
            btnFacil.UseVisualStyleBackColor = false;
            btnFacil.Click += EventBtnmenu;
            // 
            // tplRoud
            // 
            tplRoud.BackColor = SystemColors.ControlLight;
            tplRoud.ColumnCount = 2;
            tplRoud.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.8038864F));
            tplRoud.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.1961136F));
            tplRoud.Controls.Add(pnlDiigits, 1, 0);
            tplRoud.Controls.Add(lbTrySudokku, 1, 1);
            tplRoud.Controls.Add(tlpMatrix, 0, 0);
            tplRoud.Controls.Add(btnCancel, 0, 1);
            tplRoud.Dock = DockStyle.Fill;
            tplRoud.Location = new Point(0, 0);
            tplRoud.Name = "tplRoud";
            tplRoud.RowCount = 3;
            tplRoud.RowStyles.Add(new RowStyle(SizeType.Percent, 89.5306854F));
            tplRoud.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4693136F));
            tplRoud.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tplRoud.Size = new Size(993, 542);
            tplRoud.TabIndex = 1;
            // 
            // pnlDiigits
            // 
            pnlDiigits.Anchor = AnchorStyles.None;
            pnlDiigits.BackColor = Color.Azure;
            pnlDiigits.Controls.Add(button90);
            pnlDiigits.Controls.Add(button12);
            pnlDiigits.Controls.Add(button11);
            pnlDiigits.Controls.Add(button10);
            pnlDiigits.Controls.Add(button9);
            pnlDiigits.Controls.Add(button7);
            pnlDiigits.Controls.Add(button4);
            pnlDiigits.Controls.Add(button3);
            pnlDiigits.Controls.Add(button8);
            pnlDiigits.ForeColor = Color.CadetBlue;
            pnlDiigits.Location = new Point(673, 144);
            pnlDiigits.Name = "pnlDiigits";
            pnlDiigits.Size = new Size(161, 179);
            pnlDiigits.TabIndex = 0;
            // 
            // button90
            // 
            button90.Anchor = AnchorStyles.None;
            button90.BackColor = Color.CadetBlue;
            button90.FlatAppearance.BorderSize = 0;
            button90.FlatStyle = FlatStyle.Flat;
            button90.ForeColor = SystemColors.ControlText;
            button90.Location = new Point(22, 30);
            button90.Name = "button90";
            button90.Size = new Size(35, 36);
            button90.TabIndex = 45;
            button90.Text = "1";
            button90.UseVisualStyleBackColor = false;
            button90.Click += EventBtnClickSelectDigit;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.None;
            button12.BackColor = Color.CadetBlue;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = SystemColors.ControlText;
            button12.Location = new Point(104, 113);
            button12.Name = "button12";
            button12.Size = new Size(35, 36);
            button12.TabIndex = 10;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = false;
            button12.Click += EventBtnClickSelectDigit;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.None;
            button11.BackColor = Color.CadetBlue;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = SystemColors.ControlText;
            button11.Location = new Point(63, 113);
            button11.Name = "button11";
            button11.Size = new Size(35, 36);
            button11.TabIndex = 9;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = false;
            button11.Click += EventBtnClickSelectDigit;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.None;
            button10.BackColor = Color.CadetBlue;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = SystemColors.ControlText;
            button10.Location = new Point(22, 113);
            button10.Name = "button10";
            button10.Size = new Size(35, 36);
            button10.TabIndex = 8;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = false;
            button10.Click += EventBtnClickSelectDigit;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.BackColor = Color.CadetBlue;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.ControlText;
            button9.Location = new Point(22, 71);
            button9.Name = "button9";
            button9.Size = new Size(35, 36);
            button9.TabIndex = 7;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = false;
            button9.Click += EventBtnClickSelectDigit;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.CadetBlue;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ControlText;
            button8.Location = new Point(63, 71);
            button8.Name = "button8";
            button8.Size = new Size(35, 36);
            button8.TabIndex = 6;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = false;
            button8.Click += EventBtnClickSelectDigit;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.CadetBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(104, 71);
            button7.Name = "button7";
            button7.Size = new Size(35, 36);
            button7.TabIndex = 5;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += EventBtnClickSelectDigit;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.CadetBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(104, 29);
            button4.Name = "button4";
            button4.Size = new Size(35, 36);
            button4.TabIndex = 2;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += EventBtnClickSelectDigit;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.CadetBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(63, 29);
            button3.Name = "button3";
            button3.Size = new Size(35, 36);
            button3.TabIndex = 1;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += EventBtnClickSelectDigit;
            // 
            // lbTrySudokku
            // 
            lbTrySudokku.Anchor = AnchorStyles.None;
            lbTrySudokku.AutoSize = true;
            lbTrySudokku.BackColor = SystemColors.InactiveCaption;
            lbTrySudokku.FlatStyle = FlatStyle.Flat;
            lbTrySudokku.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTrySudokku.Location = new Point(741, 481);
            lbTrySudokku.Name = "lbTrySudokku";
            lbTrySudokku.Size = new Size(25, 25);
            lbTrySudokku.TabIndex = 3;
            lbTrySudokku.Text = "0";
            // 
            // tlpMatrix
            // 
            tlpMatrix.Anchor = AnchorStyles.None;
            tlpMatrix.ColumnCount = 9;
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tlpMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMatrix.Controls.Add(button89, 8, 8);
            tlpMatrix.Controls.Add(button88, 7, 8);
            tlpMatrix.Controls.Add(button87, 6, 8);
            tlpMatrix.Controls.Add(button86, 5, 8);
            tlpMatrix.Controls.Add(button85, 4, 8);
            tlpMatrix.Controls.Add(button84, 3, 8);
            tlpMatrix.Controls.Add(button83, 2, 8);
            tlpMatrix.Controls.Add(button82, 1, 8);
            tlpMatrix.Controls.Add(button81, 0, 8);
            tlpMatrix.Controls.Add(button80, 8, 7);
            tlpMatrix.Controls.Add(button79, 7, 7);
            tlpMatrix.Controls.Add(button78, 6, 7);
            tlpMatrix.Controls.Add(button77, 5, 7);
            tlpMatrix.Controls.Add(button76, 4, 7);
            tlpMatrix.Controls.Add(button75, 3, 7);
            tlpMatrix.Controls.Add(button74, 2, 7);
            tlpMatrix.Controls.Add(button73, 1, 7);
            tlpMatrix.Controls.Add(button72, 0, 7);
            tlpMatrix.Controls.Add(button71, 8, 6);
            tlpMatrix.Controls.Add(button70, 7, 6);
            tlpMatrix.Controls.Add(button69, 6, 6);
            tlpMatrix.Controls.Add(button68, 5, 6);
            tlpMatrix.Controls.Add(button67, 4, 6);
            tlpMatrix.Controls.Add(button66, 3, 6);
            tlpMatrix.Controls.Add(button65, 2, 6);
            tlpMatrix.Controls.Add(button64, 1, 6);
            tlpMatrix.Controls.Add(button63, 0, 6);
            tlpMatrix.Controls.Add(button62, 8, 5);
            tlpMatrix.Controls.Add(button61, 7, 5);
            tlpMatrix.Controls.Add(button60, 6, 5);
            tlpMatrix.Controls.Add(button59, 5, 5);
            tlpMatrix.Controls.Add(button58, 4, 5);
            tlpMatrix.Controls.Add(button57, 3, 5);
            tlpMatrix.Controls.Add(button56, 2, 5);
            tlpMatrix.Controls.Add(button55, 1, 5);
            tlpMatrix.Controls.Add(button54, 0, 5);
            tlpMatrix.Controls.Add(button53, 8, 4);
            tlpMatrix.Controls.Add(button52, 7, 4);
            tlpMatrix.Controls.Add(button51, 6, 4);
            tlpMatrix.Controls.Add(button50, 5, 4);
            tlpMatrix.Controls.Add(button49, 4, 4);
            tlpMatrix.Controls.Add(button48, 3, 4);
            tlpMatrix.Controls.Add(button47, 2, 4);
            tlpMatrix.Controls.Add(button46, 1, 4);
            tlpMatrix.Controls.Add(button45, 0, 4);
            tlpMatrix.Controls.Add(button44, 8, 3);
            tlpMatrix.Controls.Add(button43, 7, 3);
            tlpMatrix.Controls.Add(button42, 6, 3);
            tlpMatrix.Controls.Add(button41, 5, 3);
            tlpMatrix.Controls.Add(button40, 4, 3);
            tlpMatrix.Controls.Add(button39, 3, 3);
            tlpMatrix.Controls.Add(button38, 2, 3);
            tlpMatrix.Controls.Add(button37, 1, 3);
            tlpMatrix.Controls.Add(button36, 0, 3);
            tlpMatrix.Controls.Add(button35, 8, 2);
            tlpMatrix.Controls.Add(button34, 7, 2);
            tlpMatrix.Controls.Add(button33, 6, 2);
            tlpMatrix.Controls.Add(button32, 5, 2);
            tlpMatrix.Controls.Add(button31, 4, 2);
            tlpMatrix.Controls.Add(button30, 3, 2);
            tlpMatrix.Controls.Add(button29, 2, 2);
            tlpMatrix.Controls.Add(button28, 1, 2);
            tlpMatrix.Controls.Add(button27, 0, 2);
            tlpMatrix.Controls.Add(button26, 8, 1);
            tlpMatrix.Controls.Add(button25, 7, 1);
            tlpMatrix.Controls.Add(button24, 6, 1);
            tlpMatrix.Controls.Add(button23, 5, 1);
            tlpMatrix.Controls.Add(button22, 4, 1);
            tlpMatrix.Controls.Add(button21, 3, 1);
            tlpMatrix.Controls.Add(button20, 2, 1);
            tlpMatrix.Controls.Add(button19, 1, 1);
            tlpMatrix.Controls.Add(button18, 0, 1);
            tlpMatrix.Controls.Add(button17, 8, 0);
            tlpMatrix.Controls.Add(button16, 7, 0);
            tlpMatrix.Controls.Add(button15, 6, 0);
            tlpMatrix.Controls.Add(button14, 5, 0);
            tlpMatrix.Controls.Add(button13, 4, 0);
            tlpMatrix.Controls.Add(button6, 3, 0);
            tlpMatrix.Controls.Add(button5, 2, 0);
            tlpMatrix.Controls.Add(button2, 1, 0);
            tlpMatrix.Controls.Add(button1, 0, 0);
            tlpMatrix.ForeColor = SystemColors.WindowText;
            tlpMatrix.Location = new Point(4, 5);
            tlpMatrix.Name = "tlpMatrix";
            tlpMatrix.RowCount = 10;
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMatrix.Size = new Size(506, 457);
            tlpMatrix.TabIndex = 4;
            // 
            // button89
            // 
            button89.Anchor = AnchorStyles.None;
            button89.BackColor = SystemColors.InactiveCaption;
            button89.FlatAppearance.BorderSize = 0;
            button89.FlatStyle = FlatStyle.Flat;
            button89.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button89.Location = new Point(461, 407);
            button89.Name = "button89";
            button89.Size = new Size(32, 36);
            button89.TabIndex = 80;
            button89.Text = "1";
            button89.UseVisualStyleBackColor = false;
            button89.Click += EventClicksBtnsGrade;
            // 
            // button88
            // 
            button88.Anchor = AnchorStyles.None;
            button88.BackColor = SystemColors.InactiveCaption;
            button88.FlatAppearance.BorderSize = 0;
            button88.FlatStyle = FlatStyle.Flat;
            button88.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button88.Location = new Point(402, 407);
            button88.Name = "button88";
            button88.Size = new Size(35, 36);
            button88.TabIndex = 79;
            button88.Text = "1";
            button88.UseVisualStyleBackColor = false;
            button88.Click += EventClicksBtnsGrade;
            // 
            // button87
            // 
            button87.Anchor = AnchorStyles.None;
            button87.BackColor = SystemColors.InactiveCaption;
            button87.FlatAppearance.BorderSize = 0;
            button87.FlatStyle = FlatStyle.Flat;
            button87.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button87.Location = new Point(345, 407);
            button87.Name = "button87";
            button87.Size = new Size(35, 36);
            button87.TabIndex = 78;
            button87.Text = "1";
            button87.UseVisualStyleBackColor = false;
            button87.Click += EventClicksBtnsGrade;
            // 
            // button86
            // 
            button86.Anchor = AnchorStyles.None;
            button86.BackColor = SystemColors.InactiveCaption;
            button86.FlatAppearance.BorderSize = 0;
            button86.FlatStyle = FlatStyle.Flat;
            button86.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button86.Location = new Point(288, 407);
            button86.Name = "button86";
            button86.Size = new Size(35, 36);
            button86.TabIndex = 77;
            button86.Text = "1";
            button86.UseVisualStyleBackColor = false;
            button86.Click += EventClicksBtnsGrade;
            // 
            // button85
            // 
            button85.Anchor = AnchorStyles.None;
            button85.BackColor = SystemColors.InactiveCaption;
            button85.FlatAppearance.BorderSize = 0;
            button85.FlatStyle = FlatStyle.Flat;
            button85.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button85.Location = new Point(233, 407);
            button85.Name = "button85";
            button85.Size = new Size(35, 36);
            button85.TabIndex = 76;
            button85.Text = "1";
            button85.UseVisualStyleBackColor = false;
            button85.Click += EventClicksBtnsGrade;
            // 
            // button84
            // 
            button84.Anchor = AnchorStyles.None;
            button84.BackColor = SystemColors.InactiveCaption;
            button84.FlatAppearance.BorderSize = 0;
            button84.FlatStyle = FlatStyle.Flat;
            button84.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button84.Location = new Point(176, 407);
            button84.Name = "button84";
            button84.Size = new Size(35, 36);
            button84.TabIndex = 75;
            button84.Text = "1";
            button84.UseVisualStyleBackColor = false;
            button84.Click += EventClicksBtnsGrade;
            // 
            // button83
            // 
            button83.Anchor = AnchorStyles.None;
            button83.BackColor = SystemColors.InactiveCaption;
            button83.FlatAppearance.BorderSize = 0;
            button83.FlatStyle = FlatStyle.Flat;
            button83.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button83.Location = new Point(120, 407);
            button83.Name = "button83";
            button83.Size = new Size(35, 36);
            button83.TabIndex = 74;
            button83.Text = "1";
            button83.UseVisualStyleBackColor = false;
            button83.Click += EventClicksBtnsGrade;
            // 
            // button82
            // 
            button82.Anchor = AnchorStyles.None;
            button82.BackColor = SystemColors.InactiveCaption;
            button82.FlatAppearance.BorderSize = 0;
            button82.FlatStyle = FlatStyle.Flat;
            button82.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button82.Location = new Point(66, 407);
            button82.Name = "button82";
            button82.Size = new Size(35, 36);
            button82.TabIndex = 73;
            button82.Text = "1";
            button82.UseVisualStyleBackColor = false;
            button82.Click += EventClicksBtnsGrade;
            // 
            // button81
            // 
            button81.Anchor = AnchorStyles.None;
            button81.BackColor = SystemColors.InactiveCaption;
            button81.FlatAppearance.BorderSize = 0;
            button81.FlatStyle = FlatStyle.Flat;
            button81.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button81.Location = new Point(10, 407);
            button81.Name = "button81";
            button81.Size = new Size(35, 36);
            button81.TabIndex = 72;
            button81.Text = "1";
            button81.UseVisualStyleBackColor = false;
            button81.Click += EventClicksBtnsGrade;
            // 
            // button80
            // 
            button80.Anchor = AnchorStyles.None;
            button80.BackColor = SystemColors.InactiveCaption;
            button80.FlatAppearance.BorderSize = 0;
            button80.FlatStyle = FlatStyle.Flat;
            button80.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button80.Location = new Point(461, 357);
            button80.Name = "button80";
            button80.Size = new Size(32, 36);
            button80.TabIndex = 71;
            button80.Text = "1";
            button80.UseVisualStyleBackColor = false;
            button80.Click += EventClicksBtnsGrade;
            // 
            // button79
            // 
            button79.Anchor = AnchorStyles.None;
            button79.BackColor = SystemColors.InactiveCaption;
            button79.FlatAppearance.BorderSize = 0;
            button79.FlatStyle = FlatStyle.Flat;
            button79.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button79.Location = new Point(402, 357);
            button79.Name = "button79";
            button79.Size = new Size(35, 36);
            button79.TabIndex = 70;
            button79.Text = "1";
            button79.UseVisualStyleBackColor = false;
            button79.Click += EventClicksBtnsGrade;
            // 
            // button78
            // 
            button78.Anchor = AnchorStyles.None;
            button78.BackColor = SystemColors.InactiveCaption;
            button78.FlatAppearance.BorderSize = 0;
            button78.FlatStyle = FlatStyle.Flat;
            button78.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button78.Location = new Point(345, 357);
            button78.Name = "button78";
            button78.Size = new Size(35, 36);
            button78.TabIndex = 69;
            button78.Text = "1";
            button78.UseVisualStyleBackColor = false;
            button78.Click += EventClicksBtnsGrade;
            // 
            // button77
            // 
            button77.Anchor = AnchorStyles.None;
            button77.BackColor = SystemColors.InactiveCaption;
            button77.FlatAppearance.BorderSize = 0;
            button77.FlatStyle = FlatStyle.Flat;
            button77.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button77.Location = new Point(288, 357);
            button77.Name = "button77";
            button77.Size = new Size(35, 36);
            button77.TabIndex = 68;
            button77.Text = "1";
            button77.UseVisualStyleBackColor = false;
            button77.Click += EventClicksBtnsGrade;
            // 
            // button76
            // 
            button76.Anchor = AnchorStyles.None;
            button76.BackColor = SystemColors.InactiveCaption;
            button76.FlatAppearance.BorderSize = 0;
            button76.FlatStyle = FlatStyle.Flat;
            button76.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button76.Location = new Point(233, 357);
            button76.Name = "button76";
            button76.Size = new Size(35, 36);
            button76.TabIndex = 67;
            button76.Text = "1";
            button76.UseVisualStyleBackColor = false;
            button76.Click += EventClicksBtnsGrade;
            // 
            // button75
            // 
            button75.Anchor = AnchorStyles.None;
            button75.BackColor = SystemColors.InactiveCaption;
            button75.FlatAppearance.BorderSize = 0;
            button75.FlatStyle = FlatStyle.Flat;
            button75.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button75.Location = new Point(176, 357);
            button75.Name = "button75";
            button75.Size = new Size(35, 36);
            button75.TabIndex = 66;
            button75.Text = "1";
            button75.UseVisualStyleBackColor = false;
            button75.Click += EventClicksBtnsGrade;
            // 
            // button74
            // 
            button74.Anchor = AnchorStyles.None;
            button74.BackColor = SystemColors.InactiveCaption;
            button74.FlatAppearance.BorderSize = 0;
            button74.FlatStyle = FlatStyle.Flat;
            button74.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button74.Location = new Point(120, 357);
            button74.Name = "button74";
            button74.Size = new Size(35, 36);
            button74.TabIndex = 65;
            button74.Text = "1";
            button74.UseVisualStyleBackColor = false;
            button74.Click += EventClicksBtnsGrade;
            // 
            // button73
            // 
            button73.Anchor = AnchorStyles.None;
            button73.BackColor = SystemColors.InactiveCaption;
            button73.FlatAppearance.BorderSize = 0;
            button73.FlatStyle = FlatStyle.Flat;
            button73.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button73.Location = new Point(66, 357);
            button73.Name = "button73";
            button73.Size = new Size(35, 36);
            button73.TabIndex = 64;
            button73.Text = "1";
            button73.UseVisualStyleBackColor = false;
            button73.Click += EventClicksBtnsGrade;
            // 
            // button72
            // 
            button72.Anchor = AnchorStyles.None;
            button72.BackColor = SystemColors.InactiveCaption;
            button72.FlatAppearance.BorderSize = 0;
            button72.FlatStyle = FlatStyle.Flat;
            button72.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button72.Location = new Point(10, 357);
            button72.Name = "button72";
            button72.Size = new Size(35, 36);
            button72.TabIndex = 63;
            button72.Text = "1";
            button72.UseVisualStyleBackColor = false;
            button72.Click += EventClicksBtnsGrade;
            // 
            // button71
            // 
            button71.Anchor = AnchorStyles.None;
            button71.BackColor = SystemColors.InactiveCaption;
            button71.FlatAppearance.BorderSize = 0;
            button71.FlatStyle = FlatStyle.Flat;
            button71.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button71.Location = new Point(461, 307);
            button71.Name = "button71";
            button71.Size = new Size(32, 36);
            button71.TabIndex = 62;
            button71.Text = "1";
            button71.UseVisualStyleBackColor = false;
            button71.Click += EventClicksBtnsGrade;
            // 
            // button70
            // 
            button70.Anchor = AnchorStyles.None;
            button70.BackColor = SystemColors.InactiveCaption;
            button70.FlatAppearance.BorderSize = 0;
            button70.FlatStyle = FlatStyle.Flat;
            button70.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button70.Location = new Point(402, 307);
            button70.Name = "button70";
            button70.Size = new Size(35, 36);
            button70.TabIndex = 61;
            button70.Text = "1";
            button70.UseVisualStyleBackColor = false;
            button70.Click += EventClicksBtnsGrade;
            // 
            // button69
            // 
            button69.Anchor = AnchorStyles.None;
            button69.BackColor = SystemColors.InactiveCaption;
            button69.FlatAppearance.BorderSize = 0;
            button69.FlatStyle = FlatStyle.Flat;
            button69.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button69.Location = new Point(345, 307);
            button69.Name = "button69";
            button69.Size = new Size(35, 36);
            button69.TabIndex = 60;
            button69.Text = "1";
            button69.UseVisualStyleBackColor = false;
            button69.Click += EventClicksBtnsGrade;
            // 
            // button68
            // 
            button68.Anchor = AnchorStyles.None;
            button68.BackColor = SystemColors.InactiveCaption;
            button68.FlatAppearance.BorderSize = 0;
            button68.FlatStyle = FlatStyle.Flat;
            button68.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button68.Location = new Point(288, 307);
            button68.Name = "button68";
            button68.Size = new Size(35, 36);
            button68.TabIndex = 59;
            button68.Text = "1";
            button68.UseVisualStyleBackColor = false;
            button68.Click += EventClicksBtnsGrade;
            // 
            // button67
            // 
            button67.Anchor = AnchorStyles.None;
            button67.BackColor = SystemColors.InactiveCaption;
            button67.FlatAppearance.BorderSize = 0;
            button67.FlatStyle = FlatStyle.Flat;
            button67.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button67.Location = new Point(233, 307);
            button67.Name = "button67";
            button67.Size = new Size(35, 36);
            button67.TabIndex = 58;
            button67.Text = "1";
            button67.UseVisualStyleBackColor = false;
            button67.Click += EventClicksBtnsGrade;
            // 
            // button66
            // 
            button66.Anchor = AnchorStyles.None;
            button66.BackColor = SystemColors.InactiveCaption;
            button66.FlatAppearance.BorderSize = 0;
            button66.FlatStyle = FlatStyle.Flat;
            button66.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button66.Location = new Point(176, 307);
            button66.Name = "button66";
            button66.Size = new Size(35, 36);
            button66.TabIndex = 57;
            button66.Text = "1";
            button66.UseVisualStyleBackColor = false;
            button66.Click += EventClicksBtnsGrade;
            // 
            // button65
            // 
            button65.Anchor = AnchorStyles.None;
            button65.BackColor = SystemColors.InactiveCaption;
            button65.FlatAppearance.BorderSize = 0;
            button65.FlatStyle = FlatStyle.Flat;
            button65.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button65.Location = new Point(120, 307);
            button65.Name = "button65";
            button65.Size = new Size(35, 36);
            button65.TabIndex = 56;
            button65.Text = "1";
            button65.UseVisualStyleBackColor = false;
            button65.Click += EventClicksBtnsGrade;
            // 
            // button64
            // 
            button64.Anchor = AnchorStyles.None;
            button64.BackColor = SystemColors.InactiveCaption;
            button64.FlatAppearance.BorderSize = 0;
            button64.FlatStyle = FlatStyle.Flat;
            button64.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button64.Location = new Point(66, 307);
            button64.Name = "button64";
            button64.Size = new Size(35, 36);
            button64.TabIndex = 55;
            button64.Text = "1";
            button64.UseVisualStyleBackColor = false;
            button64.Click += EventClicksBtnsGrade;
            // 
            // button63
            // 
            button63.Anchor = AnchorStyles.None;
            button63.BackColor = SystemColors.InactiveCaption;
            button63.FlatAppearance.BorderSize = 0;
            button63.FlatStyle = FlatStyle.Flat;
            button63.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button63.Location = new Point(10, 307);
            button63.Name = "button63";
            button63.Size = new Size(35, 36);
            button63.TabIndex = 54;
            button63.Text = "1";
            button63.UseVisualStyleBackColor = false;
            button63.Click += EventClicksBtnsGrade;
            // 
            // button62
            // 
            button62.Anchor = AnchorStyles.None;
            button62.BackColor = SystemColors.InactiveCaption;
            button62.FlatAppearance.BorderSize = 0;
            button62.FlatStyle = FlatStyle.Flat;
            button62.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button62.Location = new Point(461, 257);
            button62.Name = "button62";
            button62.Size = new Size(32, 36);
            button62.TabIndex = 53;
            button62.Text = "1";
            button62.UseVisualStyleBackColor = false;
            button62.Click += EventClicksBtnsGrade;
            // 
            // button61
            // 
            button61.Anchor = AnchorStyles.None;
            button61.BackColor = SystemColors.InactiveCaption;
            button61.FlatAppearance.BorderSize = 0;
            button61.FlatStyle = FlatStyle.Flat;
            button61.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button61.Location = new Point(402, 257);
            button61.Name = "button61";
            button61.Size = new Size(35, 36);
            button61.TabIndex = 52;
            button61.Text = "1";
            button61.UseVisualStyleBackColor = false;
            button61.Click += EventClicksBtnsGrade;
            // 
            // button60
            // 
            button60.Anchor = AnchorStyles.None;
            button60.BackColor = SystemColors.InactiveCaption;
            button60.FlatAppearance.BorderSize = 0;
            button60.FlatStyle = FlatStyle.Flat;
            button60.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button60.Location = new Point(345, 257);
            button60.Name = "button60";
            button60.Size = new Size(35, 36);
            button60.TabIndex = 51;
            button60.Text = "1";
            button60.UseVisualStyleBackColor = false;
            button60.Click += EventClicksBtnsGrade;
            // 
            // button59
            // 
            button59.Anchor = AnchorStyles.None;
            button59.BackColor = SystemColors.InactiveCaption;
            button59.FlatAppearance.BorderSize = 0;
            button59.FlatStyle = FlatStyle.Flat;
            button59.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button59.Location = new Point(288, 257);
            button59.Name = "button59";
            button59.Size = new Size(35, 36);
            button59.TabIndex = 50;
            button59.Text = "1";
            button59.UseVisualStyleBackColor = false;
            button59.Click += EventClicksBtnsGrade;
            // 
            // button58
            // 
            button58.Anchor = AnchorStyles.None;
            button58.BackColor = SystemColors.InactiveCaption;
            button58.FlatAppearance.BorderSize = 0;
            button58.FlatStyle = FlatStyle.Flat;
            button58.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button58.Location = new Point(233, 257);
            button58.Name = "button58";
            button58.Size = new Size(35, 36);
            button58.TabIndex = 49;
            button58.Text = "1";
            button58.UseVisualStyleBackColor = false;
            button58.Click += EventClicksBtnsGrade;
            // 
            // button57
            // 
            button57.Anchor = AnchorStyles.None;
            button57.BackColor = SystemColors.InactiveCaption;
            button57.FlatAppearance.BorderSize = 0;
            button57.FlatStyle = FlatStyle.Flat;
            button57.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button57.Location = new Point(176, 257);
            button57.Name = "button57";
            button57.Size = new Size(35, 36);
            button57.TabIndex = 48;
            button57.Text = "1";
            button57.UseVisualStyleBackColor = false;
            button57.Click += EventClicksBtnsGrade;
            // 
            // button56
            // 
            button56.Anchor = AnchorStyles.None;
            button56.BackColor = SystemColors.InactiveCaption;
            button56.FlatAppearance.BorderSize = 0;
            button56.FlatStyle = FlatStyle.Flat;
            button56.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button56.Location = new Point(120, 257);
            button56.Name = "button56";
            button56.Size = new Size(35, 36);
            button56.TabIndex = 47;
            button56.Text = "1";
            button56.UseVisualStyleBackColor = false;
            button56.Click += EventClicksBtnsGrade;
            // 
            // button55
            // 
            button55.Anchor = AnchorStyles.None;
            button55.BackColor = SystemColors.InactiveCaption;
            button55.FlatAppearance.BorderSize = 0;
            button55.FlatStyle = FlatStyle.Flat;
            button55.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button55.Location = new Point(66, 257);
            button55.Name = "button55";
            button55.Size = new Size(35, 36);
            button55.TabIndex = 46;
            button55.Text = "1";
            button55.UseVisualStyleBackColor = false;
            button55.Click += EventClicksBtnsGrade;
            // 
            // button54
            // 
            button54.Anchor = AnchorStyles.None;
            button54.BackColor = SystemColors.InactiveCaption;
            button54.FlatAppearance.BorderSize = 0;
            button54.FlatStyle = FlatStyle.Flat;
            button54.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button54.Location = new Point(10, 257);
            button54.Name = "button54";
            button54.Size = new Size(35, 36);
            button54.TabIndex = 45;
            button54.Text = "1";
            button54.UseVisualStyleBackColor = false;
            button54.Click += EventClicksBtnsGrade;
            // 
            // button53
            // 
            button53.Anchor = AnchorStyles.None;
            button53.BackColor = SystemColors.InactiveCaption;
            button53.FlatAppearance.BorderSize = 0;
            button53.FlatStyle = FlatStyle.Flat;
            button53.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button53.Location = new Point(461, 207);
            button53.Name = "button53";
            button53.Size = new Size(32, 36);
            button53.TabIndex = 44;
            button53.Text = "1";
            button53.UseVisualStyleBackColor = false;
            button53.Click += EventClicksBtnsGrade;
            // 
            // button52
            // 
            button52.Anchor = AnchorStyles.None;
            button52.BackColor = SystemColors.InactiveCaption;
            button52.FlatAppearance.BorderSize = 0;
            button52.FlatStyle = FlatStyle.Flat;
            button52.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button52.Location = new Point(402, 207);
            button52.Name = "button52";
            button52.Size = new Size(35, 36);
            button52.TabIndex = 43;
            button52.Text = "1";
            button52.UseVisualStyleBackColor = false;
            button52.Click += EventClicksBtnsGrade;
            // 
            // button51
            // 
            button51.Anchor = AnchorStyles.None;
            button51.BackColor = SystemColors.InactiveCaption;
            button51.FlatAppearance.BorderSize = 0;
            button51.FlatStyle = FlatStyle.Flat;
            button51.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button51.Location = new Point(345, 207);
            button51.Name = "button51";
            button51.Size = new Size(35, 36);
            button51.TabIndex = 42;
            button51.Text = "1";
            button51.UseVisualStyleBackColor = false;
            button51.Click += EventClicksBtnsGrade;
            // 
            // button50
            // 
            button50.Anchor = AnchorStyles.None;
            button50.BackColor = SystemColors.InactiveCaption;
            button50.FlatAppearance.BorderSize = 0;
            button50.FlatStyle = FlatStyle.Flat;
            button50.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button50.Location = new Point(288, 207);
            button50.Name = "button50";
            button50.Size = new Size(35, 36);
            button50.TabIndex = 41;
            button50.Text = "1";
            button50.UseVisualStyleBackColor = false;
            button50.Click += EventClicksBtnsGrade;
            // 
            // button49
            // 
            button49.Anchor = AnchorStyles.None;
            button49.BackColor = SystemColors.InactiveCaption;
            button49.FlatAppearance.BorderSize = 0;
            button49.FlatStyle = FlatStyle.Flat;
            button49.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button49.Location = new Point(233, 207);
            button49.Name = "button49";
            button49.Size = new Size(35, 36);
            button49.TabIndex = 40;
            button49.Text = "1";
            button49.UseVisualStyleBackColor = false;
            button49.Click += EventClicksBtnsGrade;
            // 
            // button48
            // 
            button48.Anchor = AnchorStyles.None;
            button48.BackColor = SystemColors.InactiveCaption;
            button48.FlatAppearance.BorderSize = 0;
            button48.FlatStyle = FlatStyle.Flat;
            button48.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button48.Location = new Point(176, 207);
            button48.Name = "button48";
            button48.Size = new Size(35, 36);
            button48.TabIndex = 39;
            button48.Text = "1";
            button48.UseVisualStyleBackColor = false;
            button48.Click += EventClicksBtnsGrade;
            // 
            // button47
            // 
            button47.Anchor = AnchorStyles.None;
            button47.BackColor = SystemColors.InactiveCaption;
            button47.FlatAppearance.BorderSize = 0;
            button47.FlatStyle = FlatStyle.Flat;
            button47.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button47.Location = new Point(120, 207);
            button47.Name = "button47";
            button47.Size = new Size(35, 36);
            button47.TabIndex = 38;
            button47.Text = "1";
            button47.UseVisualStyleBackColor = false;
            button47.Click += EventClicksBtnsGrade;
            // 
            // button46
            // 
            button46.Anchor = AnchorStyles.None;
            button46.BackColor = SystemColors.InactiveCaption;
            button46.FlatAppearance.BorderSize = 0;
            button46.FlatStyle = FlatStyle.Flat;
            button46.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button46.Location = new Point(66, 207);
            button46.Name = "button46";
            button46.Size = new Size(35, 36);
            button46.TabIndex = 37;
            button46.Text = "1";
            button46.UseVisualStyleBackColor = false;
            button46.Click += EventClicksBtnsGrade;
            // 
            // button45
            // 
            button45.Anchor = AnchorStyles.None;
            button45.BackColor = SystemColors.InactiveCaption;
            button45.FlatAppearance.BorderSize = 0;
            button45.FlatStyle = FlatStyle.Flat;
            button45.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button45.Location = new Point(10, 207);
            button45.Name = "button45";
            button45.Size = new Size(35, 36);
            button45.TabIndex = 36;
            button45.Text = "1";
            button45.UseVisualStyleBackColor = false;
            button45.Click += EventClicksBtnsGrade;
            // 
            // button44
            // 
            button44.Anchor = AnchorStyles.None;
            button44.BackColor = SystemColors.InactiveCaption;
            button44.FlatAppearance.BorderSize = 0;
            button44.FlatStyle = FlatStyle.Flat;
            button44.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button44.Location = new Point(461, 157);
            button44.Name = "button44";
            button44.Size = new Size(32, 36);
            button44.TabIndex = 35;
            button44.Text = "1";
            button44.UseVisualStyleBackColor = false;
            button44.Click += EventClicksBtnsGrade;
            // 
            // button43
            // 
            button43.Anchor = AnchorStyles.None;
            button43.BackColor = SystemColors.InactiveCaption;
            button43.FlatAppearance.BorderSize = 0;
            button43.FlatStyle = FlatStyle.Flat;
            button43.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button43.Location = new Point(402, 157);
            button43.Name = "button43";
            button43.Size = new Size(35, 36);
            button43.TabIndex = 34;
            button43.Text = "1";
            button43.UseVisualStyleBackColor = false;
            button43.Click += EventClicksBtnsGrade;
            // 
            // button42
            // 
            button42.Anchor = AnchorStyles.None;
            button42.BackColor = SystemColors.InactiveCaption;
            button42.FlatAppearance.BorderSize = 0;
            button42.FlatStyle = FlatStyle.Flat;
            button42.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button42.Location = new Point(345, 157);
            button42.Name = "button42";
            button42.Size = new Size(35, 36);
            button42.TabIndex = 33;
            button42.Text = "1";
            button42.UseVisualStyleBackColor = false;
            button42.Click += EventClicksBtnsGrade;
            // 
            // button41
            // 
            button41.Anchor = AnchorStyles.None;
            button41.BackColor = SystemColors.InactiveCaption;
            button41.FlatAppearance.BorderSize = 0;
            button41.FlatStyle = FlatStyle.Flat;
            button41.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button41.Location = new Point(288, 157);
            button41.Name = "button41";
            button41.Size = new Size(35, 36);
            button41.TabIndex = 32;
            button41.Text = "1";
            button41.UseVisualStyleBackColor = false;
            button41.Click += EventClicksBtnsGrade;
            // 
            // button40
            // 
            button40.Anchor = AnchorStyles.None;
            button40.BackColor = SystemColors.InactiveCaption;
            button40.FlatAppearance.BorderSize = 0;
            button40.FlatStyle = FlatStyle.Flat;
            button40.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button40.Location = new Point(233, 157);
            button40.Name = "button40";
            button40.Size = new Size(35, 36);
            button40.TabIndex = 31;
            button40.Text = "1";
            button40.UseVisualStyleBackColor = false;
            button40.Click += EventClicksBtnsGrade;
            // 
            // button39
            // 
            button39.Anchor = AnchorStyles.None;
            button39.BackColor = SystemColors.InactiveCaption;
            button39.FlatAppearance.BorderSize = 0;
            button39.FlatStyle = FlatStyle.Flat;
            button39.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button39.Location = new Point(176, 157);
            button39.Name = "button39";
            button39.Size = new Size(35, 36);
            button39.TabIndex = 30;
            button39.Text = "1";
            button39.UseVisualStyleBackColor = false;
            button39.Click += EventClicksBtnsGrade;
            // 
            // button38
            // 
            button38.Anchor = AnchorStyles.None;
            button38.BackColor = SystemColors.InactiveCaption;
            button38.FlatAppearance.BorderSize = 0;
            button38.FlatStyle = FlatStyle.Flat;
            button38.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button38.Location = new Point(120, 157);
            button38.Name = "button38";
            button38.Size = new Size(35, 36);
            button38.TabIndex = 29;
            button38.Text = "1";
            button38.UseVisualStyleBackColor = false;
            button38.Click += EventClicksBtnsGrade;
            // 
            // button37
            // 
            button37.Anchor = AnchorStyles.None;
            button37.BackColor = SystemColors.InactiveCaption;
            button37.FlatAppearance.BorderSize = 0;
            button37.FlatStyle = FlatStyle.Flat;
            button37.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button37.Location = new Point(66, 157);
            button37.Name = "button37";
            button37.Size = new Size(35, 36);
            button37.TabIndex = 28;
            button37.Text = "1";
            button37.UseVisualStyleBackColor = false;
            button37.Click += EventClicksBtnsGrade;
            // 
            // button36
            // 
            button36.Anchor = AnchorStyles.None;
            button36.BackColor = SystemColors.InactiveCaption;
            button36.FlatAppearance.BorderSize = 0;
            button36.FlatStyle = FlatStyle.Flat;
            button36.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button36.Location = new Point(10, 157);
            button36.Name = "button36";
            button36.Size = new Size(35, 36);
            button36.TabIndex = 27;
            button36.Text = "1";
            button36.UseVisualStyleBackColor = false;
            button36.Click += EventClicksBtnsGrade;
            // 
            // button35
            // 
            button35.Anchor = AnchorStyles.None;
            button35.BackColor = SystemColors.InactiveCaption;
            button35.FlatAppearance.BorderSize = 0;
            button35.FlatStyle = FlatStyle.Flat;
            button35.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button35.Location = new Point(461, 107);
            button35.Name = "button35";
            button35.Size = new Size(32, 36);
            button35.TabIndex = 26;
            button35.Text = "1";
            button35.UseVisualStyleBackColor = false;
            button35.Click += EventClicksBtnsGrade;
            // 
            // button34
            // 
            button34.Anchor = AnchorStyles.None;
            button34.BackColor = SystemColors.InactiveCaption;
            button34.FlatAppearance.BorderSize = 0;
            button34.FlatStyle = FlatStyle.Flat;
            button34.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button34.Location = new Point(402, 107);
            button34.Name = "button34";
            button34.Size = new Size(35, 36);
            button34.TabIndex = 25;
            button34.Text = "1";
            button34.UseVisualStyleBackColor = false;
            button34.Click += EventClicksBtnsGrade;
            // 
            // button33
            // 
            button33.Anchor = AnchorStyles.None;
            button33.BackColor = SystemColors.InactiveCaption;
            button33.FlatAppearance.BorderSize = 0;
            button33.FlatStyle = FlatStyle.Flat;
            button33.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button33.Location = new Point(345, 107);
            button33.Name = "button33";
            button33.Size = new Size(35, 36);
            button33.TabIndex = 24;
            button33.Text = "1";
            button33.UseVisualStyleBackColor = false;
            button33.Click += EventClicksBtnsGrade;
            // 
            // button32
            // 
            button32.Anchor = AnchorStyles.None;
            button32.BackColor = SystemColors.InactiveCaption;
            button32.FlatAppearance.BorderSize = 0;
            button32.FlatStyle = FlatStyle.Flat;
            button32.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button32.Location = new Point(288, 107);
            button32.Name = "button32";
            button32.Size = new Size(35, 36);
            button32.TabIndex = 23;
            button32.Text = "1";
            button32.UseVisualStyleBackColor = false;
            button32.Click += EventClicksBtnsGrade;
            // 
            // button31
            // 
            button31.Anchor = AnchorStyles.None;
            button31.BackColor = SystemColors.InactiveCaption;
            button31.FlatAppearance.BorderSize = 0;
            button31.FlatStyle = FlatStyle.Flat;
            button31.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button31.Location = new Point(233, 107);
            button31.Name = "button31";
            button31.Size = new Size(35, 36);
            button31.TabIndex = 22;
            button31.Text = "1";
            button31.UseVisualStyleBackColor = false;
            button31.Click += EventClicksBtnsGrade;
            // 
            // button30
            // 
            button30.Anchor = AnchorStyles.None;
            button30.BackColor = SystemColors.InactiveCaption;
            button30.FlatAppearance.BorderSize = 0;
            button30.FlatStyle = FlatStyle.Flat;
            button30.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button30.Location = new Point(176, 107);
            button30.Name = "button30";
            button30.Size = new Size(35, 36);
            button30.TabIndex = 21;
            button30.Text = "1";
            button30.UseVisualStyleBackColor = false;
            button30.Click += EventClicksBtnsGrade;
            // 
            // button29
            // 
            button29.Anchor = AnchorStyles.None;
            button29.BackColor = SystemColors.InactiveCaption;
            button29.FlatAppearance.BorderSize = 0;
            button29.FlatStyle = FlatStyle.Flat;
            button29.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button29.Location = new Point(120, 107);
            button29.Name = "button29";
            button29.Size = new Size(35, 36);
            button29.TabIndex = 20;
            button29.Text = "1";
            button29.UseVisualStyleBackColor = false;
            button29.Click += EventClicksBtnsGrade;
            // 
            // button28
            // 
            button28.Anchor = AnchorStyles.None;
            button28.BackColor = SystemColors.InactiveCaption;
            button28.FlatAppearance.BorderSize = 0;
            button28.FlatStyle = FlatStyle.Flat;
            button28.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button28.Location = new Point(66, 107);
            button28.Name = "button28";
            button28.Size = new Size(35, 36);
            button28.TabIndex = 19;
            button28.Text = "1";
            button28.UseVisualStyleBackColor = false;
            button28.Click += EventClicksBtnsGrade;
            // 
            // button27
            // 
            button27.Anchor = AnchorStyles.None;
            button27.BackColor = SystemColors.InactiveCaption;
            button27.FlatAppearance.BorderSize = 0;
            button27.FlatStyle = FlatStyle.Flat;
            button27.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button27.Location = new Point(10, 107);
            button27.Name = "button27";
            button27.Size = new Size(35, 36);
            button27.TabIndex = 18;
            button27.Text = "1";
            button27.UseVisualStyleBackColor = false;
            button27.Click += EventClicksBtnsGrade;
            // 
            // button26
            // 
            button26.Anchor = AnchorStyles.None;
            button26.BackColor = SystemColors.InactiveCaption;
            button26.FlatAppearance.BorderSize = 0;
            button26.FlatStyle = FlatStyle.Flat;
            button26.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button26.Location = new Point(461, 57);
            button26.Name = "button26";
            button26.Size = new Size(32, 36);
            button26.TabIndex = 17;
            button26.Text = "1";
            button26.UseVisualStyleBackColor = false;
            button26.Click += EventClicksBtnsGrade;
            // 
            // button25
            // 
            button25.Anchor = AnchorStyles.None;
            button25.BackColor = SystemColors.InactiveCaption;
            button25.FlatAppearance.BorderSize = 0;
            button25.FlatStyle = FlatStyle.Flat;
            button25.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button25.Location = new Point(402, 57);
            button25.Name = "button25";
            button25.Size = new Size(35, 36);
            button25.TabIndex = 16;
            button25.Text = "1";
            button25.UseVisualStyleBackColor = false;
            button25.Click += EventClicksBtnsGrade;
            // 
            // button24
            // 
            button24.Anchor = AnchorStyles.None;
            button24.BackColor = SystemColors.InactiveCaption;
            button24.FlatAppearance.BorderSize = 0;
            button24.FlatStyle = FlatStyle.Flat;
            button24.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button24.Location = new Point(345, 57);
            button24.Name = "button24";
            button24.Size = new Size(35, 36);
            button24.TabIndex = 15;
            button24.Text = "1";
            button24.UseVisualStyleBackColor = false;
            button24.Click += EventClicksBtnsGrade;
            // 
            // button23
            // 
            button23.Anchor = AnchorStyles.None;
            button23.BackColor = SystemColors.InactiveCaption;
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatStyle = FlatStyle.Flat;
            button23.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button23.Location = new Point(288, 57);
            button23.Name = "button23";
            button23.Size = new Size(35, 36);
            button23.TabIndex = 14;
            button23.Text = "1";
            button23.UseVisualStyleBackColor = false;
            button23.Click += EventClicksBtnsGrade;
            // 
            // button22
            // 
            button22.Anchor = AnchorStyles.None;
            button22.BackColor = SystemColors.InactiveCaption;
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button22.Location = new Point(233, 57);
            button22.Name = "button22";
            button22.Size = new Size(35, 36);
            button22.TabIndex = 13;
            button22.Text = "1";
            button22.UseVisualStyleBackColor = false;
            button22.Click += EventClicksBtnsGrade;
            // 
            // button21
            // 
            button21.Anchor = AnchorStyles.None;
            button21.BackColor = SystemColors.InactiveCaption;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button21.Location = new Point(176, 57);
            button21.Name = "button21";
            button21.Size = new Size(35, 36);
            button21.TabIndex = 12;
            button21.Text = "1";
            button21.UseVisualStyleBackColor = false;
            button21.Click += EventClicksBtnsGrade;
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.None;
            button20.BackColor = SystemColors.InactiveCaption;
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button20.Location = new Point(120, 57);
            button20.Name = "button20";
            button20.Size = new Size(35, 36);
            button20.TabIndex = 11;
            button20.Text = "1";
            button20.UseVisualStyleBackColor = false;
            button20.Click += EventClicksBtnsGrade;
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.None;
            button19.BackColor = SystemColors.InactiveCaption;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button19.Location = new Point(66, 57);
            button19.Name = "button19";
            button19.Size = new Size(35, 36);
            button19.TabIndex = 10;
            button19.Text = "1";
            button19.UseVisualStyleBackColor = false;
            button19.Click += EventClicksBtnsGrade;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.None;
            button18.BackColor = SystemColors.InactiveCaption;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button18.Location = new Point(10, 57);
            button18.Name = "button18";
            button18.Size = new Size(35, 36);
            button18.TabIndex = 9;
            button18.Text = "1";
            button18.UseVisualStyleBackColor = false;
            button18.Click += EventClicksBtnsGrade;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.None;
            button17.BackColor = SystemColors.InactiveCaption;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button17.Location = new Point(461, 7);
            button17.Name = "button17";
            button17.Size = new Size(32, 36);
            button17.TabIndex = 8;
            button17.Text = "1";
            button17.UseVisualStyleBackColor = false;
            button17.Click += EventClicksBtnsGrade;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.None;
            button16.BackColor = SystemColors.InactiveCaption;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button16.Location = new Point(402, 7);
            button16.Name = "button16";
            button16.Size = new Size(35, 36);
            button16.TabIndex = 7;
            button16.Text = "1";
            button16.UseVisualStyleBackColor = false;
            button16.Click += EventClicksBtnsGrade;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.None;
            button15.BackColor = SystemColors.InactiveCaption;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button15.Location = new Point(345, 7);
            button15.Name = "button15";
            button15.Size = new Size(35, 36);
            button15.TabIndex = 6;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = false;
            button15.Click += EventClicksBtnsGrade;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.None;
            button14.BackColor = SystemColors.InactiveCaption;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button14.Location = new Point(288, 7);
            button14.Name = "button14";
            button14.Size = new Size(35, 36);
            button14.TabIndex = 5;
            button14.Text = "1";
            button14.UseVisualStyleBackColor = false;
            button14.Click += EventClicksBtnsGrade;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.None;
            button13.BackColor = SystemColors.InactiveCaption;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button13.Location = new Point(233, 7);
            button13.Name = "button13";
            button13.Size = new Size(35, 36);
            button13.TabIndex = 4;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = false;
            button13.Click += EventClicksBtnsGrade;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = SystemColors.InactiveCaption;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.Location = new Point(176, 7);
            button6.Name = "button6";
            button6.Size = new Size(35, 36);
            button6.TabIndex = 3;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = false;
            button6.Click += EventClicksBtnsGrade;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = SystemColors.InactiveCaption;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button5.Location = new Point(120, 7);
            button5.Name = "button5";
            button5.Size = new Size(35, 36);
            button5.TabIndex = 2;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = false;
            button5.Click += EventClicksBtnsGrade;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.InactiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(66, 7);
            button2.Name = "button2";
            button2.Size = new Size(35, 36);
            button2.TabIndex = 1;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += EventClicksBtnsGrade;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.InactiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(10, 7);
            button1.Name = "button1";
            button1.Size = new Size(35, 36);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += EventClicksBtnsGrade;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.CadetBlue;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnCancel.Location = new Point(77, 471);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(360, 45);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Sair";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += EventClickButtonRouds;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 542);
            Controls.Add(TlpMenu);
            Controls.Add(tplRoud);
            Name = "Form1";
            Text = "Sudokku";
            TlpMenu.ResumeLayout(false);
            tplRoud.ResumeLayout(false);
            tplRoud.PerformLayout();
            pnlDiigits.ResumeLayout(false);
            tlpMatrix.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpMenu;
        private Button btnFacil;
        private Button btnMedio;
        private Button btnDificil;
        private TableLayoutPanel tplRoud;
        private Panel pnlDiigits;
        private Button btnVerify;
        private Button btnCancel;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label lbTentativas;
        private Label lbTrySudokku;
        private TableLayoutPanel tlpMatrix;
        private Button button90;
        private Button button89;
        private Button button88;
        private Button button87;
        private Button button86;
        private Button button85;
        private Button button84;
        private Button button83;
        private Button button82;
        private Button button81;
        private Button button80;
        private Button button79;
        private Button button78;
        private Button button77;
        private Button button76;
        private Button button75;
        private Button button74;
        private Button button73;
        private Button button72;
        private Button button71;
        private Button button70;
        private Button button69;
        private Button button68;
        private Button button67;
        private Button button66;
        private Button button65;
        private Button button64;
        private Button button63;
        private Button button62;
        private Button button61;
        private Button button60;
        private Button button59;
        private Button button58;
        private Button button57;
        private Button button56;
        private Button button55;
        private Button button54;
        private Button button53;
        private Button button52;
        private Button button51;
        private Button button50;
        private Button button49;
        private Button button48;
        private Button button47;
        private Button button46;
        private Button button45;
        private Button button44;
        private Button button43;
        private Button button42;
        private Button button41;
        private Button button40;
        private Button button39;
        private Button button38;
        private Button button37;
        private Button button36;
        private Button button35;
        private Button button34;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button28;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button6;
        private Button button5;
        private Button button2;
    }
}
