using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TreeNode tovarNode = new TreeNode("Товары");
            tovarNode.Nodes.Add(new TreeNode("Смартфоны"));
            treeView2.Nodes.Add(tovarNode);
            treeView2.Nodes[0].Nodes.Add(new TreeNode("Планшеты"));

            treeView2.CheckBoxes = true;

            treeView3.BeforeSelect += treeView3_BeforeSelect;
            treeView3.BeforeExpand += treeView3_BeforeExpand;
            // заполняем дерево дисками
            FillDriveNodes();

            void treeView3_BeforeExpand(object sender, TreeViewCancelEventArgs e)
            {
                e.Node.Nodes.Clear();
                string[] dirs;
                try
                {
                    if (Directory.Exists(e.Node.FullPath))
                    {
                        dirs = Directory.GetDirectories(e.Node.FullPath);
                        if (dirs.Length != 0)
                        {
                            for (int i = 0; i < dirs.Length; i++)
                            {
                                TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                                FillTreeNode(dirNode, dirs[i]);
                                e.Node.Nodes.Add(dirNode);
                            }
                        }
                    }
                }
                catch (Exception ex) { }
            }
            // событие перед выделением узла
            void treeView3_BeforeSelect(object sender, TreeViewCancelEventArgs e)
            {
                e.Node.Nodes.Clear();
                string[] dirs;
                try
                {
                    if (Directory.Exists(e.Node.FullPath))
                    {
                        dirs = Directory.GetDirectories(e.Node.FullPath);
                        if (dirs.Length != 0)
                        {
                            for (int i = 0; i < dirs.Length; i++)
                            {
                                TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                                FillTreeNode(dirNode, dirs[i]);
                                e.Node.Nodes.Add(dirNode);
                            }
                        }
                    }
                }
                catch (Exception ex) { }
            }

            // получаем все диски на компьютере
            void FillDriveNodes()
            {
                try
                {
                    foreach (DriveInfo drive in DriveInfo.GetDrives())
                    {
                        TreeNode driveNode = new TreeNode { Text = drive.Name };
                        FillTreeNode(driveNode, drive.Name);
                        treeView3.Nodes.Add(driveNode);
                    }
                }
                catch (Exception ex) { }
            }
            // получаем дочерние узлы для определенного узла
            void FillTreeNode(TreeNode driveNode, string path)
            {
                try
                {
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string dir in dirs)
                    {
                        TreeNode dirNode = new TreeNode();
                        dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                        driveNode.Nodes.Add(dirNode);
                    }
                }
                catch (Exception ex) { }
            }
        }
        
    }
}
