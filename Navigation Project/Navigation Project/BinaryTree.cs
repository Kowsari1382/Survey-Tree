using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Project
{
    class BinaryTree
    {
		bool found = false;
		Node root;
		public Node gsroot
		{
			get
			{
				return root;
			}
			set
			{
				root = value;
			}
		}
		public BinaryTree(int data)
		{
			root = new Node();
			root.gsdata = data;
			root.gsLChild = null;
			root.gsRChild = null;
			root.gsParent = null;
		}
		public void AddNode(Node node, int parent, int data, char LorR)
		{
			if (node != null)
			{
				AddNode(node.gsLChild, parent, data, LorR);
				if (node.gsdata == parent)
				{
					found = true;
					Node newnode = new Node();
					newnode.gsdata = data;
					newnode.gsParent = node;
					Console.WriteLine("Node was added to tree.");
					if (LorR == 'L')
					{
						node.gsLChild = newnode;
					}
					else
					{
						node.gsRChild = newnode;
					}
					return;
				}
				AddNode(node.gsRChild, parent, data, LorR);
			}
		}
		public void DeleteNode(Node node, int data)
		{
			if (node != null)
			{
				DeleteNode(node.gsLChild, data);
				if (node.gsdata == data)
				{
					if(node.gsParent==null)
                    {
						Console.WriteLine("input new root:");
						int newdata = int.Parse(Console.ReadLine());
						root.gsdata = newdata;
                    }
					else if (node.gsParent.gsLChild == node)
					{
						node.gsParent.gsLChild = null;
					}
					else
					{
						node.gsParent.gsRChild = null;
					}
					node.gsParent = null;
					Console.WriteLine("Node was deleted.");
					return;
				}
				DeleteNode(node.gsRChild, data);
			}
		}
		public void inorder(Node node)
		{
			if (node != null)
			{
				inorder(node.gsLChild);
				Console.WriteLine(node.gsdata);
				inorder(node.gsRChild);
			}
		}
		public void postorder(Node node)
		{
			if (node != null)
			{
				postorder(node.gsLChild);
				postorder(node.gsRChild);
				Console.WriteLine(node.gsdata);
			}
		}
		public void preorder(Node node)
		{
			if (node != null)
			{
				Console.WriteLine(node.gsdata);
				preorder(node.gsLChild);
				preorder(node.gsRChild);
			}
		}
	}
}
