namespace Client
{
    partial class NoteForm
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
            this.newNote = new MaterialSkin.Controls.MaterialRaisedButton();
            this.noteBody = new System.Windows.Forms.RichTextBox();
            this.saveNote = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteNote = new MaterialSkin.Controls.MaterialRaisedButton();
            this.noteTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.storedNotes = new System.Windows.Forms.DataGridView();
            this.readNote = new MaterialSkin.Controls.MaterialRaisedButton();
            this.notesDbDataSet = new Client.NotesDbDataSet();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteTableAdapter = new Client.NotesDbDataSetTableAdapters.NoteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.storedNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newNote
            // 
            this.newNote.AutoSize = true;
            this.newNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newNote.Depth = 0;
            this.newNote.Icon = null;
            this.newNote.Location = new System.Drawing.Point(435, 220);
            this.newNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.newNote.Name = "newNote";
            this.newNote.Primary = true;
            this.newNote.Size = new System.Drawing.Size(59, 36);
            this.newNote.TabIndex = 0;
            this.newNote.Text = "New";
            this.newNote.UseVisualStyleBackColor = true;
            this.newNote.Click += new System.EventHandler(this.newNote_Click);
            // 
            // noteBody
            // 
            this.noteBody.Enabled = false;
            this.noteBody.Location = new System.Drawing.Point(578, 184);
            this.noteBody.Name = "noteBody";
            this.noteBody.Size = new System.Drawing.Size(307, 317);
            this.noteBody.TabIndex = 1;
            this.noteBody.Text = "";
            // 
            // saveNote
            // 
            this.saveNote.AutoSize = true;
            this.saveNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveNote.Depth = 0;
            this.saveNote.Icon = null;
            this.saveNote.Location = new System.Drawing.Point(435, 283);
            this.saveNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveNote.Name = "saveNote";
            this.saveNote.Primary = true;
            this.saveNote.Size = new System.Drawing.Size(65, 36);
            this.saveNote.TabIndex = 2;
            this.saveNote.Text = "Save";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.saveNote_Click);
            // 
            // deleteNote
            // 
            this.deleteNote.AutoSize = true;
            this.deleteNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteNote.Depth = 0;
            this.deleteNote.Enabled = false;
            this.deleteNote.Icon = null;
            this.deleteNote.Location = new System.Drawing.Point(435, 345);
            this.deleteNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Primary = true;
            this.deleteNote.Size = new System.Drawing.Size(82, 36);
            this.deleteNote.TabIndex = 5;
            this.deleteNote.Text = "Delete";
            this.deleteNote.UseVisualStyleBackColor = true;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // noteTitle
            // 
            this.noteTitle.Depth = 0;
            this.noteTitle.Enabled = false;
            this.noteTitle.Hint = "Add title";
            this.noteTitle.Location = new System.Drawing.Point(578, 129);
            this.noteTitle.MaxLength = 32767;
            this.noteTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.PasswordChar = '\0';
            this.noteTitle.SelectedText = "";
            this.noteTitle.SelectionLength = 0;
            this.noteTitle.SelectionStart = 0;
            this.noteTitle.Size = new System.Drawing.Size(307, 28);
            this.noteTitle.TabIndex = 6;
            this.noteTitle.TabStop = false;
            this.noteTitle.UseSystemPasswordChar = false;
            // 
            // storedNotes
            // 
            this.storedNotes.AllowUserToAddRows = false;
            this.storedNotes.AllowUserToDeleteRows = false;
            this.storedNotes.AllowUserToResizeColumns = false;
            this.storedNotes.AllowUserToResizeRows = false;
            this.storedNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storedNotes.Location = new System.Drawing.Point(54, 184);
            this.storedNotes.Name = "storedNotes";
            this.storedNotes.ReadOnly = true;
            this.storedNotes.RowHeadersVisible = false;
            this.storedNotes.RowHeadersWidth = 51;
            this.storedNotes.RowTemplate.Height = 24;
            this.storedNotes.Size = new System.Drawing.Size(291, 317);
            this.storedNotes.TabIndex = 7;
            // 
            // readNote
            // 
            this.readNote.AutoSize = true;
            this.readNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.readNote.Depth = 0;
            this.readNote.Enabled = false;
            this.readNote.Icon = null;
            this.readNote.Location = new System.Drawing.Point(435, 404);
            this.readNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.readNote.Name = "readNote";
            this.readNote.Primary = true;
            this.readNote.Size = new System.Drawing.Size(65, 36);
            this.readNote.TabIndex = 8;
            this.readNote.Text = "Read";
            this.readNote.UseVisualStyleBackColor = true;
            this.readNote.Click += new System.EventHandler(this.readNote_Click);
            // 
            // notesDbDataSet
            // 
            this.notesDbDataSet.DataSetName = "NotesDbDataSet";
            this.notesDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataMember = "Note";
            this.noteBindingSource.DataSource = this.notesDbDataSet;
            // 
            // noteTableAdapter
            // 
            this.noteTableAdapter.ClearBeforeFill = true;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 587);
            this.Controls.Add(this.readNote);
            this.Controls.Add(this.storedNotes);
            this.Controls.Add(this.noteTitle);
            this.Controls.Add(this.deleteNote);
            this.Controls.Add(this.saveNote);
            this.Controls.Add(this.noteBody);
            this.Controls.Add(this.newNote);
            this.Name = "NoteForm";
            this.Text = "Welcome, ";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storedNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton newNote;
        private System.Windows.Forms.RichTextBox noteBody;
        private MaterialSkin.Controls.MaterialRaisedButton saveNote;
        private MaterialSkin.Controls.MaterialRaisedButton deleteNote;
        private MaterialSkin.Controls.MaterialSingleLineTextField noteTitle;
        private System.Windows.Forms.DataGridView storedNotes;
        private MaterialSkin.Controls.MaterialRaisedButton readNote;
        private NotesDbDataSet notesDbDataSet;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private NotesDbDataSetTableAdapters.NoteTableAdapter noteTableAdapter;
    }
}