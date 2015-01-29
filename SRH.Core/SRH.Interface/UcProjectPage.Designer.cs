namespace SRH.Interface
{
    partial class UcProjectPage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.availableSkillsTitle = new System.Windows.Forms.Label();
            this.requiredSkillsTitle = new System.Windows.Forms.Label();
            this.possibleProjectsTitle = new System.Windows.Forms.Label();
            this.currentProjectsTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listCurrentProjects = new System.Windows.Forms.ListView();
            this.currentProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Earnings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPossibleProjects = new System.Windows.Forms.ListView();
            this.Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevelRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EarningsExpected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this._projectNameText = new System.Windows.Forms.Label();
            this.projectProgressBar = new System.Windows.Forms.ProgressBar();
            this.Difficulty = new System.Windows.Forms.Label();
            this._startOrStopProject = new System.Windows.Forms.Button();
            this._difficulty = new System.Windows.Forms.Label();
            this._numberOfWorkers = new System.Windows.Forms.Label();
            this.EarningsText = new System.Windows.Forms.Label();
            this.NumberOfWorkers = new System.Windows.Forms.Label();
            this._earnings = new System.Windows.Forms.Label();
            this._estimatedTime = new System.Windows.Forms.Label();
            this.EstimatedTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listSkillsAvailable = new System.Windows.Forms.ListView();
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeSkill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.affectEmployee = new System.Windows.Forms.Button();
            this.listSkillsRequired = new System.Windows.Forms.ListView();
            this.ProjectEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectSkillRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectLevelRecommanded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desaffectEmployee = new System.Windows.Forms.Button();
            this._infoPossibleProjects = new System.Windows.Forms.ToolTip(this.components);
            this._infoProjects = new System.Windows.Forms.ToolTip(this.components);
            this._infoSkillRequired = new System.Windows.Forms.ToolTip(this.components);
            this._infoSkillAvailable = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // availableSkillsTitle
            // 
            this.availableSkillsTitle.AutoSize = true;
            this.availableSkillsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableSkillsTitle.Location = new System.Drawing.Point(468, 0);
            this.availableSkillsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availableSkillsTitle.Name = "availableSkillsTitle";
            this.availableSkillsTitle.Size = new System.Drawing.Size(260, 25);
            this.availableSkillsTitle.TabIndex = 37;
            this.availableSkillsTitle.Text = "Compétences disponibles";
            // 
            // requiredSkillsTitle
            // 
            this.requiredSkillsTitle.AutoSize = true;
            this.requiredSkillsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredSkillsTitle.Location = new System.Drawing.Point(4, 0);
            this.requiredSkillsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredSkillsTitle.Name = "requiredSkillsTitle";
            this.requiredSkillsTitle.Size = new System.Drawing.Size(267, 25);
            this.requiredSkillsTitle.TabIndex = 38;
            this.requiredSkillsTitle.Text = "Compétences nécessaires";
            // 
            // possibleProjectsTitle
            // 
            this.possibleProjectsTitle.AutoSize = true;
            this.possibleProjectsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possibleProjectsTitle.Location = new System.Drawing.Point(4, 0);
            this.possibleProjectsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.possibleProjectsTitle.Name = "possibleProjectsTitle";
            this.possibleProjectsTitle.Size = new System.Drawing.Size(176, 25);
            this.possibleProjectsTitle.TabIndex = 39;
            this.possibleProjectsTitle.Text = "Projets possibles";
            // 
            // currentProjectsTitle
            // 
            this.currentProjectsTitle.AutoSize = true;
            this.currentProjectsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProjectsTitle.Location = new System.Drawing.Point(4, 321);
            this.currentProjectsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentProjectsTitle.Name = "currentProjectsTitle";
            this.currentProjectsTitle.Size = new System.Drawing.Size(168, 25);
            this.currentProjectsTitle.TabIndex = 40;
            this.currentProjectsTitle.Text = "Projets en cours";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1395, 758);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.currentProjectsTitle, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.possibleProjectsTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listCurrentProjects, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.listPossibleProjects, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.60714F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.39286F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 758);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listCurrentProjects
            // 
            this.listCurrentProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listCurrentProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.currentProject,
            this.Level,
            this.Earnings,
            this.TimeLeft});
            this.listCurrentProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCurrentProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listCurrentProjects.FullRowSelect = true;
            this.listCurrentProjects.Location = new System.Drawing.Point(4, 355);
            this.listCurrentProjects.Margin = new System.Windows.Forms.Padding(4);
            this.listCurrentProjects.Name = "listCurrentProjects";
            this.listCurrentProjects.Size = new System.Drawing.Size(453, 399);
            this.listCurrentProjects.TabIndex = 0;
            this.listCurrentProjects.UseCompatibleStateImageBehavior = false;
            this.listCurrentProjects.View = System.Windows.Forms.View.Details;
            this.listCurrentProjects.SelectedIndexChanged += new System.EventHandler(this.listCurrentProjects_SelectedIndexChanged);
            // 
            // currentProject
            // 
            this.currentProject.Text = "Projet";
            this.currentProject.Width = 110;
            // 
            // Level
            // 
            this.Level.Text = "Niveau";
            this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Level.Width = 85;
            // 
            // Earnings
            // 
            this.Earnings.Text = "Gain";
            this.Earnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Earnings.Width = 85;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Text = "Temps restant";
            this.TimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeLeft.Width = 105;
            // 
            // listPossibleProjects
            // 
            this.listPossibleProjects.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listPossibleProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPossibleProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Project,
            this.LevelRequired,
            this.EarningsExpected,
            this.Time});
            this.listPossibleProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPossibleProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listPossibleProjects.FullRowSelect = true;
            this.listPossibleProjects.Location = new System.Drawing.Point(4, 35);
            this.listPossibleProjects.Margin = new System.Windows.Forms.Padding(4);
            this.listPossibleProjects.Name = "listPossibleProjects";
            this.listPossibleProjects.Size = new System.Drawing.Size(453, 282);
            this.listPossibleProjects.TabIndex = 0;
            this.listPossibleProjects.UseCompatibleStateImageBehavior = false;
            this.listPossibleProjects.View = System.Windows.Forms.View.Details;
           // this.listPossibleProjects.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPossibleProjects_ColumnClick);
            this.listPossibleProjects.SelectedIndexChanged += new System.EventHandler(this.listPossibleProjects_SelectedIndexChanged);
            // 
            // Project
            // 
            this.Project.Text = "Projet proposés";
            this.Project.Width = 110;
            // 
            // LevelRequired
            // 
            this.LevelRequired.Text = "Niveau";
            this.LevelRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LevelRequired.Width = 85;
            // 
            // EarningsExpected
            // 
            this.EarningsExpected.Text = "Gain";
            this.EarningsExpected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EarningsExpected.Width = 85;
            // 
            // Time
            // 
            this.Time.Text = "Temps";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 85;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this._projectNameText);
            this.splitContainer3.Panel1.Controls.Add(this.projectProgressBar);
            this.splitContainer3.Panel1.Controls.Add(this.Difficulty);
            this.splitContainer3.Panel1.Controls.Add(this._startOrStopProject);
            this.splitContainer3.Panel1.Controls.Add(this._difficulty);
            this.splitContainer3.Panel1.Controls.Add(this._numberOfWorkers);
            this.splitContainer3.Panel1.Controls.Add(this.EarningsText);
            this.splitContainer3.Panel1.Controls.Add(this.NumberOfWorkers);
            this.splitContainer3.Panel1.Controls.Add(this._earnings);
            this.splitContainer3.Panel1.Controls.Add(this._estimatedTime);
            this.splitContainer3.Panel1.Controls.Add(this.EstimatedTime);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer3.Size = new System.Drawing.Size(929, 758);
            this.splitContainer3.SplitterDistance = 322;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 15;
            // 
            // _projectNameText
            // 
            this._projectNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._projectNameText.AutoSize = true;
            this._projectNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._projectNameText.Location = new System.Drawing.Point(421, 14);
            this._projectNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._projectNameText.Name = "_projectNameText";
            this._projectNameText.Size = new System.Drawing.Size(146, 25);
            this._projectNameText.TabIndex = 2;
            this._projectNameText.Text = "Nom du projet";
            this._projectNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectProgressBar
            // 
            this.projectProgressBar.Location = new System.Drawing.Point(121, 209);
            this.projectProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectProgressBar.Name = "projectProgressBar";
            this.projectProgressBar.Size = new System.Drawing.Size(659, 23);
            this.projectProgressBar.TabIndex = 13;
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSize = true;
            this.Difficulty.Location = new System.Drawing.Point(117, 71);
            this.Difficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(134, 17);
            this.Difficulty.TabIndex = 3;
            this.Difficulty.Text = "Difficulté du projet : ";
            // 
            // _startOrStopProject
            // 
            this._startOrStopProject.Enabled = false;
            this._startOrStopProject.Location = new System.Drawing.Point(615, 46);
            this._startOrStopProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._startOrStopProject.Name = "_startOrStopProject";
            this._startOrStopProject.Size = new System.Drawing.Size(164, 23);
            this._startOrStopProject.TabIndex = 11;
            this._startOrStopProject.Text = "Action sur projet";
            this._startOrStopProject.UseVisualStyleBackColor = true;
            this._startOrStopProject.Click += new System.EventHandler(this._startOrStopProject_Click);
            // 
            // _difficulty
            // 
            this._difficulty.AutoSize = true;
            this._difficulty.Location = new System.Drawing.Point(323, 71);
            this._difficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._difficulty.Name = "_difficulty";
            this._difficulty.Size = new System.Drawing.Size(17, 17);
            this._difficulty.TabIndex = 4;
            this._difficulty.Text = "X";
            // 
            // _numberOfWorkers
            // 
            this._numberOfWorkers.AutoSize = true;
            this._numberOfWorkers.Location = new System.Drawing.Point(323, 165);
            this._numberOfWorkers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._numberOfWorkers.Name = "_numberOfWorkers";
            this._numberOfWorkers.Size = new System.Drawing.Size(17, 17);
            this._numberOfWorkers.TabIndex = 10;
            this._numberOfWorkers.Text = "X";
            // 
            // EarningsText
            // 
            this.EarningsText.AutoSize = true;
            this.EarningsText.Location = new System.Drawing.Point(117, 98);
            this.EarningsText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EarningsText.Name = "EarningsText";
            this.EarningsText.Size = new System.Drawing.Size(50, 17);
            this.EarningsText.TabIndex = 5;
            this.EarningsText.Text = "Gain : ";
            // 
            // NumberOfWorkers
            // 
            this.NumberOfWorkers.AutoSize = true;
            this.NumberOfWorkers.Location = new System.Drawing.Point(117, 165);
            this.NumberOfWorkers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfWorkers.Name = "NumberOfWorkers";
            this.NumberOfWorkers.Size = new System.Drawing.Size(152, 17);
            this.NumberOfWorkers.TabIndex = 9;
            this.NumberOfWorkers.Text = "Nombre de membres : ";
            // 
            // _earnings
            // 
            this._earnings.AutoSize = true;
            this._earnings.Location = new System.Drawing.Point(323, 98);
            this._earnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._earnings.Name = "_earnings";
            this._earnings.Size = new System.Drawing.Size(17, 17);
            this._earnings.TabIndex = 6;
            this._earnings.Text = "X";
            // 
            // _estimatedTime
            // 
            this._estimatedTime.AutoSize = true;
            this._estimatedTime.Location = new System.Drawing.Point(323, 129);
            this._estimatedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._estimatedTime.Name = "_estimatedTime";
            this._estimatedTime.Size = new System.Drawing.Size(17, 17);
            this._estimatedTime.TabIndex = 8;
            this._estimatedTime.Text = "X";
            // 
            // EstimatedTime
            // 
            this.EstimatedTime.AutoSize = true;
            this.EstimatedTime.Location = new System.Drawing.Point(117, 129);
            this.EstimatedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.Size = new System.Drawing.Size(108, 17);
            this.EstimatedTime.TabIndex = 7;
            this.EstimatedTime.Text = "Temps estimé : ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.requiredSkillsTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listSkillsAvailable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.affectEmployee, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listSkillsRequired, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.desaffectEmployee, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.availableSkillsTitle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listSkillsAvailable
            // 
            this.listSkillsAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listSkillsAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeName,
            this.EmployeeSkill,
            this.EmployeeLevel});
            this.listSkillsAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSkillsAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listSkillsAvailable.FullRowSelect = true;
            this.listSkillsAvailable.Location = new System.Drawing.Point(467, 33);
            this.listSkillsAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSkillsAvailable.Name = "listSkillsAvailable";
            this.listSkillsAvailable.Size = new System.Drawing.Size(459, 359);
            this.listSkillsAvailable.TabIndex = 0;
            this.listSkillsAvailable.UseCompatibleStateImageBehavior = false;
            this.listSkillsAvailable.View = System.Windows.Forms.View.Details;
            this.listSkillsAvailable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSkillsAvailable_MouseDoubleClick);
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Nom de l\'employée";
            this.EmployeeName.Width = 152;
            // 
            // EmployeeSkill
            // 
            this.EmployeeSkill.Text = "Compétence";
            this.EmployeeSkill.Width = 106;
            // 
            // EmployeeLevel
            // 
            this.EmployeeLevel.Text = "Niveau";
            this.EmployeeLevel.Width = 106;
            // 
            // affectEmployee
            // 
            this.affectEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.affectEmployee.Location = new System.Drawing.Point(801, 398);
            this.affectEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.affectEmployee.Name = "affectEmployee";
            this.affectEmployee.Size = new System.Drawing.Size(124, 27);
            this.affectEmployee.TabIndex = 1;
            this.affectEmployee.Text = "Affecter";
            this.affectEmployee.UseVisualStyleBackColor = true;
            this.affectEmployee.Click += new System.EventHandler(this.affectEmployee_Click);
            // 
            // listSkillsRequired
            // 
            this.listSkillsRequired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listSkillsRequired.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectEmployeeName,
            this.ProjectSkillRequired,
            this.ProjectLevelRecommanded});
            this.listSkillsRequired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSkillsRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listSkillsRequired.FullRowSelect = true;
            this.listSkillsRequired.Location = new System.Drawing.Point(3, 33);
            this.listSkillsRequired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSkillsRequired.Name = "listSkillsRequired";
            this.listSkillsRequired.Size = new System.Drawing.Size(458, 359);
            this.listSkillsRequired.TabIndex = 0;
            this.listSkillsRequired.UseCompatibleStateImageBehavior = false;
            this.listSkillsRequired.View = System.Windows.Forms.View.Details;
            this.listSkillsRequired.SelectedIndexChanged += new System.EventHandler(this.listSkillsRequired_SelectedIndexChanged);
            this.listSkillsRequired.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSkillsRequired_MouseDoubleClick);
            // 
            // ProjectEmployeeName
            // 
            this.ProjectEmployeeName.Text = "Nom de l\'employée";
            this.ProjectEmployeeName.Width = 97;
            // 
            // ProjectSkillRequired
            // 
            this.ProjectSkillRequired.Text = "Compétence";
            this.ProjectSkillRequired.Width = 144;
            // 
            // ProjectLevelRecommanded
            // 
            this.ProjectLevelRecommanded.Text = "Niveau réel (recommandé)";
            this.ProjectLevelRecommanded.Width = 205;
            // 
            // desaffectEmployee
            // 
            this.desaffectEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.desaffectEmployee.Location = new System.Drawing.Point(336, 398);
            this.desaffectEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.desaffectEmployee.Name = "desaffectEmployee";
            this.desaffectEmployee.Size = new System.Drawing.Size(124, 27);
            this.desaffectEmployee.TabIndex = 0;
            this.desaffectEmployee.Text = "Désaffecter";
            this.desaffectEmployee.UseVisualStyleBackColor = true;
            this.desaffectEmployee.Click += new System.EventHandler(this.desaffectEmployee_Click);
            // 
            // _infoPossibleProjects
            // 
            this._infoPossibleProjects.AutoPopDelay = 3000;
            this._infoPossibleProjects.InitialDelay = 1700;
            this._infoPossibleProjects.IsBalloon = true;
            this._infoPossibleProjects.ReshowDelay = 100;
            this._infoPossibleProjects.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._infoPossibleProjects.ToolTipTitle = "Liste des projets possible";
            // 
            // _infoProjects
            // 
            this._infoProjects.AutoPopDelay = 3000;
            this._infoProjects.InitialDelay = 1700;
            this._infoProjects.IsBalloon = true;
            this._infoProjects.ReshowDelay = 100;
            this._infoProjects.ToolTipTitle = "Liste des projets en cours";
            // 
            // _infoSkillRequired
            // 
            this._infoSkillRequired.AutomaticDelay = 1000;
            this._infoSkillRequired.AutoPopDelay = 50000;
            this._infoSkillRequired.InitialDelay = 200;
            this._infoSkillRequired.IsBalloon = true;
            this._infoSkillRequired.ReshowDelay = 200;
            this._infoSkillRequired.ToolTipTitle = "Compétences nécessaires";
            // 
            // _infoSkillAvailable
            // 
            this._infoSkillAvailable.AutomaticDelay = 1000;
            this._infoSkillAvailable.AutoPopDelay = 50000;
            this._infoSkillAvailable.InitialDelay = 200;
            this._infoSkillAvailable.IsBalloon = true;
            this._infoSkillAvailable.ReshowDelay = 200;
            this._infoSkillAvailable.ToolTipTitle = "Compétences disponibles";
            // 
            // UcProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcProjectPage";
            this.Size = new System.Drawing.Size(1395, 758);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader Project;
        private System.Windows.Forms.ColumnHeader LevelRequired;
        private System.Windows.Forms.ColumnHeader EarningsExpected;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader currentProject;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Earnings;
        private System.Windows.Forms.ColumnHeader TimeLeft;
        private System.Windows.Forms.Label _projectNameText;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Label _difficulty;
        private System.Windows.Forms.Label EarningsText;
        private System.Windows.Forms.Label _earnings;
        private System.Windows.Forms.Label EstimatedTime;
        private System.Windows.Forms.Label _estimatedTime;
        private System.Windows.Forms.Label NumberOfWorkers;
        private System.Windows.Forms.Label _numberOfWorkers;
		private System.Windows.Forms.Button _startOrStopProject;
        private System.Windows.Forms.ColumnHeader ProjectEmployeeName;
        private System.Windows.Forms.ColumnHeader ProjectSkillRequired;
        private System.Windows.Forms.ColumnHeader ProjectLevelRecommanded;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader EmployeeSkill;
        private System.Windows.Forms.ColumnHeader EmployeeLevel;
        public System.Windows.Forms.ListView listCurrentProjects;
        public System.Windows.Forms.ListView listSkillsRequired;
        public System.Windows.Forms.ListView listSkillsAvailable;
		private System.Windows.Forms.ProgressBar projectProgressBar;
		private System.Windows.Forms.Button affectEmployee;
        private System.Windows.Forms.Button desaffectEmployee;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolTip _infoPossibleProjects;
        private System.Windows.Forms.ToolTip _infoProjects;
        public System.Windows.Forms.ListView listPossibleProjects;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label availableSkillsTitle;
        private System.Windows.Forms.Label requiredSkillsTitle;
        private System.Windows.Forms.Label possibleProjectsTitle;
        private System.Windows.Forms.Label currentProjectsTitle;
        private System.Windows.Forms.ToolTip _infoSkillRequired;
        private System.Windows.Forms.ToolTip _infoSkillAvailable;

    }
}
