using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VSVersionChanger
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> vsVersions =
            new Dictionary<string, string>
        {
            { "Visual Studio 2010", "10.00" },
            { "Visual Studio 2012", "11.00" },
            { "Visual Studio 2013", "12.00" },
            { "Visual Studio 2015", "14.00" },
            { "Visual Studio 2017", "15.00" },
            { "Visual Studio 2019", "16.00" }
        };

        private const string versionLine = "Microsoft Visual Studio Solution File, Format Version ";
        private const string vsVersion = "VisualStudioVersion = ";
        private const string vsMinVersion = "MinimumVisualStudioVersion = ";
        private const string vsCommentVersion = "# Visual Studio ";

        public Form1()
        {
            InitializeComponent();

            Load += ( obj, ev ) =>
            {
                cbVersions.Items.AddRange( vsVersions.Keys.ToArray() );

                btnGetSln.Click += GetProjectLocation;
                btnConvert.Click += ProcessConversion;
                chkBDelMinVersionInfo.CheckedChanged += ConfirmCheck;
            };
        }

        private void ConfirmCheck( object sender, EventArgs e )
        {
            if ( chkBDelMinVersionInfo.Checked && MessageBox.Show( "This will remove the current version as well as the minimum version info. Continue anyway?", "Remove Version Limitation", MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.No )
                chkBDelMinVersionInfo.Checked = false;
        }

        private void GetProjectLocation( object sender, EventArgs e )
        {
            using ( var fbd = new FolderBrowserDialog() )
            {
                fbd.Description = "Select Project Folder";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = false;
                fbd.ShowDialog();

                if ( fbd.SelectedPath != string.Empty )
                {
                    string[] files = System.IO.Directory.GetFiles( fbd.SelectedPath );

                    foreach ( string file in files )
                    {
                        if ( file.Replace( ".sln", "" ).Length < file.Length )
                        {
                            tbSlnLoc.Text = file;
                            tbSlnLoc.SelectionStart = tbSlnLoc.TextLength;

                            btnConvert.Enabled = true;
                            return;
                        }
                    }

                    MessageBox.Show( "Project folder selected is not valid." );
                }
            }
        }

        private void ProcessConversion( object sender, EventArgs e )
        {
            bool isFileVersionChanged = false;
            bool isVersionRemoved = false;
            bool isVersionCommentChanged = false;

            if ( cbVersions.SelectedIndex != -1 )
            {
                string[] fContents = System.IO.File.ReadAllLines( tbSlnLoc.Text );

                for ( int i = 0; i < fContents.Length; i++ )
                {
                    if ( !isFileVersionChanged && fContents[ i ].Contains( versionLine ) )
                    {
                        int startIndex = fContents[ i ].IndexOf( versionLine ) + versionLine.Length;

                        fContents[ i ] = fContents[ i ].Remove( startIndex, fContents[ i ].Length - startIndex );
                        fContents[ i ] = fContents[ i ].Insert( startIndex, vsVersions.Values.ElementAt( cbVersions.SelectedIndex ) );
                        
                        isFileVersionChanged = true;
                    }

                    if ( !isVersionCommentChanged && fContents[ i ].Contains( vsCommentVersion ) )
                    {
                        fContents[ i ] = "# " + vsVersions.Keys.ElementAt( cbVersions.SelectedIndex );

                        isVersionCommentChanged = true;
                    }

                    if ( !isVersionRemoved && chkBDelMinVersionInfo.Checked )
                    {
                        if ( fContents[ i ].Contains( vsVersion ) )
                        {
                            fContents[ i ] = string.Empty;

                            if ( fContents[ i + 1 ].Contains( vsMinVersion ) )
                                 fContents[ i + 1 ] = string.Empty;

                            isVersionRemoved = true;
                        }
                    }
                }

                if ( MessageBox.Show( "Confirm version change?", "", MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.Yes )
                {
                    System.IO.File.WriteAllLines( tbSlnLoc.Text, fContents );
                    MessageBox.Show( "Version was changed to " + vsVersions.Values.ElementAt( cbVersions.SelectedIndex ) );
                }
            }
        }
    }
}
