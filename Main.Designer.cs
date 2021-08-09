
namespace Media_Player
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.App = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.mainArea = new Bunifu.UI.WinForms.BunifuPanel();
            this.sideBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.songs = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.topBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.minimize = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.albums = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.artists = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.player = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.songTime = new Bunifu.UI.WinForms.BunifuHSlider();
            this.nowPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.App.SuspendLayout();
            this.mainArea.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.topBar.SuspendLayout();
            this.player.SuspendLayout();
            this.SuspendLayout();
            // 
            // App
            // 
            this.App.BackColor = System.Drawing.Color.Transparent;
            this.App.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("App.BackgroundImage")));
            this.App.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.App.BorderRadius = 1;
            this.App.Controls.Add(this.mainArea);
            this.App.Controls.Add(this.sideBar);
            this.App.Controls.Add(this.topBar);
            this.App.Dock = System.Windows.Forms.DockStyle.Fill;
            this.App.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.App.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.App.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.App.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.App.Location = new System.Drawing.Point(0, 0);
            this.App.Margin = new System.Windows.Forms.Padding(4);
            this.App.Name = "App";
            this.App.Quality = 10;
            this.App.Size = new System.Drawing.Size(1208, 657);
            this.App.TabIndex = 0;
            // 
            // mainArea
            // 
            this.mainArea.BackgroundColor = System.Drawing.Color.Transparent;
            this.mainArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainArea.BackgroundImage")));
            this.mainArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainArea.BorderColor = System.Drawing.Color.Transparent;
            this.mainArea.BorderRadius = 3;
            this.mainArea.BorderThickness = 1;
            this.mainArea.Controls.Add(this.player);
            this.mainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainArea.Location = new System.Drawing.Point(228, 34);
            this.mainArea.Margin = new System.Windows.Forms.Padding(4);
            this.mainArea.Name = "mainArea";
            this.mainArea.ShowBorders = false;
            this.mainArea.Size = new System.Drawing.Size(980, 623);
            this.mainArea.TabIndex = 2;
            // 
            // sideBar
            // 
            this.sideBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.sideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideBar.BackgroundImage")));
            this.sideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideBar.BorderColor = System.Drawing.Color.Transparent;
            this.sideBar.BorderRadius = 3;
            this.sideBar.BorderThickness = 1;
            this.sideBar.Controls.Add(this.artists);
            this.sideBar.Controls.Add(this.albums);
            this.sideBar.Controls.Add(this.nowPlaying);
            this.sideBar.Controls.Add(this.songs);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 34);
            this.sideBar.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar.Name = "sideBar";
            this.sideBar.ShowBorders = false;
            this.sideBar.Size = new System.Drawing.Size(228, 623);
            this.sideBar.TabIndex = 1;
            // 
            // songs
            // 
            this.songs.AllowAnimations = true;
            this.songs.AllowMouseEffects = true;
            this.songs.AllowToggling = false;
            this.songs.AnimationSpeed = 200;
            this.songs.AutoGenerateColors = false;
            this.songs.AutoRoundBorders = false;
            this.songs.AutoSizeLeftIcon = true;
            this.songs.AutoSizeRightIcon = true;
            this.songs.BackColor = System.Drawing.Color.Transparent;
            this.songs.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.songs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songs.BackgroundImage")));
            this.songs.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.songs.ButtonText = "Songs";
            this.songs.ButtonTextMarginLeft = 0;
            this.songs.ColorContrastOnClick = 45;
            this.songs.ColorContrastOnHover = 45;
            this.songs.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.songs.CustomizableEdges = borderEdges4;
            this.songs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.songs.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.songs.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.songs.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.songs.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.songs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songs.ForeColor = System.Drawing.Color.White;
            this.songs.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songs.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.songs.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.songs.IconMarginLeft = 11;
            this.songs.IconPadding = 10;
            this.songs.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.songs.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.songs.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.songs.IconSize = 25;
            this.songs.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.songs.IdleBorderRadius = 1;
            this.songs.IdleBorderThickness = 1;
            this.songs.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.songs.IdleIconLeftImage = null;
            this.songs.IdleIconRightImage = null;
            this.songs.IndicateFocus = false;
            this.songs.Location = new System.Drawing.Point(0, 73);
            this.songs.Name = "songs";
            this.songs.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.songs.OnDisabledState.BorderRadius = 0;
            this.songs.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.songs.OnDisabledState.BorderThickness = 1;
            this.songs.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.songs.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.songs.OnDisabledState.IconLeftImage = null;
            this.songs.OnDisabledState.IconRightImage = null;
            this.songs.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.songs.onHoverState.BorderRadius = 0;
            this.songs.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.songs.onHoverState.BorderThickness = 1;
            this.songs.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.songs.onHoverState.ForeColor = System.Drawing.Color.White;
            this.songs.onHoverState.IconLeftImage = null;
            this.songs.onHoverState.IconRightImage = null;
            this.songs.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.songs.OnIdleState.BorderRadius = 0;
            this.songs.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.songs.OnIdleState.BorderThickness = 1;
            this.songs.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.songs.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.songs.OnIdleState.IconLeftImage = null;
            this.songs.OnIdleState.IconRightImage = null;
            this.songs.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.songs.OnPressedState.BorderRadius = 0;
            this.songs.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.songs.OnPressedState.BorderThickness = 1;
            this.songs.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.songs.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.songs.OnPressedState.IconLeftImage = null;
            this.songs.OnPressedState.IconRightImage = null;
            this.songs.Size = new System.Drawing.Size(228, 47);
            this.songs.TabIndex = 0;
            this.songs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songs.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.songs.TextMarginLeft = 0;
            this.songs.TextPadding = new System.Windows.Forms.Padding(0);
            this.songs.UseDefaultRadiusAndThickness = true;
            // 
            // topBar
            // 
            this.topBar.BackgroundColor = System.Drawing.Color.Transparent;
            this.topBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBar.BackgroundImage")));
            this.topBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBar.BorderColor = System.Drawing.Color.Transparent;
            this.topBar.BorderRadius = 3;
            this.topBar.BorderThickness = 1;
            this.topBar.Controls.Add(this.minimize);
            this.topBar.Controls.Add(this.maximize);
            this.topBar.Controls.Add(this.close);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(4);
            this.topBar.Name = "topBar";
            this.topBar.ShowBorders = false;
            this.topBar.Size = new System.Drawing.Size(1208, 34);
            this.topBar.TabIndex = 0;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.Location = new System.Drawing.Point(1073, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(41, 34);
            this.minimize.TabIndex = 0;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.Location = new System.Drawing.Point(1120, 0);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(41, 34);
            this.maximize.TabIndex = 0;
            this.maximize.Text = "^";
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(1167, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 34);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // albums
            // 
            this.albums.AllowAnimations = true;
            this.albums.AllowMouseEffects = true;
            this.albums.AllowToggling = false;
            this.albums.AnimationSpeed = 200;
            this.albums.AutoGenerateColors = false;
            this.albums.AutoRoundBorders = false;
            this.albums.AutoSizeLeftIcon = true;
            this.albums.AutoSizeRightIcon = true;
            this.albums.BackColor = System.Drawing.Color.Transparent;
            this.albums.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.albums.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("albums.BackgroundImage")));
            this.albums.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.albums.ButtonText = "Albums";
            this.albums.ButtonTextMarginLeft = 0;
            this.albums.ColorContrastOnClick = 45;
            this.albums.ColorContrastOnHover = 45;
            this.albums.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.albums.CustomizableEdges = borderEdges2;
            this.albums.DialogResult = System.Windows.Forms.DialogResult.None;
            this.albums.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.albums.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.albums.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.albums.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.albums.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albums.ForeColor = System.Drawing.Color.White;
            this.albums.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albums.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.albums.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.albums.IconMarginLeft = 11;
            this.albums.IconPadding = 10;
            this.albums.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.albums.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.albums.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.albums.IconSize = 25;
            this.albums.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.albums.IdleBorderRadius = 1;
            this.albums.IdleBorderThickness = 1;
            this.albums.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.albums.IdleIconLeftImage = null;
            this.albums.IdleIconRightImage = null;
            this.albums.IndicateFocus = false;
            this.albums.Location = new System.Drawing.Point(0, 126);
            this.albums.Name = "albums";
            this.albums.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.albums.OnDisabledState.BorderRadius = 0;
            this.albums.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.albums.OnDisabledState.BorderThickness = 1;
            this.albums.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.albums.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.albums.OnDisabledState.IconLeftImage = null;
            this.albums.OnDisabledState.IconRightImage = null;
            this.albums.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.albums.onHoverState.BorderRadius = 0;
            this.albums.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.albums.onHoverState.BorderThickness = 1;
            this.albums.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.albums.onHoverState.ForeColor = System.Drawing.Color.White;
            this.albums.onHoverState.IconLeftImage = null;
            this.albums.onHoverState.IconRightImage = null;
            this.albums.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.albums.OnIdleState.BorderRadius = 0;
            this.albums.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.albums.OnIdleState.BorderThickness = 1;
            this.albums.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.albums.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.albums.OnIdleState.IconLeftImage = null;
            this.albums.OnIdleState.IconRightImage = null;
            this.albums.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.albums.OnPressedState.BorderRadius = 0;
            this.albums.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.albums.OnPressedState.BorderThickness = 1;
            this.albums.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.albums.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.albums.OnPressedState.IconLeftImage = null;
            this.albums.OnPressedState.IconRightImage = null;
            this.albums.Size = new System.Drawing.Size(228, 47);
            this.albums.TabIndex = 0;
            this.albums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.albums.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.albums.TextMarginLeft = 0;
            this.albums.TextPadding = new System.Windows.Forms.Padding(0);
            this.albums.UseDefaultRadiusAndThickness = true;
            // 
            // artists
            // 
            this.artists.AllowAnimations = true;
            this.artists.AllowMouseEffects = true;
            this.artists.AllowToggling = false;
            this.artists.AnimationSpeed = 200;
            this.artists.AutoGenerateColors = false;
            this.artists.AutoRoundBorders = false;
            this.artists.AutoSizeLeftIcon = true;
            this.artists.AutoSizeRightIcon = true;
            this.artists.BackColor = System.Drawing.Color.Transparent;
            this.artists.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.artists.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("artists.BackgroundImage")));
            this.artists.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.artists.ButtonText = "Artists";
            this.artists.ButtonTextMarginLeft = 0;
            this.artists.ColorContrastOnClick = 45;
            this.artists.ColorContrastOnHover = 45;
            this.artists.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.artists.CustomizableEdges = borderEdges1;
            this.artists.DialogResult = System.Windows.Forms.DialogResult.None;
            this.artists.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.artists.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.artists.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.artists.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.artists.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artists.ForeColor = System.Drawing.Color.White;
            this.artists.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artists.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.artists.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.artists.IconMarginLeft = 11;
            this.artists.IconPadding = 10;
            this.artists.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.artists.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.artists.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.artists.IconSize = 25;
            this.artists.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.artists.IdleBorderRadius = 1;
            this.artists.IdleBorderThickness = 1;
            this.artists.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.artists.IdleIconLeftImage = null;
            this.artists.IdleIconRightImage = null;
            this.artists.IndicateFocus = false;
            this.artists.Location = new System.Drawing.Point(0, 179);
            this.artists.Name = "artists";
            this.artists.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.artists.OnDisabledState.BorderRadius = 0;
            this.artists.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.artists.OnDisabledState.BorderThickness = 1;
            this.artists.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.artists.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.artists.OnDisabledState.IconLeftImage = null;
            this.artists.OnDisabledState.IconRightImage = null;
            this.artists.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.artists.onHoverState.BorderRadius = 0;
            this.artists.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.artists.onHoverState.BorderThickness = 1;
            this.artists.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.artists.onHoverState.ForeColor = System.Drawing.Color.White;
            this.artists.onHoverState.IconLeftImage = null;
            this.artists.onHoverState.IconRightImage = null;
            this.artists.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.artists.OnIdleState.BorderRadius = 0;
            this.artists.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.artists.OnIdleState.BorderThickness = 1;
            this.artists.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.artists.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.artists.OnIdleState.IconLeftImage = null;
            this.artists.OnIdleState.IconRightImage = null;
            this.artists.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.artists.OnPressedState.BorderRadius = 0;
            this.artists.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.artists.OnPressedState.BorderThickness = 1;
            this.artists.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.artists.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.artists.OnPressedState.IconLeftImage = null;
            this.artists.OnPressedState.IconRightImage = null;
            this.artists.Size = new System.Drawing.Size(228, 47);
            this.artists.TabIndex = 0;
            this.artists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.artists.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.artists.TextMarginLeft = 0;
            this.artists.TextPadding = new System.Windows.Forms.Padding(0);
            this.artists.UseDefaultRadiusAndThickness = true;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BorderColor = System.Drawing.Color.Empty;
            this.player.BorderRadius = 1;
            this.player.BorderThickness = 1;
            this.player.Controls.Add(this.songTime);
            this.player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.player.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.player.Location = new System.Drawing.Point(0, 515);
            this.player.Name = "player";
            this.player.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.player.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.player.ShadowColor = System.Drawing.Color.DarkGray;
            this.player.ShadowDept = 2;
            this.player.ShadowDepth = 1;
            this.player.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.player.ShadowTopLeftVisible = false;
            this.player.Size = new System.Drawing.Size(980, 108);
            this.player.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.player.TabIndex = 0;
            // 
            // songTime
            // 
            this.songTime.AllowCursorChanges = true;
            this.songTime.AllowHomeEndKeysDetection = false;
            this.songTime.AllowIncrementalClickMoves = true;
            this.songTime.AllowMouseDownEffects = false;
            this.songTime.AllowMouseHoverEffects = false;
            this.songTime.AllowScrollingAnimations = true;
            this.songTime.AllowScrollKeysDetection = true;
            this.songTime.AllowScrollOptionsMenu = true;
            this.songTime.AllowShrinkingOnFocusLost = false;
            this.songTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songTime.BackColor = System.Drawing.Color.Transparent;
            this.songTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songTime.BackgroundImage")));
            this.songTime.BindingContainer = null;
            this.songTime.BorderRadius = 1;
            this.songTime.BorderThickness = 1;
            this.songTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songTime.DrawThickBorder = true;
            this.songTime.DurationBeforeShrink = 2000;
            this.songTime.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.songTime.LargeChange = 10;
            this.songTime.Location = new System.Drawing.Point(218, 38);
            this.songTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.songTime.Maximum = 100;
            this.songTime.Minimum = 0;
            this.songTime.MinimumSize = new System.Drawing.Size(0, 41);
            this.songTime.MinimumThumbLength = 18;
            this.songTime.Name = "songTime";
            this.songTime.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.songTime.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.songTime.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.songTime.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songTime.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songTime.ShrinkSizeLimit = 3;
            this.songTime.Size = new System.Drawing.Size(715, 43);
            this.songTime.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songTime.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.songTime.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.songTime.SmallChange = 1;
            this.songTime.TabIndex = 0;
            this.songTime.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.songTime.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.songTime.ThumbLength = 70;
            this.songTime.ThumbMargin = 1;
            this.songTime.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.songTime.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.songTime.Value = 0;
            // 
            // nowPlaying
            // 
            this.nowPlaying.AllowAnimations = true;
            this.nowPlaying.AllowMouseEffects = true;
            this.nowPlaying.AllowToggling = false;
            this.nowPlaying.AnimationSpeed = 200;
            this.nowPlaying.AutoGenerateColors = false;
            this.nowPlaying.AutoRoundBorders = false;
            this.nowPlaying.AutoSizeLeftIcon = true;
            this.nowPlaying.AutoSizeRightIcon = true;
            this.nowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.nowPlaying.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.nowPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nowPlaying.BackgroundImage")));
            this.nowPlaying.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.nowPlaying.ButtonText = "Now Playing...";
            this.nowPlaying.ButtonTextMarginLeft = 0;
            this.nowPlaying.ColorContrastOnClick = 45;
            this.nowPlaying.ColorContrastOnHover = 45;
            this.nowPlaying.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.nowPlaying.CustomizableEdges = borderEdges3;
            this.nowPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nowPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.nowPlaying.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nowPlaying.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.nowPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.nowPlaying.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlaying.ForeColor = System.Drawing.Color.White;
            this.nowPlaying.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nowPlaying.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.nowPlaying.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.nowPlaying.IconMarginLeft = 11;
            this.nowPlaying.IconPadding = 10;
            this.nowPlaying.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nowPlaying.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.nowPlaying.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.nowPlaying.IconSize = 25;
            this.nowPlaying.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.nowPlaying.IdleBorderRadius = 1;
            this.nowPlaying.IdleBorderThickness = 1;
            this.nowPlaying.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.nowPlaying.IdleIconLeftImage = null;
            this.nowPlaying.IdleIconRightImage = null;
            this.nowPlaying.IndicateFocus = false;
            this.nowPlaying.Location = new System.Drawing.Point(0, 20);
            this.nowPlaying.Name = "nowPlaying";
            this.nowPlaying.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.nowPlaying.OnDisabledState.BorderRadius = 0;
            this.nowPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.nowPlaying.OnDisabledState.BorderThickness = 1;
            this.nowPlaying.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nowPlaying.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.nowPlaying.OnDisabledState.IconLeftImage = null;
            this.nowPlaying.OnDisabledState.IconRightImage = null;
            this.nowPlaying.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.nowPlaying.onHoverState.BorderRadius = 0;
            this.nowPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.nowPlaying.onHoverState.BorderThickness = 1;
            this.nowPlaying.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.nowPlaying.onHoverState.ForeColor = System.Drawing.Color.White;
            this.nowPlaying.onHoverState.IconLeftImage = null;
            this.nowPlaying.onHoverState.IconRightImage = null;
            this.nowPlaying.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.nowPlaying.OnIdleState.BorderRadius = 0;
            this.nowPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.nowPlaying.OnIdleState.BorderThickness = 1;
            this.nowPlaying.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.nowPlaying.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.nowPlaying.OnIdleState.IconLeftImage = null;
            this.nowPlaying.OnIdleState.IconRightImage = null;
            this.nowPlaying.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.nowPlaying.OnPressedState.BorderRadius = 0;
            this.nowPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.nowPlaying.OnPressedState.BorderThickness = 1;
            this.nowPlaying.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.nowPlaying.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.nowPlaying.OnPressedState.IconLeftImage = null;
            this.nowPlaying.OnPressedState.IconRightImage = null;
            this.nowPlaying.Size = new System.Drawing.Size(228, 47);
            this.nowPlaying.TabIndex = 0;
            this.nowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nowPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.nowPlaying.TextMarginLeft = 0;
            this.nowPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.nowPlaying.UseDefaultRadiusAndThickness = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 657);
            this.Controls.Add(this.App);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.App.ResumeLayout(false);
            this.mainArea.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.topBar.ResumeLayout(false);
            this.player.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel App;
        private Bunifu.UI.WinForms.BunifuPanel mainArea;
        private Bunifu.UI.WinForms.BunifuPanel sideBar;
        private Bunifu.UI.WinForms.BunifuPanel topBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton songs;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Button close;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton artists;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton albums;
        private Bunifu.UI.WinForms.BunifuShadowPanel player;
        private Bunifu.UI.WinForms.BunifuHSlider songTime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton nowPlaying;
    }
}

